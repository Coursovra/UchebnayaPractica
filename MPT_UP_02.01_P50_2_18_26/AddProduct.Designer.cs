using System.ComponentModel;

namespace MPT_UP_02._01_P50_2_18_26
{
    partial class AddProduct
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
            this.label4 = new System.Windows.Forms.Label();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBoxStore = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxStorage = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.richTextBoxAmount = new System.Windows.Forms.RichTextBox();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label4.Location = new System.Drawing.Point(74, 185);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 24);
            this.label4.TabIndex = 32;
            this.label4.Text = "Товар";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.buttonAdd.Location = new System.Drawing.Point(316, 289);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(181, 31);
            this.buttonAdd.TabIndex = 30;
            this.buttonAdd.Text = "Пополнить";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(724, 426);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 33;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (146)))), ((int) (((byte) (195)))), ((int) (((byte) (225)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, 0);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 50);
            this.groupBox1.TabIndex = 34;
            this.groupBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label1.Location = new System.Drawing.Point(47, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(516, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Торговая организация \"Олимп\" - Администратор торговой точки";
            // 
            // comboBoxStore
            // 
            this.comboBoxStore.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStore.FormattingEnabled = true;
            this.comboBoxStore.Location = new System.Drawing.Point(190, 143);
            this.comboBoxStore.Name = "comboBoxStore";
            this.comboBoxStore.Size = new System.Drawing.Size(463, 21);
            this.comboBoxStore.TabIndex = 35;
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label2.Location = new System.Drawing.Point(26, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(158, 24);
            this.label2.TabIndex = 36;
            this.label2.Text = "Торговая точка";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label3.Location = new System.Drawing.Point(26, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 24);
            this.label3.TabIndex = 38;
            this.label3.Text = "Склад";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxStorage
            // 
            this.comboBoxStorage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxStorage.FormattingEnabled = true;
            this.comboBoxStorage.Location = new System.Drawing.Point(190, 97);
            this.comboBoxStorage.Name = "comboBoxStorage";
            this.comboBoxStorage.Size = new System.Drawing.Size(463, 21);
            this.comboBoxStorage.TabIndex = 37;
            this.comboBoxStorage.SelectedIndexChanged += new System.EventHandler(this.comboBoxStorage_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label5.Location = new System.Drawing.Point(74, 226);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 24);
            this.label5.TabIndex = 40;
            this.label5.Text = "Количество";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // richTextBoxAmount
            // 
            this.richTextBoxAmount.Location = new System.Drawing.Point(190, 226);
            this.richTextBoxAmount.Name = "richTextBoxAmount";
            this.richTextBoxAmount.Size = new System.Drawing.Size(463, 24);
            this.richTextBoxAmount.TabIndex = 39;
            this.richTextBoxAmount.Text = "";
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Location = new System.Drawing.Point(190, 188);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(463, 21);
            this.comboBoxProduct.TabIndex = 41;
            this.comboBoxProduct.SelectedIndexChanged += new System.EventHandler(this.comboBoxProduct_SelectedIndexChanged);
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (132)))), ((int) (((byte) (193)))), ((int) (((byte) (242)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.comboBoxProduct);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.richTextBoxAmount);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxStorage);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxStore);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.buttonBack);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AddProduct";
            this.ShowIcon = false;
            this.Text = "Администратор торговой точки главная страница";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RichTextBox richTextBoxAmount;

        private System.Windows.Forms.ComboBox comboBoxStorage;
        private System.Windows.Forms.Label label3;

        private System.Windows.Forms.ComboBox comboBoxStore;
        private System.Windows.Forms.Label label2;

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;

        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Label label4;

        #endregion
    }
}