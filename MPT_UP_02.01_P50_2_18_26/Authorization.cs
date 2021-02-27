using System;
using System.Windows.Forms;

namespace MPT_UP_02._01_P50_2_18_26
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Авторизоваться" для авторизации и перехода на следующую страницу в соответствии с ролью сотрудника
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonEnter_Click(object sender, EventArgs e)
        {
            var result = SqlManager.ExecuteCommand(
                $"select Kod_dolznosty from Sotrudnik where Login = '{richTextBoxLogin.Text}' and Parol = '{textBoxPassword.Text}'");

            if (result.Count == 0)
            {
                MessageBox.Show("Пользователь не найден");
                return;
            }

            var roleId = result[0];

            if (roleId == null)
            {
                MessageBox.Show("У данного пользователя нет должности");
                return;
            }

            string role = SqlManager.ExecuteCommand(
                $"select Nazvanie_dolznosty from Dolznosty where Kod_dolznosty = '{roleId}'")[0];

            switch (role)
            {
                case "Администратор БД":
                {
                    AdminBD newForm = new AdminBD();
                    newForm.Show();
                    Hide();
                    break;
                }
                case "Администратор торговой точки":
                {
                    AdminTT newForm = new AdminTT();
                    newForm.Show();
                    Hide();
                    break;
                }
                case "Кладовщик":
                {
                    Storekeeper newForm = new Storekeeper();
                    newForm.Show();
                    Hide();
                    break;
                }
                case "Продавец":
                {
                    var myId = SqlManager.ExecuteCommand(
                        $" select Kod_sotrudnika from Sotrudnik where [Login] = '{richTextBoxLogin.Text}'")[0];
                    var sectionIdResult =
                        SqlManager.ExecuteCommand(
                            $"select Id_Ceksii_torgovoy_tochki from Ceksiya_torgovoy_tochki_Sotrudnik where Id_Sotrudnik = {myId}");
                            
                    if (sectionIdResult.Count == 0)
                    {
                        MessageBox.Show("Данный пользователь не работает ни на одной точке");
                        return;
                    }
                    Seller newForm = new Seller(myId, sectionIdResult[0]);
                    newForm.Show();
                    Hide();
                    break;
                }
                case "Менеджер секций":
                {
                    SectionManager newForm = new SectionManager();
                    newForm.Show();
                    Hide();
                    break;
                }
                case "Бухгалтер":
                {
                    Bookkeeper newForm = new Bookkeeper();
                    newForm.Show();
                    Hide();
                    break;
                }
            }
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Выход" для выхода из программы
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}