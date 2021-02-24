namespace MPT_UP_02._01_P50_2_18_26
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.richTextBoxLogin = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.buttonEnter = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.Location = new System.Drawing.Point(47, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(423, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Торговая организация \"Олимп\" - Авторизация";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (146)))), ((int) (((byte) (195)))), ((int) (((byte) (225)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, -4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 50);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label2.Location = new System.Drawing.Point(275, 124);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "Тораговая организация \"Олимп\"";
            // 
            // richTextBoxLogin
            // 
            this.richTextBoxLogin.Location = new System.Drawing.Point(192, 175);
            this.richTextBoxLogin.MaxLength = 8;
            this.richTextBoxLogin.Multiline = false;
            this.richTextBoxLogin.Name = "richTextBoxLogin";
            this.richTextBoxLogin.Size = new System.Drawing.Size(446, 24);
            this.richTextBoxLogin.TabIndex = 3;
            this.richTextBoxLogin.Text = "";
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label3.Location = new System.Drawing.Point(126, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 24);
            this.label3.TabIndex = 4;
            this.label3.Text = "Логин";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonEnter
            // 
            this.buttonEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.buttonEnter.Location = new System.Drawing.Point(288, 330);
            this.buttonEnter.Name = "buttonEnter";
            this.buttonEnter.Size = new System.Drawing.Size(221, 55);
            this.buttonEnter.TabIndex = 7;
            this.buttonEnter.Text = "Авторизоваться";
            this.buttonEnter.UseVisualStyleBackColor = true;
            this.buttonEnter.Click += new System.EventHandler(this.buttonEnter_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label4.Location = new System.Drawing.Point(109, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(77, 24);
            this.label4.TabIndex = 9;
            this.label4.Text = "Пароль";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Location = new System.Drawing.Point(192, 227);
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.PasswordChar = '*';
            this.textBoxPassword.Size = new System.Drawing.Size(446, 20);
            this.textBoxPassword.TabIndex = 10;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (132)))), ((int) (((byte) (192)))), ((int) (((byte) (242)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonEnter);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.richTextBoxLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.groupBox1);
            this.Location = new System.Drawing.Point(15, 15);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox textBoxPassword;

        private System.Windows.Forms.Label label4;

        private System.Windows.Forms.Button buttonEnter;

        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.RichTextBox richTextBoxLogin;

        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.GroupBox groupBox1;

        private System.Windows.Forms.Label label1;

        #endregion
    }
}