using StokTakip.Db;
using StokTakip.Modeller;
using System.ComponentModel;

namespace StokTakip
{
    public partial class Form1 : Form
    {
        StokTakipContext context = new StokTakipContext();
        BindingList<DbUrunler> blist;
        public Form1()
        {
            InitializeComponent();
            blist = new BindingList<DbUrunler>(context.Urunler.ToList());
            dataGridView1.AutoGenerateColumns = false;
            dataGridView1.DataSource = blist;


            kategoriDataGridViewComboBoxColumn.DataSource = context.Kategoriler.ToList();
            kategoriDataGridViewComboBoxColumn.DisplayMember = "KategoriAd";
            kategoriDataGridViewComboBoxColumn.ValueMember = "KategoriId";

            birimDataGridViewTextBoxColumn.DataSource = context.Birimler.ToList();
            birimDataGridViewTextBoxColumn.DisplayMember = "BirimAd";
            birimDataGridViewTextBoxColumn.ValueMember = "BirimId";
        }








        private void dataGridView1_DataError(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == ColSil.Index)
            {
                DbUrunler urunler = dataGridView1.Rows[e.RowIndex].DataBoundItem as DbUrunler;

                if (urunler != null)
                {
                    var cevap = MessageBox.Show(urunler.UrunAd + "  ürün koduna sahip " +
                        " ürünü silmek istediðinize emin misiniz?", "Dikkat",
                        MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (cevap == DialogResult.Yes)
                    {
                        blist.Remove(urunler);
                        context.Urunler.Remove(urunler);
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            foreach (DbUrunler urun in blist)
            {
                if (urun.UrunId <= 0) // Yeni ürün ekleme
                {
                    context.Urunler.Add(urun);
                }
                else // Varolan ürünü güncelleme
                {
                    var existingUrun = context.Urunler.Find(urun.UrunId);
                    if (existingUrun != null)
                    {
                        context.Entry(existingUrun).CurrentValues.SetValues(urun);
                    }
                }
            }

            try
            {
                context.SaveChanges();
                MessageBox.Show("Veriler kaydedildi.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Bir hata oluþtu: {ex.Message}{ex.InnerException?.Message}");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //this.Close();
            this.Hide(); // Mevcut formu gizler
            FrmGiris girisFormu = new FrmGiris(); // Yeni bir frmGiris nesnesi oluþturulur
            girisFormu.Show();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }


        private void dataGridView1_DataError_1(object sender, DataGridViewDataErrorEventArgs e)
        {
            e.Cancel = true;
        }
    }
}