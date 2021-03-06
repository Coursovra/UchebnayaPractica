﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MPT_UP_02._01_P50_2_18_26
{
    public partial class Seller : Form
    {
        private string _myId = "-1";
        private List<string> _customerId = new();
        private List<string> _productId = new();
        private List<string> _productPrice = new();
        private bool _isCreated = false;
        private string _checkId = "-1";
        private string _mySectionId = "-1";
        private List<CheckItems> _checkItemsList;
        private List<CheckItems> _bdItemsList;
        private int _toPay = 0;

        public Seller(string myId, string sectionId)
        {
            InitializeComponent();
            _myId = myId;
            _mySectionId = sectionId;
            _bdItemsList = new();
            Setup();
        }

        /// <summary>
        /// Добавление айди покупателей в массив и загрузка данных в выпадающий список
        /// </summary>
        private void Setup()
        {
            foreach (var id in SqlManager.ExecuteCommand("select Id_Customer from Customer"))
            {
                _customerId.Add(id);
            }

            UpdateCustomersComboBox();
            UpdateProductsComboBox();
        }

        /// <summary>
        /// Загрузка данных о покупателях в соответствующий выпадающий список
        /// </summary>
        private void UpdateCustomersComboBox()
        {
            comboBoxCustomer.Items.Clear();
            var queryResult = SqlManager.ExecuteCommand(
                "select Concat(Surname, ' ', SUBSTRING([Name], 1,1), '.', SUBSTRING(SecondName, 1,1), '.'), BirthDate, PhoneNumber	from Customer");
            for (int i = 0; i < queryResult.Count; i += 3)
            {
                comboBoxCustomer.Items.Add(queryResult[i] + " " + Convert.ToDateTime(queryResult[i + 1]).ToString("d") +
                                           " " +
                                           queryResult[i + 2]);
            }
        }
        
        /// <summary>
        /// Загрузка данных о товарах в соответствующий выпадающий список
        /// </summary>
        private void UpdateProductsComboBox()
        {
            comboBoxProduct.Items.Clear();
            _productId.Clear();
            _productPrice.Clear();
            _bdItemsList.Clear();
            var list = SqlManager.ExecuteCommand("select Tovar_Kolichestvo, Nazvanie_producta, Id_Tovar, Sena " +
                                                 "from Ceksiya_Tovar " +
                                                 $"inner join Tovar on Tovar.Kod_tovara = Id_Tovar where Id_Seksiya = {_mySectionId}");
            for (var index = 0; index < list.Count; index += 4)
            {
                var amount = list[index];
                if (Convert.ToInt32(amount) > 0)
                {
                    comboBoxProduct.Items.Add(list[index + 1] + " (" + amount + ")");
                    _productId.Add(list[index + 2]);
                    _productPrice.Add(list[index + 3]);
                    _bdItemsList.Add(new CheckItems() {Amount = Convert.ToInt32(amount)});
                }
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Выйти" для выхода из программы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Hide();
            Form1 newForm = new Form1();
            newForm.Show();
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Добавить продавца" для перехода на соответствующую страницу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddSeller_Click(object sender, EventArgs e)
        {
            AddSeller newForm = new AddSeller(_mySectionId);
            newForm.ShowDialog();
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Добавить посетителя" для перехода на соответствующую страницу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer newForm = new AddCustomer();
            newForm.ShowDialog();
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Добавить в чек" для добавления выбранного товара в чек
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (!(comboBoxCustomer.SelectedIndex >= 0 && comboBoxProduct.SelectedIndex >= 0 &&
                  Regex.IsMatch(richTextBoxAmount.Text, "^[0-9]+$") && richTextBoxAmount.Text[0] != '0'))
            {
                return;
            }

            dataGridView1.Columns.Clear();
            
            if (!_isCreated)
            {
                _toPay = 0;
                labelToPay.Text = "";
                CreateCheck();
                InsertIntoCheck();
            }
            else
            {
                InsertIntoCheck();
            }

            UpdateProductsComboBox();
        }
        
        /// <summary>
        /// Создание чека
        /// </summary>
        private void CreateCheck()
        {
            var currentDate = DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss");
            _checkItemsList = new();
            SqlManager.InsertData("Chek", new[] {"Kod_pokupately", "Kod_sotrudnika", "Date"},
                new[]
                {
                    _customerId[comboBoxCustomer.SelectedIndex], _myId, currentDate
                });


            _checkId = SqlManager.ExecuteCommand(
                    $"select Kod_cheka from Chek where Kod_pokupately = '{_customerId[comboBoxCustomer.SelectedIndex]}' " +
                    $"and Kod_sotrudnika = '{_myId}' and [Date] = '{currentDate}'")
                [0];
            _isCreated = true;
        }

        /// <summary>
        /// Добавление товара в чек в базе данных,
        /// обновление суммы для оплаты равной стоимости товара умноженной на его выбранное количество,
        /// вычитание количества товара из текущей секции в базе данных
        /// </summary>
        private void InsertIntoCheck()
        {
            var item = new CheckItems()
            {
                Amount = Convert.ToInt32(richTextBoxAmount.Text),
                Price = Convert.ToInt32(_productPrice[comboBoxProduct.SelectedIndex])
            };
            _checkItemsList.Add(item);

            if (_bdItemsList[comboBoxProduct.SelectedIndex].Amount - item.Amount >= 0)
            {
                var primaryKey = SqlManager.ExecuteCommand(
                    $"select Id_Ceksiya_Tovar from Ceksiya_Tovar where Id_Seksiya = {_mySectionId} " +
                    $"and Id_Tovar = {_productId[comboBoxProduct.SelectedIndex]}")[0];

                _bdItemsList[comboBoxProduct.SelectedIndex].Amount -= item.Amount;

                SqlManager.ChangeData("Ceksiya_Tovar", "Tovar_Kolichestvo",
                    _bdItemsList[comboBoxProduct.SelectedIndex].Amount.ToString(), //remove from section storage 
                    "Id_Ceksiya_Tovar", primaryKey);


                SqlManager.InsertData("Check_Product",
                    new[] {"IdCheck", "IdProduct", "Tovar_Kolichestvo"}, //add amount in check
                    new[] {_checkId, _productId[comboBoxProduct.SelectedIndex], richTextBoxAmount.Text});

                _toPay += item.Price * Convert.ToInt32(richTextBoxAmount.Text);

                if (_bdItemsList[comboBoxProduct.SelectedIndex].Amount - item.Amount == 0)
                {
                    _bdItemsList.RemoveAt(comboBoxProduct.SelectedIndex);
                }

                labelToPay.Text = $"К оплате: {_toPay}";
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Завершить создание чека" для отображения чека в таблице и добавление суммы в бюдежт в базе данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonShowCheck_Click(object sender, EventArgs e)
        {
            if (_checkId == null)
            {
                return;
            }

            dataGridView1.Columns.Clear();
            _isCreated = false;
            SqlManager.LoadToDGV(dataGridView1,
                "select Concat(Surname, ' ', SUBSTRING([Name], 1,1), '.', SUBSTRING(SecondName, 1,1), '.') " +
                "as \"ФИО Покупателя\", Concat(Familiya, ' ', SUBSTRING(Imy, 1,1), '.', SUBSTRING(Otchestvo, 1,1), '.') " +
                "as \"ФИО Продавца\", Tovar.Nazvanie_producta as Продукт, Tovar_Kolichestvo " +
                "as Количество from chek inner join Customer on Customer.Id_Customer = Kod_pokupately " +
                "inner join Sotrudnik on Sotrudnik.Kod_sotrudnika = chek.Kod_sotrudnika " +
                "inner join Check_Product on Check_Product.IdCheck = Kod_cheka " +
                $"inner join Tovar on Tovar.Kod_tovara = IdProduct where Kod_cheka = {_checkId}");

            var budget = Convert.ToInt32(SqlManager.ExecuteCommand("select [value] from Budget")[0]);
            SqlManager.ChangeData("Budget", "value", (budget + _toPay).ToString(), "id", "0");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            
            MessageBox.Show("Чек создан");
        }

        /// <summary>
        /// Обработчик выбора элемента из выпадающего списка с посетителями для сброса чека
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.Columns.Clear();
            _toPay = 0;
            labelToPay.Text = "";
            richTextBoxAmount.Text = "";
            _isCreated = false;
            _checkId = null;
        }

        /// <summary>
        /// Обработчик открытия страницы для обновления данных в выпадающем списке
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Seller_Load(object sender, EventArgs e)
        {
            UpdateCustomersComboBox();
        }
    }

    /// <summary>
    /// Класс для товаров в чеке
    /// </summary>
    public class CheckItems
    {
        public int Amount;
        public int Price;
    }
}