﻿using System;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MPT_UP_02._01_P50_2_18_26
{
    public partial class SectionManager : Form
    {
        private List<string> _storeId = new();
        private List<string> _sectionId = new();
        private List<StoreProduct> _storeproducts;

        public SectionManager()
        {
            InitializeComponent();
            _storeproducts = new();

            var storeInfo = SqlManager.ExecuteCommand("select Kod_torgovoy_tochki, Address from Torgovaya_tochka");
            for (int i = 0; i < storeInfo.Count; i += 2)
            {
                comboBoxStore.Items.Add(storeInfo[i + 1]);
                _storeId.Add(storeInfo[i]);
            }
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (comboBoxStore.SelectedIndex >= 0 && comboBoxProduct.SelectedIndex >= 0 &&
                comboBoxSection.SelectedIndex >= 0 && Regex.IsMatch(richTextBoxAmount.Text, "^[0-9]+$"))
            {
                var amount = Convert.ToInt32(richTextBoxAmount.Text);
                if (amount == 0)
                {
                    return;
                }

                if (_storeproducts[comboBoxProduct.SelectedIndex].Amount - amount < 0)
                {
                    return;
                }

                _storeproducts[comboBoxProduct.SelectedIndex].Amount -= amount;

                var primaryKey =
                    SqlManager.ExecuteCommand(
                            "select Id_TorgTochka_Tovar from TorgTochka_Tovar " +
                            $"where Id_TorgTochka = {_storeId[comboBoxStore.SelectedIndex]} and Id_Tovar = {_storeproducts[comboBoxProduct.SelectedIndex].Id}")
                        [0];
                SqlManager.ChangeData("TorgTochka_Tovar", "Tovar_Kolichestvo", //remove from store
                    _storeproducts[comboBoxProduct.SelectedIndex].Amount.ToString(), "Id_TorgTochka_Tovar", primaryKey);
                
                if (_storeproducts[comboBoxProduct.SelectedIndex].Amount == 0)
                {
                    SqlManager.DeleteData("TorgTochka_Tovar", "Id_TorgTochka_Tovar", primaryKey);
                }

                var primaryKeyQuery =
                    SqlManager.ExecuteCommand(
                        $"select Id_Ceksiya_Tovar from Ceksiya_Tovar where Id_Seksiya = {_storeId[comboBoxStore.SelectedIndex]} " +
                        $"and Id_Tovar = {_storeproducts[comboBoxProduct.SelectedIndex].Id}");


                if (primaryKeyQuery.Count == 0) //add to section
                {
                    SqlManager.InsertData("Ceksiya_Tovar", new[] {"Id_Seksiya", "Id_Tovar", "Tovar_Kolichestvo"},
                        new[]
                        {
                            _sectionId[comboBoxSection.SelectedIndex], _storeproducts[comboBoxProduct.SelectedIndex].Id,
                            _storeproducts[comboBoxProduct.SelectedIndex].Amount.ToString()
                        });
                }
                else //insert into section
                {
                    primaryKey = primaryKeyQuery[0];
                    SqlManager.ChangeData("Ceksiya_Tovar", "Tovar_Kolichestvo",
                        richTextBoxAmount.Text, "Id_Ceksiya_Tovar",
                        primaryKey);
                }

                if (_storeproducts[comboBoxProduct.SelectedIndex].Amount == 0)
                {
                    _storeproducts.RemoveAt(comboBoxProduct.SelectedIndex);
                }
                
                UpdateProductComboBox();
            }
        }

        private void comboBoxStore_SelectedIndexChanged(object sender, EventArgs e)
        {
            UpdateProductComboBox();

            comboBoxSection.Items.Clear();
            _sectionId.Clear();
            var sectionInfo = SqlManager.ExecuteCommand(
                "select [Kod_ Ceksii_torgovoy_tochki], Nazvanie_ceksii " +
                $"from Ceksii_torgovoy_tochki where Id_TorgTochka = {_storeId[comboBoxStore.SelectedIndex]}");
            for (int i = 0; i < sectionInfo.Count; i += 2)
            {
                comboBoxSection.Items.Add(sectionInfo[i + 1]);
                _sectionId.Add(sectionInfo[i]);
            }
        }

        private void UpdateProductComboBox()
        {
            _storeproducts.Clear();
            comboBoxProduct.Items.Clear();
            var productInfo = SqlManager.ExecuteCommand(
                "select Nazvanie_producta, Tovar_Kolichestvo, Kod_tovara from TorgTochka_Tovar " +
                $"inner join Tovar on Tovar.Kod_tovara = Id_Tovar where Id_TorgTochka = {_storeId[comboBoxStore.SelectedIndex]}");
            for (int i = 0; i < productInfo.Count; i += 3)
            {
                comboBoxProduct.Items.Add(productInfo[i] + " (" + productInfo[i + 1] + ")");
                _storeproducts.Add(new StoreProduct() {Id = productInfo[i + 2], Amount = Convert.ToInt32(productInfo[i + 1])});
            }
        }
    }

    public class StoreProduct
    {
        public string Id;
        public int Amount;
    }
}