namespace RestaurantOtomasyonu_MasaUstuTerminali
{
    partial class KontrolPaneliAsci
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
            this.components = new System.ComponentModel.Container();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvWebSiparisleri = new System.Windows.Forms.DataGridView();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.dgvSalonSiparisleri = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.dgvTumSiparisler = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.restaurantOtomasyonuDataSet7 = new RestaurantOtomasyonu_MasaUstuTerminali.RestaurantOtomasyonuDataSet7();
            this.tblStoklarBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tbl_StoklarTableAdapter = new RestaurantOtomasyonu_MasaUstuTerminali.RestaurantOtomasyonuDataSet7TableAdapters.Tbl_StoklarTableAdapter();
            this.button4 = new System.Windows.Forms.Button();
            this.iDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokKoduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.malzemeAdiDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stokLimitDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.gelenMiktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.kalanMiktarDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWebSiparisleri)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalonSiparisleri)).BeginInit();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTumSiparisler)).BeginInit();
            this.tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantOtomasyonuDataSet7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStoklarBindingSource)).BeginInit();
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
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(12, 98);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1260, 639);
            this.tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.Black;
            this.tabPage1.Controls.Add(this.button2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.dgvWebSiparisleri);
            this.tabPage1.Location = new System.Drawing.Point(4, 38);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1252, 597);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "..::  Web Siparisleri Ekrani  ::..";
            // 
            // button2
            // 
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.button2.Location = new System.Drawing.Point(4, 484);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(1243, 48);
            this.button2.TabIndex = 2;
            this.button2.Text = "Secili Siparisi Kurye\'ye \"Siparis Hazir\" Mesaji Olarak Gonder";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(11, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(448, 29);
            this.label1.TabIndex = 1;
            this.label1.Text = "Web Uzerinden Gelen Tum Siparisler";
            // 
            // dgvWebSiparisleri
            // 
            this.dgvWebSiparisleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvWebSiparisleri.Location = new System.Drawing.Point(6, 49);
            this.dgvWebSiparisleri.Name = "dgvWebSiparisleri";
            this.dgvWebSiparisleri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvWebSiparisleri.Size = new System.Drawing.Size(1240, 350);
            this.dgvWebSiparisleri.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.Black;
            this.tabPage2.Controls.Add(this.button3);
            this.tabPage2.Controls.Add(this.dgvSalonSiparisleri);
            this.tabPage2.Controls.Add(this.label2);
            this.tabPage2.Location = new System.Drawing.Point(4, 38);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1252, 597);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "..::  Salon Siparis Ekrani  ::..";
            // 
            // button3
            // 
            this.button3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.button3.Location = new System.Drawing.Point(6, 482);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(1243, 48);
            this.button3.TabIndex = 4;
            this.button3.Text = "Secili Siparisi Garson\'a \"Siparis Hazir\" Mesaji Olarak Gonder";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // dgvSalonSiparisleri
            // 
            this.dgvSalonSiparisleri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSalonSiparisleri.Location = new System.Drawing.Point(6, 49);
            this.dgvSalonSiparisleri.Name = "dgvSalonSiparisleri";
            this.dgvSalonSiparisleri.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSalonSiparisleri.Size = new System.Drawing.Size(1240, 350);
            this.dgvSalonSiparisleri.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(11, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(529, 29);
            this.label2.TabIndex = 2;
            this.label2.Text = "Salonda Garsonlardan Gelen Tum Siparisler";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.Black;
            this.tabPage3.Controls.Add(this.dgvTumSiparisler);
            this.tabPage3.Controls.Add(this.label3);
            this.tabPage3.Location = new System.Drawing.Point(4, 38);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1252, 597);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "..::  Tum Siparisler Ekrani  ::..";
            // 
            // dgvTumSiparisler
            // 
            this.dgvTumSiparisler.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTumSiparisler.Location = new System.Drawing.Point(6, 49);
            this.dgvTumSiparisler.Name = "dgvTumSiparisler";
            this.dgvTumSiparisler.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvTumSiparisler.Size = new System.Drawing.Size(1240, 350);
            this.dgvTumSiparisler.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(11, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(322, 29);
            this.label3.TabIndex = 3;
            this.label3.Text = "Sistemdeki Tum Siparisler";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.button1.Location = new System.Drawing.Point(1081, 12);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(191, 66);
            this.button1.TabIndex = 4;
            this.button1.Text = "Oturum Kapat";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.Black;
            this.tabPage4.Controls.Add(this.button4);
            this.tabPage4.Controls.Add(this.dataGridView1);
            this.tabPage4.Location = new System.Drawing.Point(4, 38);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(1252, 597);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "..::  Stok Girisi  ::..";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.iDDataGridViewTextBoxColumn,
            this.stokKoduDataGridViewTextBoxColumn,
            this.malzemeAdiDataGridViewTextBoxColumn,
            this.stokLimitDataGridViewTextBoxColumn,
            this.gelenMiktarDataGridViewTextBoxColumn,
            this.kalanMiktarDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblStoklarBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(7, 21);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1239, 504);
            this.dataGridView1.TabIndex = 0;
            // 
            // restaurantOtomasyonuDataSet7
            // 
            this.restaurantOtomasyonuDataSet7.DataSetName = "RestaurantOtomasyonuDataSet7";
            this.restaurantOtomasyonuDataSet7.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblStoklarBindingSource
            // 
            this.tblStoklarBindingSource.DataMember = "Tbl_Stoklar";
            this.tblStoklarBindingSource.DataSource = this.restaurantOtomasyonuDataSet7;
            // 
            // tbl_StoklarTableAdapter
            // 
            this.tbl_StoklarTableAdapter.ClearBeforeFill = true;
            // 
            // button4
            // 
            this.button4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(57)))), ((int)(((byte)(85)))));
            this.button4.Location = new System.Drawing.Point(7, 531);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(1242, 48);
            this.button4.TabIndex = 1;
            this.button4.Text = "Yeni Stok Girisi Yap";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // iDDataGridViewTextBoxColumn
            // 
            this.iDDataGridViewTextBoxColumn.DataPropertyName = "ID";
            this.iDDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDDataGridViewTextBoxColumn.Name = "iDDataGridViewTextBoxColumn";
            // 
            // stokKoduDataGridViewTextBoxColumn
            // 
            this.stokKoduDataGridViewTextBoxColumn.DataPropertyName = "StokKodu";
            this.stokKoduDataGridViewTextBoxColumn.HeaderText = "StokKodu";
            this.stokKoduDataGridViewTextBoxColumn.Name = "stokKoduDataGridViewTextBoxColumn";
            // 
            // malzemeAdiDataGridViewTextBoxColumn
            // 
            this.malzemeAdiDataGridViewTextBoxColumn.DataPropertyName = "MalzemeAdi";
            this.malzemeAdiDataGridViewTextBoxColumn.FillWeight = 400F;
            this.malzemeAdiDataGridViewTextBoxColumn.HeaderText = "MalzemeAdi";
            this.malzemeAdiDataGridViewTextBoxColumn.Name = "malzemeAdiDataGridViewTextBoxColumn";
            // 
            // stokLimitDataGridViewTextBoxColumn
            // 
            this.stokLimitDataGridViewTextBoxColumn.DataPropertyName = "StokLimit";
            this.stokLimitDataGridViewTextBoxColumn.HeaderText = "StokLimit";
            this.stokLimitDataGridViewTextBoxColumn.Name = "stokLimitDataGridViewTextBoxColumn";
            // 
            // gelenMiktarDataGridViewTextBoxColumn
            // 
            this.gelenMiktarDataGridViewTextBoxColumn.DataPropertyName = "GelenMiktar";
            this.gelenMiktarDataGridViewTextBoxColumn.HeaderText = "GelenMiktar";
            this.gelenMiktarDataGridViewTextBoxColumn.Name = "gelenMiktarDataGridViewTextBoxColumn";
            // 
            // kalanMiktarDataGridViewTextBoxColumn
            // 
            this.kalanMiktarDataGridViewTextBoxColumn.DataPropertyName = "KalanMiktar";
            this.kalanMiktarDataGridViewTextBoxColumn.HeaderText = "KalanMiktar";
            this.kalanMiktarDataGridViewTextBoxColumn.Name = "kalanMiktarDataGridViewTextBoxColumn";
            // 
            // KontrolPaneliAsci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Maroon;
            this.ClientSize = new System.Drawing.Size(1284, 748);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "KontrolPaneliAsci";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Restaurant Otomasyonu Masa Ustu Terminali - Asci Paneli";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.KontrolPaneliAsci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvWebSiparisleri)).EndInit();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSalonSiparisleri)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTumSiparisler)).EndInit();
            this.tabPage4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.restaurantOtomasyonuDataSet7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblStoklarBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvWebSiparisleri;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvSalonSiparisleri;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DataGridView dgvTumSiparisler;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private RestaurantOtomasyonuDataSet7 restaurantOtomasyonuDataSet7;
        private System.Windows.Forms.BindingSource tblStoklarBindingSource;
        private RestaurantOtomasyonuDataSet7TableAdapters.Tbl_StoklarTableAdapter tbl_StoklarTableAdapter;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.DataGridViewTextBoxColumn iDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokKoduDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn malzemeAdiDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn stokLimitDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn gelenMiktarDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn kalanMiktarDataGridViewTextBoxColumn;
    }
}