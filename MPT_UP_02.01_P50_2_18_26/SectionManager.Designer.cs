using System.ComponentModel;

namespace MPT_UP_02._01_P50_2_18_26
{
    partial class SectionManager
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
            this.label6 = new System.Windows.Forms.Label();
            this.richTextBoxAmount = new System.Windows.Forms.RichTextBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxSection = new System.Windows.Forms.ComboBox();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.comboBoxStore = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.label1.Text = "Торговая организация \"Олимп\" - Менеджер секций";
            // 
            // label6
            // 
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label6.Location = new System.Drawing.Point(63, 140);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(243, 24);
            this.label6.TabIndex = 93;
            this.label6.Text = "Количество товара";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // richTextBoxAmount
            // 
            this.richTextBoxAmount.Location = new System.Drawing.Point(312, 140);
            this.richTextBoxAmount.Name = "richTextBoxAmount";
            this.richTextBoxAmount.Size = new System.Drawing.Size(385, 24);
            this.richTextBoxAmount.TabIndex = 92;
            this.richTextBoxAmount.Text = "";
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(339, 277);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(131, 23);
            this.buttonAdd.TabIndex = 85;
            this.buttonAdd.Text = "Применить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
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
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label5.Location = new System.Drawing.Point(63, 170);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(243, 24);
            this.label5.TabIndex = 95;
            this.label5.Text = "Товар";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // label7
            // 
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label7.Location = new System.Drawing.Point(63, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(243, 24);
            this.label7.TabIndex = 97;
            this.label7.Text = "Секция";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // comboBoxSection
            // 
            this.comboBoxSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxSection.FormattingEnabled = true;
            this.comboBoxSection.Location = new System.Drawing.Point(312, 204);
            this.comboBoxSection.Name = "comboBoxSection";
            this.comboBoxSection.Size = new System.Drawing.Size(385, 21);
            this.comboBoxSection.TabIndex = 99;
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Location = new System.Drawing.Point(312, 174);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(385, 21);
            this.comboBoxProduct.TabIndex = 98;
            // 
            // comboBoxStore
            // 
            this.comboBoxStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStore.FormattingEnabled = true;
            this.comboBoxStore.Location = new System.Drawing.Point(312, 113);
            this.comboBoxStore.Name = "comboBoxStore";
            this.comboBoxStore.Size = new System.Drawing.Size(385, 21);
            this.comboBoxStore.TabIndex = 101;
            this.comboBoxStore.SelectedIndexChanged += new System.EventHandler(this.comboBoxStore_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label2.Location = new System.Drawing.Point(63, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(243, 20);
            this.label2.TabIndex = 100;
            this.label2.Text = "Торговая точка";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // SectionManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (132)))), ((int) (((byte) (193)))), ((int) (((byte) (242)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.comboBoxStore);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxSection);
            this.Controls.Add(this.comboBoxProduct);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.richTextBoxAmount);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonExit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SectionManager";
            this.ShowIcon = false;
            this.Text = "Менеджер секций";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ComboBox comboBoxStore;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.ComboBox comboBoxSection;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label7;

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.RichTextBox richTextBoxAmount;

        #endregion
    }
}