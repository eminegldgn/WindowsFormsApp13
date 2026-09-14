namespace WindowsFormsApp13
{
    partial class otoparkyeri_sec
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Grpbox1 = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl1 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.GrpBox2 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.Grpbox1.SuspendLayout();
            this.GrpBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(841, 189);
            this.dataGridView1.TabIndex = 0;
            // 
            // Grpbox1
            // 
            this.Grpbox1.Controls.Add(this.comboBox1);
            this.Grpbox1.Controls.Add(this.lbl1);
            this.Grpbox1.Controls.Add(this.lbl2);
            this.Grpbox1.Controls.Add(this.textBox1);
            this.Grpbox1.Location = new System.Drawing.Point(12, 259);
            this.Grpbox1.Name = "Grpbox1";
            this.Grpbox1.Size = new System.Drawing.Size(251, 100);
            this.Grpbox1.TabIndex = 1;
            this.Grpbox1.TabStop = false;
            this.Grpbox1.Text = "Plaka ve Park Yeri";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(98, 21);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 24);
            this.comboBox1.TabIndex = 0;
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(6, 24);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(66, 16);
            this.lbl1.TabIndex = 2;
            this.lbl1.Text = "Plaka Ara";
            this.lbl1.Click += new System.EventHandler(this.lbl1_Click);
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(6, 67);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(62, 16);
            this.lbl2.TabIndex = 3;
            this.lbl2.Text = "Park Yeri";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(98, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(121, 22);
            this.textBox1.TabIndex = 3;
            // 
            // GrpBox2
            // 
            this.GrpBox2.Controls.Add(this.textBox3);
            this.GrpBox2.Controls.Add(this.textBox4);
            this.GrpBox2.Controls.Add(this.textBox5);
            this.GrpBox2.Controls.Add(this.textBox6);
            this.GrpBox2.Controls.Add(this.textBox7);
            this.GrpBox2.Controls.Add(this.lbl4);
            this.GrpBox2.Controls.Add(this.lbl3);
            this.GrpBox2.Controls.Add(this.comboBox2);
            this.GrpBox2.Location = new System.Drawing.Point(332, 259);
            this.GrpBox2.Name = "GrpBox2";
            this.GrpBox2.Size = new System.Drawing.Size(494, 100);
            this.GrpBox2.TabIndex = 2;
            this.GrpBox2.TabStop = false;
            this.GrpBox2.Text = "Araç";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(372, 61);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 22);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(372, 16);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 22);
            this.textBox4.TabIndex = 6;
            this.textBox4.TextChanged += new System.EventHandler(this.textBox4_TextChanged);
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(236, 61);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 22);
            this.textBox5.TabIndex = 7;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(236, 16);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 22);
            this.textBox6.TabIndex = 8;
            // 
            // textBox7
            // 
            this.textBox7.Location = new System.Drawing.Point(72, 61);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(123, 22);
            this.textBox7.TabIndex = 9;
            this.textBox7.TextChanged += new System.EventHandler(this.textBox7_TextChanged);
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(6, 67);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(60, 16);
            this.lbl4.TabIndex = 5;
            this.lbl4.Text = "Park yeri";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(6, 24);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(62, 16);
            this.lbl3.TabIndex = 4;
            this.lbl3.Text = "Park Yeri";
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(74, 21);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(121, 24);
            this.comboBox2.TabIndex = 1;
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Cyan;
            this.btn1.Location = new System.Drawing.Point(110, 456);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(136, 49);
            this.btn1.TabIndex = 3;
            this.btn1.Text = "Geri";
            this.btn1.UseVisualStyleBackColor = false;
            // 
            // btn2
            // 
            this.btn2.BackColor = System.Drawing.Color.Cyan;
            this.btn2.Location = new System.Drawing.Point(532, 456);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(136, 49);
            this.btn2.TabIndex = 4;
            this.btn2.Text = "Çıkış";
            this.btn2.UseVisualStyleBackColor = false;
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.Color.Tomato;
            this.btn3.Location = new System.Drawing.Point(332, 376);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(166, 55);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "Otoparktan Ayrıl !";
            this.btn3.UseVisualStyleBackColor = false;
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(861, 517);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.GrpBox2);
            this.Controls.Add(this.Grpbox1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Form3";
            this.Text = "Otoparkyeri_Sec";
            this.Load += new System.EventHandler(this.Form3_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.Grpbox1.ResumeLayout(false);
            this.Grpbox1.PerformLayout();
            this.GrpBox2.ResumeLayout(false);
            this.GrpBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox Grpbox1;
        private System.Windows.Forms.GroupBox GrpBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
    }
}

