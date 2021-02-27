using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MPT_UP_02._01_P50_2_18_26
{
    public partial class AdminTT : Form
    {
        private List<string> _tableData = new List<string>();
        private List<string> _phoneNumbers = new List<string>();

        public AdminTT()
        {
            InitializeComponent();
            _tableData =
                SqlManager.ExecuteCommand("select Surname, [Name], SecondName, BirthDate, PhoneNumber from Customer");
            if (_tableData.Count == 0)
            {
                return;
            }

            for (int i = 0; i < _tableData.Count; i += 5)
            {
                string date = Convert.ToDateTime(_tableData[i + 3]).ToString("d");
                var customerData = _tableData[i] + " " + _tableData[i + 1][0] + "." + _tableData[i + 2][0] + ". " +
                                   date +
                                   " " +
                                   _tableData[i + 4];
                comboBox1.Items.Add(customerData);
                _phoneNumbers.Add(_tableData[i + 4]);
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
        /// Обработчик нажатия кнопки "Пополнение товарами торговой точки" для перехода на соответствующую страницу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddProduct newForm = new AddProduct();
            newForm.ShowDialog();
        }

        /// <summary>
        /// Обработчик выбора элемента из выпадающего списка с посетителями для загрузки данных о покупках из базы данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex == -1)
            {
                return;
            }

            SqlManager.LoadToDGV(dataGridView1,
                "select Tovar.Nazvanie_producta as \"Название продукта\", Concat(Customer.Surname, ' ', " +
                "SUBSTRING(Customer.Name, 1,1), '.', SUBSTRING(Customer.SecondName, 1,1), '.') as \"ФИО Покупателя\", " +
                "Concat(Sotrudnik.Familiya, ' ', SUBSTRING(Sotrudnik.Imy, 1,1), '.', SUBSTRING(Sotrudnik.Otchestvo, 1,1), '.')" +
                " as \"Сотрудник\", Chek.[Date] as \"Дата печати\" from [Chek] inner join Customer on Chek.Kod_pokupately = " +
                "Customer.Id_Customer inner join Check_Product on Chek.Kod_cheka = Check_Product.IdCheck inner join Sotrudnik " +
                "on Chek.Kod_sotrudnika = Sotrudnik.Kod_sotrudnika inner join Tovar on Check_Product.IdProduct = Tovar.Kod_tovara " +
                $"where Customer.PhoneNumber = '{_phoneNumbers[comboBox1.SelectedIndex]}'");
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }
    }
}