using System.ComponentModel;

namespace MPT_UP_02._01_P50_2_18_26
{
    partial class Bookkeeper
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
            this.buttonPay1 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.comboBoxEmployees = new System.Windows.Forms.ComboBox();
            this.buttonPay2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxStore = new System.Windows.Forms.ComboBox();
            this.labelBudget = new System.Windows.Forms.Label();
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
            this.groupBox1.TabIndex = 84;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.Location = new System.Drawing.Point(47, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(516, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Торговая организация \"Олимп\" - Бухгалтер";
            // 
            // buttonPay1
            // 
            this.buttonPay1.Location = new System.Drawing.Point(48, 142);
            this.buttonPay1.Name = "buttonPay1";
            this.buttonPay1.Size = new System.Drawing.Size(148, 23);
            this.buttonPay1.TabIndex = 85;
            this.buttonPay1.Text = "Выплатить зарплату";
            this.buttonPay1.UseVisualStyleBackColor = true;
            this.buttonPay1.Click += new System.EventHandler(this.buttonPay1_Click);
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label4.Location = new System.Drawing.Point(24, 93);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 24);
            this.label4.TabIndex = 82;
            this.label4.Text = "Сотрудник";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(724, 427);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 83;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // comboBoxEmployees
            // 
            this.comboBoxEmployees.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxEmployees.FormattingEnabled = true;
            this.comboBoxEmployees.Location = new System.Drawing.Point(140, 97);
            this.comboBoxEmployees.Name = "comboBoxEmployees";
            this.comboBoxEmployees.Size = new System.Drawing.Size(328, 21);
            this.comboBoxEmployees.TabIndex = 86;
            // 
            // buttonPay2
            // 
            this.buttonPay2.Location = new System.Drawing.Point(48, 289);
            this.buttonPay2.Name = "buttonPay2";
            this.buttonPay2.Size = new System.Drawing.Size(167, 23);
            this.buttonPay2.TabIndex = 88;
            this.buttonPay2.Text = "Выплатить организациям";
            this.buttonPay2.UseVisualStyleBackColor = true;
            this.buttonPay2.Click += new System.EventHandler(this.buttonPay2_Click);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label2.Location = new System.Drawing.Point(24, 240);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 24);
            this.label2.TabIndex = 87;
            this.label2.Text = "Торговая точка";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxStore
            // 
            this.comboBoxStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStore.FormattingEnabled = true;
            this.comboBoxStore.Location = new System.Drawing.Point(174, 244);
            this.comboBoxStore.Name = "comboBoxStore";
            this.comboBoxStore.Size = new System.Drawing.Size(328, 21);
            this.comboBoxStore.TabIndex = 89;
            // 
            // labelBudget
            // 
            this.labelBudget.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.labelBudget.Location = new System.Drawing.Point(636, 54);
            this.labelBudget.Name = "labelBudget";
            this.labelBudget.Size = new System.Drawing.Size(152, 111);
            this.labelBudget.TabIndex = 90;
            // 
            // Bookkeeper
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (132)))), ((int) (((byte) (193)))), ((int) (((byte) (242)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.labelBudget);
            this.Controls.Add(this.comboBoxStore);
            this.Controls.Add(this.buttonPay2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxEmployees);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.buttonPay1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonExit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Bookkeeper";
            this.ShowIcon = false;
            this.Text = "Бухгалтер";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label labelBudget;

        private System.Windows.Forms.ComboBox comboBoxStore;

        private System.Windows.Forms.Button buttonPay2;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.ComboBox comboBoxEmployees;

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonPay1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;

        #endregion
    }
}