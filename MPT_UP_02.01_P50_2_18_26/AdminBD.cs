﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace MPT_UP_02._01_P50_2_18_26
{
    public partial class AdminBD : Form
    {
        private Dictionary<string, string> _comboBoxValue = new();
        private string _comboBoxSelectedItem;

        SqlCommand _command;
        SqlDataAdapter _dataAdapter;
        private BindingSource _bindingSource = null;
        private SqlCommandBuilder _commandBuilder = null;
        DataTable _dataTable = new DataTable();

        public AdminBD()
        {
            InitializeComponent();
            Setup();
        }

        /// <summary>
        /// Добавление физических названий таблиц
        /// </summary>
        private void Setup()
        {
            _comboBoxValue.Add("Бюджет", "Budget");
            _comboBoxValue.Add("Секции торговой точки", "Ceksii_torgovoy_tochki");
            _comboBoxValue.Add("Секция торговой точки - сотрудник", "Ceksiya_torgovoy_tochki_Sotrudnik");
            _comboBoxValue.Add("Секция - товар", "Ceksiya_Tovar");
            _comboBoxValue.Add("Чек - продукт", "Check_Product");
            _comboBoxValue.Add("Чек", "Chek");
            _comboBoxValue.Add("Покупатель", "Customer");
            _comboBoxValue.Add("Должности", "Dolznosty");
            _comboBoxValue.Add("Поставщик", "Postavchik");
            _comboBoxValue.Add("Склад", "Sklad");
            _comboBoxValue.Add("Склад - товар", "Sklad_Tovar");
            _comboBoxValue.Add("Сотрудник", "Sotrudnik");
            _comboBoxValue.Add("Торговая точка", "Torgovaya_tochka");
            _comboBoxValue.Add("Торговая точка - товар", "TorgTochka_Tovar");
            _comboBoxValue.Add("Товар", "Tovar");

            comboBox1.Items.Clear();
            foreach (var value in _comboBoxValue)
            {
                comboBox1.Items.Add(value.Key);
            }

            comboBox1.SelectedIndex = 0;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.AllowUserToDeleteRows = false;
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Выход" для закрытия программы
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
        /// Обработчик выбора элемента из выпадающего списка с таблицами для загрузки данных из этой таблицы из базы данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _comboBoxValue.TryGetValue(comboBox1.SelectedItem.ToString(), out string _comboBoxSelectedItem);
            DataBind();
            SqlManager.LoadToDGV(dataGridView1, $"select * from {_comboBoxSelectedItem}");
            dataGridView1.Columns[0].Visible = false;
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Добавить поставщика" для перехода на соответствующую страницу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddContractor newForm = new AddContractor();
            newForm.ShowDialog();
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Изменить поставщика" для перехода на соответствующую страницу
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonChange_Click(object sender, EventArgs e)
        {
            _comboBoxValue.TryGetValue(comboBox1.SelectedItem.ToString(), out string _comboBoxSelectedItem);
            if (_comboBoxSelectedItem != "Postavchik")
            {
                return;
            }

            EditContractor newForm = new EditContractor(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            newForm.ShowDialog();
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Обновить базу данных" для применения внесенных изменений в базу данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            dataGridView1.EndEdit();
            try
            {
                DataBind();
                _dataAdapter.Update(_dataTable);
                _dataTable.AcceptChanges();
            }
            catch (Exception exception)
            {
                _comboBoxValue.TryGetValue(comboBox1.SelectedItem.ToString(), out string _comboBoxSelectedItem);
                _dataAdapter = new SqlDataAdapter($"SELECT * FROM {_comboBoxSelectedItem}", SqlManager.NewConnection());
                _commandBuilder = new SqlCommandBuilder(_dataAdapter);
                _dataAdapter.Fill(_dataTable);
                _bindingSource = new BindingSource {DataSource = _dataTable};
                dataGridView1.DataSource = _bindingSource;
                MessageBox.Show(exception.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
        }

        /// <summary>
        /// Привязка данных для дальнейшего обновления базы данных
        /// </summary>
        private void DataBind()
        {
            var connection = SqlManager.NewConnection();
            _comboBoxValue.TryGetValue(comboBox1.SelectedItem.ToString(), out string _comboBoxSelectedItem);
            String queryString1 = $"SELECT * FROM {_comboBoxSelectedItem}";


            _dataAdapter = new SqlDataAdapter(queryString1, connection);
            _commandBuilder = new SqlCommandBuilder(_dataAdapter);
            _commandBuilder.GetInsertCommand();
            _commandBuilder.GetUpdateCommand();
            _commandBuilder.GetDeleteCommand();
            _dataTable = (DataTable) dataGridView1.DataSource;
        }

        /// <summary>
        /// Обработчик открытия страницы для обновления данных в таблице
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void AdminBD_Activated(object sender, EventArgs e)
        {
            _comboBoxValue.TryGetValue(comboBox1.SelectedItem.ToString(), out string _comboBoxSelectedItem);
            SqlManager.LoadToDGV(dataGridView1, $"select * from {_comboBoxSelectedItem}");
        }
    }
}