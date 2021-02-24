using System.ComponentModel;

namespace MPT_UP_02._01_P50_2_18_26
{
    partial class AdminTT
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonExit = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (146)))), ((int) (((byte) (195)))), ((int) (((byte) (225)))));
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(0, 1);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(798, 50);
            this.groupBox1.TabIndex = 10;
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
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(30, 121);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(728, 198);
            this.dataGridView1.TabIndex = 17;
            // 
            // comboBox1
            // 
            this.comboBox1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(147, 74);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(611, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte) (204)));
            this.label2.Location = new System.Drawing.Point(30, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 21);
            this.label2.TabIndex = 15;
            this.label2.Text = "Посетитель";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonExit
            // 
            this.buttonExit.BackColor = System.Drawing.Color.White;
            this.buttonExit.Location = new System.Drawing.Point(683, 403);
            this.buttonExit.Name = "buttonExit";
            this.buttonExit.Size = new System.Drawing.Size(75, 23);
            this.buttonExit.TabIndex = 14;
            this.buttonExit.Text = "Выйти";
            this.buttonExit.UseVisualStyleBackColor = false;
            this.buttonExit.Click += new System.EventHandler(this.buttonExit_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(30, 338);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(218, 23);
            this.buttonAdd.TabIndex = 18;
            this.buttonAdd.Text = "Пополнение товарами торговой точки";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // AdminTT
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int) (((byte) (132)))), ((int) (((byte) (193)))), ((int) (((byte) (242)))));
            this.ClientSize = new System.Drawing.Size(792, 450);
            this.ControlBox = false;
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.buttonExit);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AdminTT";
            this.ShowIcon = false;
            this.Text = "Администратор торговой точки главная страница";
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize) (this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.Button buttonAdd;

        private System.Windows.Forms.Button buttonExit;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;

        #endregion
    }
}