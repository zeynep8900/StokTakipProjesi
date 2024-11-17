namespace StokTakip
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            dbUrunlerBindingSource = new BindingSource(components);
            dbKategorilerBindingSource = new BindingSource(components);
            dbBirimlerBindingSource = new BindingSource(components);
            button1 = new Button();
            button2 = new Button();
            label1 = new Label();
            urunKoduDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            urunAdDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            urunAciklamaDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            minStokDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            maksStokDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            kategoriDataGridViewComboBoxColumn = new DataGridViewComboBoxColumn();
            birimDataGridViewTextBoxColumn = new DataGridViewComboBoxColumn();
            stokGirislerDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            stokCikislarDataGridViewTextBoxColumn = new DataGridViewTextBoxColumn();
            ColSil = new DataGridViewButtonColumn();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dbUrunlerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dbKategorilerBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dbBirimlerBindingSource).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridView1.ColumnHeadersHeight = 29;
            dataGridView1.Columns.AddRange(new DataGridViewColumn[] { urunKoduDataGridViewTextBoxColumn, urunAdDataGridViewTextBoxColumn, urunAciklamaDataGridViewTextBoxColumn, minStokDataGridViewTextBoxColumn, maksStokDataGridViewTextBoxColumn, kategoriDataGridViewComboBoxColumn, birimDataGridViewTextBoxColumn, stokGirislerDataGridViewTextBoxColumn, stokCikislarDataGridViewTextBoxColumn, ColSil });
            dataGridView1.DataSource = dbUrunlerBindingSource;
            dataGridView1.Location = new Point(26, 48);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 51;
            dataGridView1.Size = new Size(978, 357);
            dataGridView1.TabIndex = 3;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            dataGridView1.DataError += dataGridView1_DataError_1;
            // 
            // dbUrunlerBindingSource
            // 
            dbUrunlerBindingSource.DataSource = typeof(Modeller.DbUrunler);
            // 
            // dbKategorilerBindingSource
            // 
            dbKategorilerBindingSource.DataSource = typeof(Modeller.DbKategoriler);
            // 
            // dbBirimlerBindingSource
            // 
            dbBirimlerBindingSource.DataSource = typeof(Modeller.DbBirimler);
            // 
            // button1
            // 
            button1.Location = new Point(852, 411);
            button1.Name = "button1";
            button1.Size = new Size(152, 29);
            button1.TabIndex = 4;
            button1.Text = "Kaydet ve Güncelle";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(910, 3);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 5;
            button2.Text = "Çıkış Yap";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // label1
            // 
            label1.Location = new Point(725, 7);
            label1.Name = "label1";
            label1.Size = new Size(188, 25);
            label1.TabIndex = 6;
            label1.Text = "Merhabaaaa";
            label1.Click += label1_Click;
            // 
            // urunKoduDataGridViewTextBoxColumn
            // 
            urunKoduDataGridViewTextBoxColumn.DataPropertyName = "UrunKodu";
            urunKoduDataGridViewTextBoxColumn.HeaderText = "Urun Kodu";
            urunKoduDataGridViewTextBoxColumn.MinimumWidth = 6;
            urunKoduDataGridViewTextBoxColumn.Name = "urunKoduDataGridViewTextBoxColumn";
            // 
            // urunAdDataGridViewTextBoxColumn
            // 
            urunAdDataGridViewTextBoxColumn.DataPropertyName = "UrunAd";
            urunAdDataGridViewTextBoxColumn.HeaderText = "Urun Ad";
            urunAdDataGridViewTextBoxColumn.MinimumWidth = 6;
            urunAdDataGridViewTextBoxColumn.Name = "urunAdDataGridViewTextBoxColumn";
            // 
            // urunAciklamaDataGridViewTextBoxColumn
            // 
            urunAciklamaDataGridViewTextBoxColumn.DataPropertyName = "UrunAciklama";
            urunAciklamaDataGridViewTextBoxColumn.HeaderText = "Urun Aciklama";
            urunAciklamaDataGridViewTextBoxColumn.MinimumWidth = 6;
            urunAciklamaDataGridViewTextBoxColumn.Name = "urunAciklamaDataGridViewTextBoxColumn";
            // 
            // minStokDataGridViewTextBoxColumn
            // 
            minStokDataGridViewTextBoxColumn.DataPropertyName = "MinStok";
            minStokDataGridViewTextBoxColumn.HeaderText = "Min Stok";
            minStokDataGridViewTextBoxColumn.MinimumWidth = 6;
            minStokDataGridViewTextBoxColumn.Name = "minStokDataGridViewTextBoxColumn";
            // 
            // maksStokDataGridViewTextBoxColumn
            // 
            maksStokDataGridViewTextBoxColumn.DataPropertyName = "MaksStok";
            maksStokDataGridViewTextBoxColumn.HeaderText = "Maks Stok";
            maksStokDataGridViewTextBoxColumn.MinimumWidth = 6;
            maksStokDataGridViewTextBoxColumn.Name = "maksStokDataGridViewTextBoxColumn";
            // 
            // kategoriDataGridViewComboBoxColumn
            // 
            kategoriDataGridViewComboBoxColumn.DataPropertyName = "KategoriId";
            kategoriDataGridViewComboBoxColumn.HeaderText = "Kategori";
            kategoriDataGridViewComboBoxColumn.MinimumWidth = 6;
            kategoriDataGridViewComboBoxColumn.Name = "kategoriDataGridViewComboBoxColumn";
            kategoriDataGridViewComboBoxColumn.Resizable = DataGridViewTriState.True;
            kategoriDataGridViewComboBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // birimDataGridViewTextBoxColumn
            // 
            birimDataGridViewTextBoxColumn.DataPropertyName = "BirimId";
            birimDataGridViewTextBoxColumn.HeaderText = "Birim";
            birimDataGridViewTextBoxColumn.MinimumWidth = 6;
            birimDataGridViewTextBoxColumn.Name = "birimDataGridViewTextBoxColumn";
            birimDataGridViewTextBoxColumn.Resizable = DataGridViewTriState.True;
            birimDataGridViewTextBoxColumn.SortMode = DataGridViewColumnSortMode.Automatic;
            // 
            // stokGirislerDataGridViewTextBoxColumn
            // 
            stokGirislerDataGridViewTextBoxColumn.DataPropertyName = "StokGirisler";
            stokGirislerDataGridViewTextBoxColumn.HeaderText = "Stok Giris";
            stokGirislerDataGridViewTextBoxColumn.MinimumWidth = 6;
            stokGirislerDataGridViewTextBoxColumn.Name = "stokGirislerDataGridViewTextBoxColumn";
            // 
            // stokCikislarDataGridViewTextBoxColumn
            // 
            stokCikislarDataGridViewTextBoxColumn.DataPropertyName = "StokCikislar";
            stokCikislarDataGridViewTextBoxColumn.HeaderText = "Stok Cikis";
            stokCikislarDataGridViewTextBoxColumn.MinimumWidth = 6;
            stokCikislarDataGridViewTextBoxColumn.Name = "stokCikislarDataGridViewTextBoxColumn";
            // 
            // ColSil
            // 
            ColSil.HeaderText = "Sil";
            ColSil.MinimumWidth = 6;
            ColSil.Name = "ColSil";
            ColSil.Text = "Sil";
            ColSil.UseColumnTextForButtonValue = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1042, 452);
            Controls.Add(label1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dataGridView1);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dbUrunlerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dbKategorilerBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dbBirimlerBindingSource).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private DataGridView dataGridView1;
        private BindingSource dbUrunlerBindingSource;
        private BindingSource dbKategorilerBindingSource;
        private BindingSource dbBirimlerBindingSource;
        private Button button1;
        private Button button2;
        private Label label1;
        private DataGridViewTextBoxColumn urunKoduDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn urunAdDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn urunAciklamaDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn minStokDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn maksStokDataGridViewTextBoxColumn;
        private DataGridViewComboBoxColumn kategoriDataGridViewComboBoxColumn;
        private DataGridViewComboBoxColumn birimDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stokGirislerDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stokCikislarDataGridViewTextBoxColumn;
        private DataGridViewButtonColumn ColSil;
    }
}
