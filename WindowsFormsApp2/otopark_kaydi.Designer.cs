namespace WindowsFormsApp13
{
    partial class otopark_kaydi
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
            this.Grpbox1 = new System.Windows.Forms.GroupBox();
            this.txtbox4 = new System.Windows.Forms.TextBox();
            this.txtbox3 = new System.Windows.Forms.TextBox();
            this.txtbox2 = new System.Windows.Forms.TextBox();
            this.lbl4 = new System.Windows.Forms.Label();
            this.lbl3 = new System.Windows.Forms.Label();
            this.lbl2 = new System.Windows.Forms.Label();
            this.lbl1 = new System.Windows.Forms.Label();
            this.txtbox1 = new System.Windows.Forms.TextBox();
            this.Grpbox2 = new System.Windows.Forms.GroupBox();
            this.btn6 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.cmbbox3 = new System.Windows.Forms.ComboBox();
            this.cmbbox2 = new System.Windows.Forms.ComboBox();
            this.cmbbox1 = new System.Windows.Forms.ComboBox();
            this.txtbox5 = new System.Windows.Forms.TextBox();
            this.lbl5 = new System.Windows.Forms.Label();
            this.lbl6 = new System.Windows.Forms.Label();
            this.lbl7 = new System.Windows.Forms.Label();
            this.lbl8 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.Grpbox1.SuspendLayout();
            this.Grpbox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grpbox1
            // 
            this.Grpbox1.Controls.Add(this.txtbox4);
            this.Grpbox1.Controls.Add(this.txtbox3);
            this.Grpbox1.Controls.Add(this.txtbox2);
            this.Grpbox1.Controls.Add(this.lbl4);
            this.Grpbox1.Controls.Add(this.lbl3);
            this.Grpbox1.Controls.Add(this.lbl2);
            this.Grpbox1.Controls.Add(this.lbl1);
            this.Grpbox1.Controls.Add(this.txtbox1);
            this.Grpbox1.Location = new System.Drawing.Point(87, 62);
            this.Grpbox1.Name = "Grpbox1";
            this.Grpbox1.Size = new System.Drawing.Size(227, 244);
            this.Grpbox1.TabIndex = 0;
            this.Grpbox1.TabStop = false;
            this.Grpbox1.Text = "Araç Sahibi";
            this.Grpbox1.Enter += new System.EventHandler(this.Grpbox1_Enter);
            // 
            // txtbox4
            // 
            this.txtbox4.Location = new System.Drawing.Point(94, 179);
            this.txtbox4.Name = "txtbox4";
            this.txtbox4.Size = new System.Drawing.Size(100, 22);
            this.txtbox4.TabIndex = 5;
            // 
            // txtbox3
            // 
            this.txtbox3.Location = new System.Drawing.Point(94, 140);
            this.txtbox3.Name = "txtbox3";
            this.txtbox3.Size = new System.Drawing.Size(100, 22);
            this.txtbox3.TabIndex = 6;
            // 
            // txtbox2
            // 
            this.txtbox2.Location = new System.Drawing.Point(94, 101);
            this.txtbox2.Name = "txtbox2";
            this.txtbox2.Size = new System.Drawing.Size(100, 22);
            this.txtbox2.TabIndex = 7;
            this.txtbox2.TextChanged += new System.EventHandler(this.txtbox2_TextChanged);
            // 
            // lbl4
            // 
            this.lbl4.AutoSize = true;
            this.lbl4.Location = new System.Drawing.Point(6, 182);
            this.lbl4.Name = "lbl4";
            this.lbl4.Size = new System.Drawing.Size(74, 16);
            this.lbl4.TabIndex = 3;
            this.lbl4.Text = "Telefon No";
            // 
            // lbl3
            // 
            this.lbl3.AutoSize = true;
            this.lbl3.Location = new System.Drawing.Point(6, 143);
            this.lbl3.Name = "lbl3";
            this.lbl3.Size = new System.Drawing.Size(47, 16);
            this.lbl3.TabIndex = 2;
            this.lbl3.Text = "Soyad";
            // 
            // lbl2
            // 
            this.lbl2.AutoSize = true;
            this.lbl2.Location = new System.Drawing.Point(6, 101);
            this.lbl2.Name = "lbl2";
            this.lbl2.Size = new System.Drawing.Size(24, 16);
            this.lbl2.TabIndex = 1;
            this.lbl2.Text = "Ad";
            // 
            // lbl1
            // 
            this.lbl1.AutoSize = true;
            this.lbl1.Location = new System.Drawing.Point(5, 62);
            this.lbl1.Name = "lbl1";
            this.lbl1.Size = new System.Drawing.Size(25, 16);
            this.lbl1.TabIndex = 0;
            this.lbl1.Text = "TC";
            // 
            // txtbox1
            // 
            this.txtbox1.Location = new System.Drawing.Point(94, 56);
            this.txtbox1.Name = "txtbox1";
            this.txtbox1.Size = new System.Drawing.Size(100, 22);
            this.txtbox1.TabIndex = 2;
            this.txtbox1.TextChanged += new System.EventHandler(this.txtbox1_TextChanged);
            // 
            // Grpbox2
            // 
            this.Grpbox2.Controls.Add(this.btn6);
            this.Grpbox2.Controls.Add(this.btn5);
            this.Grpbox2.Controls.Add(this.cmbbox3);
            this.Grpbox2.Controls.Add(this.cmbbox2);
            this.Grpbox2.Controls.Add(this.cmbbox1);
            this.Grpbox2.Controls.Add(this.txtbox5);
            this.Grpbox2.Controls.Add(this.lbl5);
            this.Grpbox2.Controls.Add(this.lbl6);
            this.Grpbox2.Controls.Add(this.lbl7);
            this.Grpbox2.Controls.Add(this.lbl8);
            this.Grpbox2.Location = new System.Drawing.Point(464, 62);
            this.Grpbox2.Name = "Grpbox2";
            this.Grpbox2.Size = new System.Drawing.Size(234, 244);
            this.Grpbox2.TabIndex = 1;
            this.Grpbox2.TabStop = false;
            this.Grpbox2.Text = "Araç Sahibi Aracı";
            this.Grpbox2.Enter += new System.EventHandler(this.Grpbox2_Enter);
            // 
            // btn6
            // 
            this.btn6.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn6.Location = new System.Drawing.Point(198, 136);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(21, 23);
            this.btn6.TabIndex = 12;
            this.btn6.Text = "+";
            this.btn6.UseVisualStyleBackColor = false;
            // 
            // btn5
            // 
            this.btn5.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btn5.Location = new System.Drawing.Point(198, 99);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(21, 23);
            this.btn5.TabIndex = 11;
            this.btn5.Text = "+";
            this.btn5.UseVisualStyleBackColor = false;
            // 
            // cmbbox3
            // 
            this.cmbbox3.FormattingEnabled = true;
            this.cmbbox3.Location = new System.Drawing.Point(83, 177);
            this.cmbbox3.Name = "cmbbox3";
            this.cmbbox3.Size = new System.Drawing.Size(101, 24);
            this.cmbbox3.TabIndex = 10;
            // 
            // cmbbox2
            // 
            this.cmbbox2.FormattingEnabled = true;
            this.cmbbox2.Location = new System.Drawing.Point(82, 138);
            this.cmbbox2.Name = "cmbbox2";
            this.cmbbox2.Size = new System.Drawing.Size(101, 24);
            this.cmbbox2.TabIndex = 9;
            // 
            // cmbbox1
            // 
            this.cmbbox1.FormattingEnabled = true;
            this.cmbbox1.Location = new System.Drawing.Point(83, 98);
            this.cmbbox1.Name = "cmbbox1";
            this.cmbbox1.Size = new System.Drawing.Size(100, 24);
            this.cmbbox1.TabIndex = 8;
            // 
            // txtbox5
            // 
            this.txtbox5.Location = new System.Drawing.Point(84, 56);
            this.txtbox5.Name = "txtbox5";
            this.txtbox5.Size = new System.Drawing.Size(100, 22);
            this.txtbox5.TabIndex = 4;
            // 
            // lbl5
            // 
            this.lbl5.AutoSize = true;
            this.lbl5.Location = new System.Drawing.Point(6, 56);
            this.lbl5.Name = "lbl5";
            this.lbl5.Size = new System.Drawing.Size(42, 16);
            this.lbl5.TabIndex = 4;
            this.lbl5.Text = "Plaka";
            // 
            // lbl6
            // 
            this.lbl6.AutoSize = true;
            this.lbl6.Location = new System.Drawing.Point(6, 101);
            this.lbl6.Name = "lbl6";
            this.lbl6.Size = new System.Drawing.Size(45, 16);
            this.lbl6.TabIndex = 5;
            this.lbl6.Text = "Marka";
            // 
            // lbl7
            // 
            this.lbl7.AutoSize = true;
            this.lbl7.Location = new System.Drawing.Point(6, 143);
            this.lbl7.Name = "lbl7";
            this.lbl7.Size = new System.Drawing.Size(74, 16);
            this.lbl7.TabIndex = 6;
            this.lbl7.Text = "Araç Rengi";
            // 
            // lbl8
            // 
            this.lbl8.AutoSize = true;
            this.lbl8.Location = new System.Drawing.Point(6, 182);
            this.lbl8.Name = "lbl8";
            this.lbl8.Size = new System.Drawing.Size(62, 16);
            this.lbl8.TabIndex = 7;
            this.lbl8.Text = "Park Yeri";
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(120, 319);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(125, 43);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "Kayıt Ol";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(526, 319);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(122, 48);
            this.btn2.TabIndex = 3;
            this.btn2.Text = "Güncelle";
            this.btn2.UseVisualStyleBackColor = true;
            // 
            // btn4
            // 
            this.btn4.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn4.Location = new System.Drawing.Point(428, 387);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(130, 52);
            this.btn4.TabIndex = 4;
            this.btn4.Text = "Çıkış";
            this.btn4.UseVisualStyleBackColor = false;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn3
            // 
            this.btn3.BackColor = System.Drawing.SystemColors.Highlight;
            this.btn3.Location = new System.Drawing.Point(179, 387);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(135, 51);
            this.btn3.TabIndex = 5;
            this.btn3.Text = "Geri";
            this.btn3.UseVisualStyleBackColor = false;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.btn4);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.Grpbox2);
            this.Controls.Add(this.Grpbox1);
            this.Name = "Form2";
            this.Text = "otopark kayit";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.Grpbox1.ResumeLayout(false);
            this.Grpbox1.PerformLayout();
            this.Grpbox2.ResumeLayout(false);
            this.Grpbox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Grpbox1;
        private System.Windows.Forms.GroupBox Grpbox2;
        private System.Windows.Forms.Label lbl8;
        private System.Windows.Forms.Label lbl7;
        private System.Windows.Forms.Label lbl6;
        private System.Windows.Forms.Label lbl5;
        private System.Windows.Forms.Label lbl4;
        private System.Windows.Forms.Label lbl3;
        private System.Windows.Forms.Label lbl2;
        private System.Windows.Forms.Label lbl1;
        private System.Windows.Forms.TextBox txtbox4;
        private System.Windows.Forms.TextBox txtbox3;
        private System.Windows.Forms.TextBox txtbox2;
        private System.Windows.Forms.TextBox txtbox1;
        private System.Windows.Forms.ComboBox cmbbox3;
        private System.Windows.Forms.ComboBox cmbbox2;
        private System.Windows.Forms.ComboBox cmbbox1;
        private System.Windows.Forms.TextBox txtbox5;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btn5;
    }
}

