namespace RestaurantOtomasyonu_MasaUstuTerminali
{
    partial class KontrolPaneliKasiyer
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.dvgAcikHesaplarEkrani = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button5 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BitisTarihi = new System.Windows.Forms.DateTimePicker();
            this.BaslangicTarihi = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.dvgTumSatislarEkrani = new System.Windows.Forms.DataGridView();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgAcikHesaplarEkrani)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgTumSatislarEkrani)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::RestaurantOtomasyonu_MasaUstuTerminali.Properties.Resources.Logo;
            this.pictureBox1.Location = new System.Drawing.Point(325, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(671, 66);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(13, 96);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1260, 639);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.button1);
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.dvgAcikHesaplarEkrani);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1252, 597);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "..::  Acik Hesaplar Ekrani  ::..";
            // 
            // button1
            // 
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.button1.Location = new System.Drawing.Point(6, 514);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(1243, 48);
            this.button1.TabIndex = 5;
            this.button1.Text = "Satis Raporu Al";
            this.button1.UseVisualStyleBackColor = true;
       //     this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.button2.Location = new System.Drawing.Point(6, 439);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(1243, 48);
            this.button2.TabIndex = 4;
            this.button2.Text = "Hesap Tahsil Et";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // dvgAcikHesaplarEkrani
            // 
            this.dvgAcikHesaplarEkrani.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgAcikHesaplarEkrani.Location = new System.Drawing.Point(6, 50);
            this.dvgAcikHesaplarEkrani.Name = "dvgAcikHesaplarEkrani";
            this.dvgAcikHesaplarEkrani.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgAcikHesaplarEkrani.Size = new System.Drawing.Size(1240, 350);
            this.dvgAcikHesaplarEkrani.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(10, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(530, 29);
            this.label1.TabIndex = 2;
            this.label1.Text = "Gunluk Tahsil Edilmemis Tum Acik Hesaplar";
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.button5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Controls.Add(this.label3);
            this.tabPage2.Controls.Add(this.BitisTarihi);
            this.tabPage2.Controls.Add(this.BaslangicTarihi);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Controls.Add(this.dvgTumSatislarEkrani);
            this.tabPage2.Controls.Add(this.button4);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1252, 597);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "..::  Tum Satislar Ekrani  ::..";
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.button5.Location = new System.Drawing.Point(266, 124);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(473, 36);
            this.button5.TabIndex = 13;
            this.button5.Text = "Listele";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(10, 90);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(139, 29);
            this.label4.TabIndex = 12;
            this.label4.Text = "Bitis Tarihi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(10, 53);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(202, 29);
            this.label3.TabIndex = 11;
            this.label3.Text = "Baslangic Tarihi";
            // 
            // BitisTarihi
            // 
            this.BitisTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BitisTarihi.Location = new System.Drawing.Point(268, 85);
            this.BitisTarihi.Name = "BitisTarihi";
            this.BitisTarihi.Size = new System.Drawing.Size(468, 35);
            this.BitisTarihi.TabIndex = 10;
            // 
            // BaslangicTarihi
            // 
            this.BaslangicTarihi.CustomFormat = "dd/MM/yyyy";
            this.BaslangicTarihi.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.BaslangicTarihi.Location = new System.Drawing.Point(268, 47);
            this.BaslangicTarihi.Name = "BaslangicTarihi";
            this.BaslangicTarihi.Size = new System.Drawing.Size(468, 35);
            this.BaslangicTarihi.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(540, 29);
            this.label2.TabIndex = 8;
            this.label2.Text = "Tarih Araligina Gore Sistemdeki Tum Satislar";
            // 
            // dvgTumSatislarEkrani
            // 
            this.dvgTumSatislarEkrani.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dvgTumSatislarEkrani.Location = new System.Drawing.Point(9, 163);
            this.dvgTumSatislarEkrani.Name = "dvgTumSatislarEkrani";
            this.dvgTumSatislarEkrani.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dvgTumSatislarEkrani.Size = new System.Drawing.Size(1240, 370);
            this.dvgTumSatislarEkrani.TabIndex = 7;
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.button4.Location = new System.Drawing.Point(6, 539);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(1243, 48);
            this.button4.TabIndex = 6;
            this.button4.Text = "Satis Raporu Al";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // button3
            // 
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.button3.Location = new System.Drawing.Point(1078, 12);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(191, 66);
            this.button3.TabIndex = 5;
            this.button3.Text = "Oturum Kapat";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // KontrolPaneliKasiyer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1284, 782);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "KontrolPaneliKasiyer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurant Otomasyonu Masa Ustu Terminali - Kasiyer Paneli";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.KontrolPaneliKasiyer_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgAcikHesaplarEkrani)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dvgTumSatislarEkrani)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dvgAcikHesaplarEkrani;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dvgTumSatislarEkrani;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker BitisTarihi;
        private System.Windows.Forms.DateTimePicker BaslangicTarihi;
        private System.Windows.Forms.Button button5;
    }
}