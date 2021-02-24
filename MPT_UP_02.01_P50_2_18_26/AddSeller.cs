using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MPT_UP_02._01_P50_2_18_26
{
    public partial class AddSeller : Form
    {
        private string _myStoreId;
        private List<string> _storeId = new();
        private List<string> _storeAddress = new();
        private List<string> _storeName = new();
        public AddSeller(string myStoreId)
        {
            InitializeComponent();
            _myStoreId = myStoreId;
            var storeInfo = SqlManager.ExecuteCommand(
                "select Nazvanie_ceksii, [Address], [Kod_ Ceksii_torgovoy_tochki] " +
                "from Ceksii_torgovoy_tochki inner join Torgovaya_tochka " +
                "on Torgovaya_tochka.Kod_torgovoy_tochki = Id_TorgTochka");

            for (int i = 0; i < storeInfo.Count; i+=3)
            {
                comboBoxStore.Items.Add(storeInfo[i] + " - " + storeInfo[i+1]);
                _storeId.Add(storeInfo[i+2]);
                _storeAddress.Add(storeInfo[i+1]);
                _storeName.Add(storeInfo[i]);

                if (_myStoreId == storeInfo[i + 2])
                {
                    labelStore.Text = storeInfo[i] + " - " + storeInfo[i+1];
                }
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(richTextBoxName.Text, "^[A-Za-zА-Яа-я]+$")
                && Regex.IsMatch(richTextBoxSurname.Text, "^[A-Za-zА-Яа-я]+$")
                && Regex.IsMatch(richTextBoxSecondName.Text, "^[A-Za-zА-Яа-я]+$")
                && Regex.IsMatch(richTextBoxPhoneNumber.Text, "^[0-9]+$")
                && dateTimePicker1.Text != null
                && Regex.IsMatch(richTextBoxLogin.Text, "^[A-Za-zА-Яа-я_-]+$")
                && richTextBoxLogin.Text.Length > 1
                && Regex.IsMatch(richTextBoxPassword.Text, "^[A-Za-zА-Яа-я!#?$0-9]+$")
                && richTextBoxPassword.Text.Length > 1
                && comboBoxStore.SelectedIndex >= 0)
            {
                if (SqlManager
                    .ExecuteCommand(
                        $"select * from Sotrudnik where Login = '{richTextBoxLogin.Text}'").Count != 0)
                {
                    return;
                }

                if (richTextBoxSecondName.Text == null)
                {
                    SqlManager.InsertData("Sotrudnik",
                        new[]
                        {
                            "Familiya", "Imy", "Data_rojdeniya", "Nomer_telefona", "Kod_dolznosty",
                            "Login",
                            "Parol"
                        },
                        new[]
                        {
                            richTextBoxSurname.Text, richTextBoxName.Text,
                            Convert.ToDateTime(dateTimePicker1.Text).ToString("yyyy-MM-dd"),
                            richTextBoxPhoneNumber.Text, "4", richTextBoxLogin.Text, richTextBoxPassword.Text
                        });
                }
                else
                {
                    SqlManager.InsertData("Sotrudnik",
                        new[]
                        {
                            "Familiya", "Imy", "Otchestvo", "Data_rojdeniya", "Nomer_telefona", "Kod_dolznosty",
                            "Login",
                            "Parol"
                        },
                        new[]
                        {
                            richTextBoxSurname.Text, richTextBoxName.Text, richTextBoxSecondName.Text,
                            Convert.ToDateTime(dateTimePicker1.Text).ToString("yyyy-MM-dd"),
                            richTextBoxPhoneNumber.Text, "4", richTextBoxLogin.Text, richTextBoxPassword.Text
                        });
                }

                var myId = SqlManager.ExecuteCommand($"select Kod_sotrudnika from Sotrudnik where Login = '{richTextBoxLogin.Text}'")[0];

                SqlManager.InsertData("Ceksiya_torgovoy_tochki_Sotrudnik",
                    new[] {"Id_Ceksii_torgovoy_tochki", "Id_Sotrudnik"},
                    new[] {_storeId[comboBoxStore.SelectedIndex], myId});
            }
        }
    }
}