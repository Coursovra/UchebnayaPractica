using System.ComponentModel;

namespace MPT_UP_02._01_P50_2_18_26
{
    partial class Seller
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
            this.label4 = new System.Windows.Forms.Label();
            this.richTextBoxAmount = new System.Windows.Forms.RichTextBox();
            this.buttonExit = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.comboBoxCustomer = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBoxProduct = new System.Windows.Forms.ComboBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.buttonShowCheck = new System.Windows.Forms.Button();
            this.buttonAddSeller = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buttonAddCustomer = new System.Windows.Forms.Button();
            this.labelToPay = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (146)))), ((int) (((byte) (195)))), ((int) (((byte) (225)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(1, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 50);
            this.groupBox1.TabIndex = 52;
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
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label4.Location = new System.Drawing.Point(51, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 24);
            this.label4.TabIndex = 50;
            this.label4.Text = "Количество";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // richTextBoxAmount
            // 
            this.richTextBoxAmount.Location = new System.Drawing.Point(167, 157);
            this.richTextBoxAmount.Name = "richTextBoxAmount";
            this.richTextBoxAmount.Size = new System.Drawing.Size(463, 24);
            this.richTextBoxAmount.TabIndex = 49;
            this.richTextBoxAmount.Text = "";
            // 
            // buttonExit
            // 
            this.buttonExit.Location = new System.Drawing.Point(724, 427);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 51;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = true;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // label3
            // 
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label3.Location = new System.Drawing.Point(3, 65);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(158, 24);
            this.label3.TabIndex = 56;
            this.label3.Text = "Посетитель";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxCustomer
            // 
            this.comboBoxCustomer.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxCustomer.FormattingEnabled = true;
            this.comboBoxCustomer.Location = new System.Drawing.Point(167, 69);
            this.comboBoxCustomer.Name = "comboBoxCustomer";
            this.comboBoxCustomer.Size = new System.Drawing.Size(463, 21);
            this.comboBoxCustomer.TabIndex = 55;
            this.comboBoxCustomer.SelectedIndexChanged += new System.EventHandler(this.comboBoxCustomer_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label2.Location = new System.Drawing.Point(48, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 24);
            this.label2.TabIndex = 54;
            this.label2.Text = "Товар";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // comboBoxProduct
            // 
            this.comboBoxProduct.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBoxProduct.FormattingEnabled = true;
            this.comboBoxProduct.Location = new System.Drawing.Point(167, 115);
            this.comboBoxProduct.Name = "comboBoxProduct";
            this.comboBoxProduct.Size = new System.Drawing.Size(463, 21);
            this.comboBoxProduct.TabIndex = 53;
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(653, 69);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(100, 20);
            this.buttonAdd.TabIndex = 57;
            this.buttonAdd.Text = "Добавить в чек";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // buttonShowCheck
            // 
            this.buttonShowCheck.Location = new System.Drawing.Point(653, 147);
            this.buttonShowCheck.Name = "buttonShowCheck";
            this.buttonShowCheck.Size = new System.Drawing.Size(100, 34);
            this.buttonShowCheck.TabIndex = 58;
            this.buttonShowCheck.Text = "Завершить создание чека";
            this.buttonShowCheck.UseVisualStyleBackColor = true;
            this.buttonShowCheck.Click += new System.EventHandler(this.buttonShowCheck_Click);
            // 
            // buttonAddSeller
            // 
            this.buttonAddSeller.Location = new System.Drawing.Point(653, 260);
            this.buttonAddSeller.Name = "buttonAddSeller";
            this.buttonAddSeller.Size = new System.Drawing.Size(125, 20);
            this.buttonAddSeller.TabIndex = 59;
            this.buttonAddSeller.Text = "Добавить продавца";
            this.buttonAddSeller.UseVisualStyleBackColor = true;
            this.buttonAddSeller.Click += new System.EventHandler(this.buttonAddSeller_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(51, 234);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(579, 195);
            this.dataGridView1.TabIndex = 60;
            // 
            // buttonAddCustomer
            // 
            this.buttonAddCustomer.Location = new System.Drawing.Point(653, 234);
            this.buttonAddCustomer.Name = "buttonAddCustomer";
            this.buttonAddCustomer.Size = new System.Drawing.Size(135, 20);
            this.buttonAddCustomer.TabIndex = 61;
            this.buttonAddCustomer.Text = "Добавить посетителя";
            this.buttonAddCustomer.UseVisualStyleBackColor = true;
            this.buttonAddCustomer.Click += new System.EventHandler(this.buttonAddCustomer_Click);
            // 
            // labelToPay
            // 
            this.labelToPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.labelToPay.Location = new System.Drawing.Point(167, 199);
            this.labelToPay.Name = "labelToPay";
            this.labelToPay.Size = new System.Drawing.Size(463, 23);
            this.labelToPay.TabIndex = 62;
            // 
            // Seller
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (132)))), ((int) (((byte) (193)))), ((int) (((byte) (242)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.labelToPay);
            this.Controls.Add(this.buttonAddCustomer);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.buttonAddSeller);
            this.Controls.Add(this.buttonShowCheck);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.richTextBoxAmount);
            this.Controls.Add(this.buttonExit);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.comboBoxCustomer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.comboBoxProduct);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Seller";
            this.ShowIcon = false;
            this.Text = "Продавец";
            this.Load += new System.EventHandler(this.Seller_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Label labelToPay;

        private System.Windows.Forms.Button buttonAddCustomer;

        private System.Windows.Forms.DataGridView dataGridView1;

        private System.Windows.Forms.Button buttonAddSeller;

        private System.Windows.Forms.Button buttonShowCheck;

        private System.Windows.Forms.Button buttonAdd;

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ComboBox comboBoxProduct;
        private System.Windows.Forms.ComboBox comboBoxCustomer;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RichTextBox richTextBoxAmount;

        #endregion
    }
}