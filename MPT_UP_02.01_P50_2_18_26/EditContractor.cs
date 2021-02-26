using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MPT_UP_02._01_P50_2_18_26
{
    public partial class EditContractor : Form
    {
        private string _supplierId;

        public EditContractor(string supplierId)
        {
            InitializeComponent();
            _supplierId = supplierId;
            richTextBox1.Text =
                SqlManager.ExecuteCommand(
                        $"select Imy_postavchika, Gorod_postavchika from Postavchik where Kod_postavchika = '{supplierId}'")
                    [0];
            richTextBox2.Text =
                SqlManager.ExecuteCommand(
                        $"select Imy_postavchika, Gorod_postavchika from Postavchik where Kod_postavchika = '{supplierId}'")
                    [1];
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
        /// Обработчик нажатия кнопки "Сохранить изменения" для сохранения изменений в базе данных
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSave_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(richTextBox1.Text, @"^[a-zA-ZА-Яа-я.0-9]+$") &&
                Regex.IsMatch(richTextBox2.Text, @"^[a-zA-ZА-Яа-я]+$"))
            {
                SqlManager.ExecuteCommand(
                    $"update [Postavchik] set Imy_postavchika = N'{richTextBox1.Text}', Gorod_postavchika = N'{richTextBox2.Text}' where Kod_postavchika='{_supplierId}'");
            }
        }
    }
}