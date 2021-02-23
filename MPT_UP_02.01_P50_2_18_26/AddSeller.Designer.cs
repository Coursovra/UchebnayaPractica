using System.ComponentModel;

namespace MPT_UP_02._01_P50_2_18_26
{
    partial class AddSeller
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBoxSurname = new System.Windows.Forms.RichTextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxName = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.richTextBoxSecondName = new System.Windows.Forms.RichTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBoxPhoneNumber = new System.Windows.Forms.RichTextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.richTextBoxLogin = new System.Windows.Forms.RichTextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.richTextBoxPassword = new System.Windows.Forms.RichTextBox();
            this.comboBoxStore = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.labelStore = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (146)))), ((int) (((byte) (195)))), ((int) (((byte) (225)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 50);
            this.groupBox1.TabIndex = 64;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.Location = new System.Drawing.Point(47, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(516, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Торговая организация \"Олимп\" - Продавец";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(250, 350);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(131, 23);
            this.buttonAdd.TabIndex = 71;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label4.Location = new System.Drawing.Point(24, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 24);
            this.label4.TabIndex = 62;
            this.label4.Text = "Фамилия";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // richTextBoxSurname
            // 
            this.richTextBoxSurname.Location = new System.Drawing.Point(140, 93);
            this.richTextBoxSurname.MaxLength = 200;
            this.richTextBoxSurname.Name = "richTextBoxSurname";
            this.richTextBoxSurname.Size = new System.Drawing.Size(299, 24);
            this.richTextBoxSurname.TabIndex = 61;
            this.richTextBoxSurname.Text = "";
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(724, 427);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 63;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label2.Location = new System.Drawing.Point(24, 123);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 24);
            this.label2.TabIndex = 73;
            this.label2.Text = "Имя";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // richTextBoxName
            // 
            this.richTextBoxName.Location = new System.Drawing.Point(140, 123);
            this.richTextBoxName.MaxLength = 200;
            this.richTextBoxName.Name = "richTextBoxName";
            this.richTextBoxName.Size = new System.Drawing.Size(299, 24);
            this.richTextBoxName.TabIndex = 72;
            this.richTextBoxName.Text = "";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label3.Location = new System.Drawing.Point(24, 153);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 24);
            this.label3.TabIndex = 75;
            this.label3.Text = "Отчество";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // richTextBoxSecondName
            // 
            this.richTextBoxSecondName.Location = new System.Drawing.Point(140, 153);
            this.richTextBoxSecondName.MaxLength = 200;
            this.richTextBoxSecondName.Name = "richTextBoxSecondName";
            this.richTextBoxSecondName.Size = new System.Drawing.Size(299, 24);
            this.richTextBoxSecondName.TabIndex = 74;
            this.richTextBoxSecondName.Text = "";
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label5.Location = new System.Drawing.Point(24, 183);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(169, 24);
            this.label5.TabIndex = 77;
            this.label5.Text = "Дата рождения";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.Location = new System.Drawing.Point(199, 187);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(240, 20);
            this.dateTimePicker1.TabIndex = 78;
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label6.Location = new System.Drawing.Point(24, 213);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(110, 24);
            this.label6.TabIndex = 80;
            this.label6.Text = "Телефон";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // richTextBoxPhoneNumber
            // 
            this.richTextBoxPhoneNumber.Location = new System.Drawing.Point(140, 213);
            this.richTextBoxPhoneNumber.Name = "richTextBoxPhoneNumber";
            this.richTextBoxPhoneNumber.Size = new System.Drawing.Size(299, 24);
            this.richTextBoxPhoneNumber.TabIndex = 79;
            this.richTextBoxPhoneNumber.Text = "";
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label7.Location = new System.Drawing.Point(24, 243);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(110, 24);
            this.label7.TabIndex = 82;
            this.label7.Text = "Логин";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // richTextBoxLogin
            // 
            this.richTextBoxLogin.Location = new System.Drawing.Point(140, 243);
            this.richTextBoxLogin.MaxLength = 8;
            this.richTextBoxLogin.Name = "richTextBoxLogin";
            this.richTextBoxLogin.Size = new System.Drawing.Size(299, 24);
            this.richTextBoxLogin.TabIndex = 81;
            this.richTextBoxLogin.Text = "";
            // 
            // label8
            // 
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label8.Location = new System.Drawing.Point(24, 273);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 24);
            this.label8.TabIndex = 84;
            this.label8.Text = "Пароль";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // richTextBoxPassword
            // 
            this.richTextBoxPassword.Location = new System.Drawing.Point(140, 273);
            this.richTextBoxPassword.Name = "richTextBoxPassword";
            this.richTextBoxPassword.Size = new System.Drawing.Size(299, 24);
            this.richTextBoxPassword.TabIndex = 83;
            this.richTextBoxPassword.Text = "";
            // 
            // comboBoxStore
            // 
            this.comboBoxStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStore.FormattingEnabled = true;
            this.comboBoxStore.Location = new System.Drawing.Point(103, 312);
            this.comboBoxStore.Name = "comboBoxStore";
            this.comboBoxStore.Size = new System.Drawing.Size(336, 21);
            this.comboBoxStore.TabIndex = 85;
            // 
            // label9
            // 
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label9.Location = new System.Drawing.Point(24, 312);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 21);
            this.label9.TabIndex = 86;
            this.label9.Text = "Секция";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelStore
            // 
            this.labelStore.Location = new System.Drawing.Point(627, 54);
            this.labelStore.Name = "labelStore";
            this.labelStore.Size = new System.Drawing.Size(172, 63);
            this.labelStore.TabIndex = 87;
            this.labelStore.Text = "label10";
            // 
            // AddSeller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (132)))), ((int) (((byte) (193)))), ((int) (((byte) (242)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.labelStore);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.comboBoxStore);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.richTextBoxPassword);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.richTextBoxLogin);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBoxPhoneNumber);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBoxSecondName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.richTextBoxName);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBoxSurname);
            this.Controls.Add(this.buttonBack);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddSeller";
            this.ShowIcon = false;
            this.Text = "Продавец - добавление продавца";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ComboBox comboBoxStore;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label labelStore;

        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.RichTextBox richTextBoxLogin;
        private System.Windows.Forms.RichTextBox richTextBoxPassword;

        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBoxPhoneNumber;

        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label5;

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RichTextBox richTextBoxSecondName;

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox richTextBoxName;

        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBoxSurname;

        #endregion
    }
}