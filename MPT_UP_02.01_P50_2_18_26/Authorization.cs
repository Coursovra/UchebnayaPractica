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

        private void buttonEnter_Click(object sender, EventArgs e)
        {
            var result = SqlManager.ExecuteCommand(
                $"select Kod_dolznosty from Sotrudnik where Login = '{richTextBoxLogin.Text}' and Parol = '{textBoxPassword.Text}'");

            if(result.Count == 0) { return; }
            
            var roleId = result[0];
            
            if(roleId == null) { return; }
            
            string role = SqlManager.ExecuteCommand(
                $"select Nazvanie_dolznosty from Dolznosty where Kod_dolznosty = '{roleId}'")[0];

            switch (role)
            {
                case "Администратор БД":
                {
                    AdminBD newForm= new AdminBD();
                    newForm.Show();
                    Hide();
                    break;
                }
                case "Администратор торговой точки":
                {
                    AdminTT newForm= new AdminTT();
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
                    var sectionId =
                        SqlManager.ExecuteCommand(
                                $"select Id_Ceksii_torgovoy_tochki from Ceksiya_torgovoy_tochki_Sotrudnik where Id_Sotrudnik = {myId}")
                            [0];
                    Seller newForm= new Seller(myId, sectionId);
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
                    Bookkeeper newForm= new Bookkeeper();
                    newForm.Show();
                    Hide();
                    break;
                }
            }
        }
    }
}