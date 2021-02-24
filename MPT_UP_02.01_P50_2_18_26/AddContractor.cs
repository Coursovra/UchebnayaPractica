﻿using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace MPT_UP_02._01_P50_2_18_26
{
    public partial class AddContractor : Form
    {
        
        public AddContractor()
        {
            InitializeComponent();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(richTextBox1.Text, @"^[a-zA-ZА-Яа-я.0-9]+$") && Regex.IsMatch(richTextBox2.Text, @"^[a-zA-ZА-Яа-я]+$"))
            {
                SqlManager.InsertData("Postavchik", new []{"Imy_postavchika", "Gorod_postavchika"}, new []{richTextBox1.Text, richTextBox2.Text});
            }
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}