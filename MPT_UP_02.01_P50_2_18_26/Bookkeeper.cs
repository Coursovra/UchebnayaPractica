using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace MPT_UP_02._01_P50_2_18_26
{
    public partial class Bookkeeper : Form
    {
        private List<int> _toPayEmployee = new();
        private List<int> _toPayStore = new();

        private int Budget
        {
            get { return _budget; }
            set
            {
                _budget = value;
                UpdateBudget();
            }
        }

        private int _budget;

        public Bookkeeper()
        {
            InitializeComponent();
            
            Budget = Convert.ToInt32(SqlManager.ExecuteCommand("select [value] from Budget")[0]);
            
            var employeeInfo = SqlManager.ExecuteCommand(
                "select Concat(Sotrudnik.Familiya, ' ', SUBSTRING(Sotrudnik.Imy, 1,1), '.', SUBSTRING(Sotrudnik.Otchestvo, 1,1), '. - ',  Nomer_telefona), Oklad " +
                "from Sotrudnik inner join Dolznosty on Dolznosty.Kod_dolznosty = Sotrudnik.Kod_dolznosty");

            for (int i = 0; i < employeeInfo.Count; i+=2)
            {
                comboBoxEmployees.Items.Add(employeeInfo[i] + " - " + employeeInfo[i+1]);
                _toPayEmployee.Add(Convert.ToInt32(employeeInfo[i+1]));
            }

            var storeInfo =
                SqlManager.ExecuteCommand(" select Summa_arendy, Kommunalynie_uslugi, [Address] from Torgovaya_tochka");
            
            for (int i = 0; i < storeInfo.Count; i+=3)
            {
                var summ = Convert.ToInt32(storeInfo[i]) + Convert.ToInt32(storeInfo[i + 1]);
                comboBoxStore.Items.Add(storeInfo[i + 2] + " - " + summ);
                _toPayStore.Add(summ);
            }
        }

        private void buttonPay1_Click(object sender, EventArgs e)
        {
            if(_toPayEmployee[comboBoxEmployees.SelectedIndex] > _budget) { return; }
            Budget -= _toPayEmployee[comboBoxEmployees.SelectedIndex];
        }

        private void UpdateBudget()
        {
            labelBudget.Text = Budget.ToString();
            SqlManager.ChangeData("Budget", "value", Budget.ToString(), "id", "0");
        }

        private void buttonPay2_Click(object sender, EventArgs e)
        {
            if(_toPayStore[comboBoxStore.SelectedIndex] > _budget) { return; }

            Budget -= _toPayStore[comboBoxStore.SelectedIndex];
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}