using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace MPT_UP_02._01_P50_2_18_26
{
    public partial class Storekeeper : Form
    {
        private Dictionary<string, int> _product = new Dictionary<string, int>();
        private int _toPay = 0;
        private int _budget = 0;
        private List<string> _storageId = new();

        public Storekeeper()
        {
            InitializeComponent();

            Setup();
        }

        private void Setup()
        {
            _budget = Convert.ToInt32(SqlManager.ExecuteCommand("select [value] from Budget")[0]);
            richTextBoxBudget.Text = _budget.ToString();
            foreach (var name in SqlManager.ExecuteCommand("select Imy_postavchika from Postavchik"))
            {
                comboBoxSupplierName.Items.Add(name);
            }

            foreach (var address in SqlManager.ExecuteCommand("select Address from Sklad"))
            {
                comboBoxStorage.Items.Add(address);
            }

            foreach (var id in SqlManager.ExecuteCommand("select Kod_Sklada from Sklad"))
            {
                _storageId.Add(id);
            }

            var productTableData = SqlManager.ExecuteCommand("select * from Tovar");

            for (int i = 0; i < productTableData.Count; i += 4)
            {
                comboBoxProduct.Items.Add(productTableData[i + 1] + " - " + productTableData[i + 2]);
                _product.Add(productTableData[i], Convert.ToInt32(productTableData[i + 2]));
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (_toPay > _budget || _toPay == 0)
            {
                return;
            }

            _budget -= _toPay;
            richTextBoxBudget.Text = _budget.ToString();

            var queryResult = SqlManager.ExecuteCommand(
                $"select Kolichestvo_Tovara from Sklad_Tovar where Id_Sklad = {_storageId[comboBoxStorage.SelectedIndex]} " +
                $"and Id_Tovar = {_product.ElementAt(comboBoxProduct.SelectedIndex).Key}");

            if (queryResult.Count != 0)
            {
                var primaryKey = SqlManager.ExecuteCommand(
                    $"select Id_Sklad_Tovar from Sklad_Tovar where Id_Sklad = {_storageId[comboBoxStorage.SelectedIndex]} " +
                    $"and Id_Tovar = {_product.ElementAt(comboBoxProduct.SelectedIndex).Key}")[0];

                var amount = Convert.ToInt32(queryResult[0]) + Convert.ToInt32(richTextBoxAmount.Text);
                SqlManager.ChangeData("Sklad_Tovar", "Kolichestvo_Tovara", amount.ToString(), "Id_Sklad_Tovar",
                    primaryKey);
            }
            else
            {
                SqlManager.InsertData("Sklad_Tovar", new[] {"Id_Sklad", "Id_Tovar", "Kolichestvo_Tovara"},
                    new[]
                    {
                        _storageId[comboBoxStorage.SelectedIndex],
                        _product.ElementAt(comboBoxProduct.SelectedIndex).Key, richTextBoxAmount.Text
                    });
            }

            SqlManager.ChangeData("Budget", "Value", _budget.ToString(), "id", "0");
        }

        private void richTextBoxAmount_TextChanged(object sender, EventArgs e) // amount entered
        {
            _toPay = _product.ElementAt(comboBoxProduct.SelectedIndex).Value * Convert.ToInt32(richTextBoxAmount.Text);
            richTextBoxPaying.Text = _toPay.ToString();
        }
    }
}