using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MPT_UP_02._01_P50_2_18_26
{
    public partial class AddProduct : Form
    {
        private List<string> _storageId = new();
        private List<string> _storeId = new();
        private List<string> _productId = new();
        private int _amountOfProductInStorage = 0;

        public AddProduct()
        {
            InitializeComponent();

            ComboBoxSetup();
        }

        /// <summary>
        /// Загрузка данных из базы данных в выпадающие списки и добавление айди в массивы
        /// </summary>
        private void ComboBoxSetup()
        {
            foreach (var address in SqlManager.ExecuteCommand("select Address from Sklad"))
            {
                comboBoxStorage.Items.Add(address);
            }

            foreach (var id in SqlManager.ExecuteCommand("select Kod_sklada from Sklad"))
            {
                _storageId.Add(id);
            }

            foreach (var address in SqlManager.ExecuteCommand("select Address from Torgovaya_tochka"))
            {
                comboBoxStore.Items.Add(address);
            }

            foreach (var id in SqlManager.ExecuteCommand("select Kod_torgovoy_tochki from Torgovaya_tochka"))
            {
                _storeId.Add(id);
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Назад" для перехода на предыдущую страницу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Поплнить" для поплнения торговой точки товаром с выбранного склада в базе данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxStorage.SelectedIndex >= 0 && comboBoxStore.SelectedIndex >= 0 &&
                comboBoxProduct.SelectedIndex >= 0 &&
                Regex.IsMatch(richTextBoxAmount.Text, "^[0-9]+$"))
            {
                _amountOfProductInStorage = Convert.ToInt32(SqlManager.ExecuteCommand(
                    $"select Kolichestvo_Tovara from Sklad_Tovar where Id_Sklad = {_storageId[comboBoxStorage.SelectedIndex]} " +
                    $"and Id_Tovar = {_productId[comboBoxProduct.SelectedIndex]}")[0]);

                if (Convert.ToInt32(richTextBoxAmount.Text) > _amountOfProductInStorage)
                {
                    MessageBox.Show("Введеное количество больше количества товара на складе");
                    return;
                }

                var amountOfProductInStoreResult = SqlManager.ExecuteCommand(
                    $"select Tovar_Kolichestvo from TorgTochka_Tovar where Id_tovar = {_productId[comboBoxProduct.SelectedIndex]} " +
                    $"and Id_TorgTochka= {_storeId[comboBoxStore.SelectedIndex]}");
                var productAmount = Convert.ToInt32(richTextBoxAmount.Text);
                if (amountOfProductInStoreResult.Count == 0)
                {

                    SqlManager.InsertData("TorgTochka_Tovar", new[] {"Id_TorgTochka", "Id_Tovar", "Tovar_Kolichestvo"},
                        new[]
                        {
                            _storeId[comboBoxStore.SelectedIndex], _productId[comboBoxProduct.SelectedIndex],
                            productAmount.ToString()
                        });
                }
                else
                {
                    var amountOfProductInStore = Convert.ToInt32(amountOfProductInStoreResult[0]);
                    var primaryKey = SqlManager.ExecuteCommand(
                            "select Id_TorgTochka_Tovar from TorgTochka_Tovar " +
                            $"where Id_TorgTochka = {_storeId[comboBoxStore.SelectedIndex]} and Id_Tovar = {_productId[comboBoxProduct.SelectedIndex]}")
                        [0];
                    SqlManager.ChangeData("TorgTochka_Tovar", "Tovar_Kolichestvo",
                        (amountOfProductInStore + productAmount).ToString(), "Id_TorgTochka_Tovar", primaryKey);
                }

                //remove from storage
                SqlManager.ChangeData("Sklad_Tovar", "Kolichestvo_Tovara",
                    (_amountOfProductInStorage - productAmount).ToString(), "Id_Sklad_Tovar",
                    SqlManager.ExecuteCommand(
                        $"select Id_Sklad_Tovar from Sklad_Tovar where Id_Sklad = {_storageId[comboBoxStorage.SelectedIndex]} " +
                        $"and Id_Tovar = {_productId[comboBoxProduct.SelectedIndex]}")[0]);

                UpdateProductComboBox();
                MessageBox.Show("Продукт добавлен");
            }
            else
            {
                MessageBox.Show("Ошибка ввода данных");
            }
        }

        /// <summary>
        /// Обработчик выбора элемента из выпадающего списка со складами для загрузки данных из базы данных о товарах на этом складе
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxStorage_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateProductComboBox();
        }

        /// <summary>
        /// Загрузка данных в выпадающий список и добавление айди в массив
        /// </summary>
        private void UpdateProductComboBox()
        {
            comboBoxProduct.Items.Clear();
            _productId.Clear();
            var productInfo = SqlManager.ExecuteCommand(
                "select Nazvanie_producta, Kolichestvo_Tovara from Sklad_Tovar inner join Tovar " +
                $"on Sklad_Tovar.Id_Tovar = Tovar.Kod_tovara where Id_Sklad = {_storageId[comboBoxStorage.SelectedIndex]}");
            for (int i = 0; i < productInfo.Count; i += 2)
            {
                comboBoxProduct.Items.Add(productInfo[i] + " - " + productInfo[i + 1]);
            }

            foreach (var id in SqlManager.ExecuteCommand("select Id_tovar from Sklad_Tovar inner join Tovar " +
                                                         $"on Sklad_Tovar.Id_Tovar = Tovar.Kod_tovara where Id_Sklad = {_storageId[comboBoxStorage.SelectedIndex]}")
            )
            {
                _productId.Add(id);
            }
        }

        /// <summary>
        /// Обработчик выбора элемента из выпадающего списка с товарами для загрузки данных о их количестве из базы данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxProduct_SelectedIndexChanged(object sender, EventArgs e)
        {
            _amountOfProductInStorage = Convert.ToInt32(SqlManager.ExecuteCommand(
                "select Kolichestvo_Tovara from Sklad_Tovar inner join Tovar " +
                "on Sklad_Tovar.Id_Tovar = Tovar.Kod_tovara where Id_tovar = " +
                $"{_productId[comboBoxProduct.SelectedIndex]}")[0]);
        }
    }
}