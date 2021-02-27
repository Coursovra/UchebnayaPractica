using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MPT_UP_02._01_P50_2_18_26
{
    public partial class AddCustomer : Form
    {
        public AddCustomer()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Поплнить" для
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Добавить" для добавления данных о покупателе в базу данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(richTextBoxName.Text, "^[A-Za-zА-Яа-я]+$")
                && Regex.IsMatch(richTextBoxSurname.Text, "^[A-Za-zА-Яа-я]+$")
                && (Regex.IsMatch(richTextBoxSecondName.Text, "^[A-Za-zА-Яа-я]+$") ||
                    richTextBoxSecondName.Text == null)
                && Regex.IsMatch(richTextBoxPhoneNumber.Text, "^[0-9]+$")
                && dateTimePicker1.Text != null)
            {
                if (SqlManager
                    .ExecuteCommand(
                        $"select * from Customer where[PhoneNumber] = {richTextBoxPhoneNumber.Text}").Count != 0)
                {
                    MessageBox.Show("Данный пользователь уже существует");
                    return;
                }

                SqlManager.InsertData("Customer",
                    new[] {"Name", "Surname", "SecondName", "PhoneNumber", "BirthDate", "DateOfVisit"},
                    new[]
                    {
                        richTextBoxName.Text, richTextBoxSurname.Text, richTextBoxSecondName.Text,
                        richTextBoxPhoneNumber.Text, Convert.ToDateTime(dateTimePicker1.Text).ToString("yyyy-MM-dd"),
                        DateTime.Now.ToString("yyyy-MM-dd hh:mm:ss")
                    });
                MessageBox.Show("Покупатель добавлен");
            }
            else
            {
                MessageBox.Show("Ошибка ввода данных");
            }
        }
    }
}