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

            for (int i = 0; i < employeeInfo.Count; i += 2)
            {
                comboBoxEmployees.Items.Add(employeeInfo[i] + " - " + employeeInfo[i + 1]);
                _toPayEmployee.Add(Convert.ToInt32(employeeInfo[i + 1]));
            }

            var storeInfo =
                SqlManager.ExecuteCommand(" select Summa_arendy, Kommunalynie_uslugi, [Address] from Torgovaya_tochka");

            for (int i = 0; i < storeInfo.Count; i += 3)
            {
                var summ = Convert.ToInt32(storeInfo[i]) + Convert.ToInt32(storeInfo[i + 1]);
                comboBoxStore.Items.Add(storeInfo[i + 2] + " - " + summ);
                _toPayStore.Add(summ);
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Выплатить зарплату" для снятия с бюджета суммы равной окладу выбранного сотрудника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPay1_Click(object sender, EventArgs e)
        {
            if (_toPayEmployee[comboBoxEmployees.SelectedIndex] > _budget)
            {
                MessageBox.Show("Не хватает денежных средств");
                return;
            }

            Budget -= _toPayEmployee[comboBoxEmployees.SelectedIndex];
            MessageBox.Show("Зарплата выплачена");
        }

        /// <summary>
        /// Обновление бюджета в базе данных и соответствующей записи на странице
        /// </summary>
        private void UpdateBudget()
        {
            labelBudget.Text = "Бюджет: " + Budget;
            SqlManager.ChangeData("Budget", "value", Budget.ToString(), "id", "0");
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Выплатить организациям" для снятия с бюджета суммы равной сумме аренды и коммунальных услуг выбранной торговой точки
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonPay2_Click(object sender, EventArgs e)
        {
            if (_toPayStore[comboBoxStore.SelectedIndex] > _budget)
            {
                return;
            }

            MessageBox.Show("Аренда и коммунальные услуги оплачены");
            Budget -= _toPayStore[comboBoxStore.SelectedIndex];
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
    }
}