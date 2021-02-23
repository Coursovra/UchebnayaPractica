using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MPT_UP_02._01_P50_2_18_26
{
    public partial class AdminBD : Form //todo: только таблицу поставщика можно редактировать?
    {
        private Dictionary<string, string> _comboBoxValue = new();
        private string _comboBoxSelectedItem;
        public AdminBD()
        {
            InitializeComponent();
            Setup();
        }

        private void Setup()
        {
            _comboBoxValue.Add("Поставщик", "Postavchik");
            _comboBoxValue.Add("Товар", "Tovar");
            _comboBoxValue.Add("Секции торговой точки", "Ceksii_torgovoy_tochki");
            _comboBoxValue.Add("Чек", "Chek");
            _comboBoxValue.Add("Должности", "Dolznosty");
            _comboBoxValue.Add("Покупатели", "Pokupateli");
            _comboBoxValue.Add("Склад", "Sklad");
            _comboBoxValue.Add("Сотрудник", "Sotrudnik");
            _comboBoxValue.Add("Торговая точка", "Torgovaya_tochka");
            comboBox1.SelectedIndex = 0;
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            _comboBoxValue.TryGetValue(comboBox1.SelectedItem.ToString(), out string _comboBoxSelectedItem);
            SqlManager.LoadToDGV(dataGridView1, $"select * from {_comboBoxSelectedItem}");
        }
        
        private void buttonDelete_Click(object sender, EventArgs e)
        {
            var selectedPrimaryKey = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            if(selectedPrimaryKey == null) { return; }
            var primaryKeyColumnName = dataGridView1.Columns[0].Name;
            _comboBoxValue.TryGetValue(comboBox1.SelectedItem.ToString(), out string _comboBoxSelectedItem);
            SqlManager.DeleteData(_comboBoxSelectedItem, primaryKeyColumnName, selectedPrimaryKey);
            SqlManager.LoadToDGV(dataGridView1, $"select * from {_comboBoxSelectedItem}");
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            AddContractor newForm= new AddContractor();
            newForm.Show();
            Hide();
            
        }

        private void buttonChange_Click(object sender, EventArgs e)
        {
            EditContractor newForm= new EditContractor(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
            newForm.Show();
            Hide();          
        }
    }
}