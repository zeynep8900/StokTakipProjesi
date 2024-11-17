using StokTakip.Db;
using StokTakip.Modeller;
using System;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();

            // Şifre alanının özelliklerini ayarla
            txtSifre.PasswordChar = '●'; // Şifre yazarken görünmesi gereken karakter
        }

        private string HashPassword(string password)
        {
            using (SHA256 sha256 = SHA256.Create())
            {
                byte[] bytes = Encoding.UTF8.GetBytes(password);
                byte[] hash = sha256.ComputeHash(bytes);
                return Convert.ToBase64String(hash);
            }
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            DbKullanicilar kullanici = null;

            using (StokTakipContext context = new StokTakipContext())
            {
                string hashedPassword = HashPassword(txtSifre.Text);

                kullanici = context.Kullanicilar.FirstOrDefault(
                    e =>
                    e.Ad == txtAd.Text &&
                    e.Soyad == txtSoyad.Text &&
                    e.Yetki == txtYetki.Text &&
                    e.KullaniciMail == txtMail.Text &&
                    e.Parola == hashedPassword
                );

                if (kullanici != null)
                {
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Close();
                }
                else
                {
                    if (MessageBox.Show("Kullanıcı bulunamadı. Kayıt olmak ister misiniz?", "Kayıt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        DbKullanicilar yeniKullanici = new DbKullanicilar()
                        {
                            Ad = txtAd.Text,
                            Soyad = txtSoyad.Text,
                            KullaniciMail = txtMail.Text,
                            Yetki = txtYetki.Text,
                            Parola = hashedPassword
                        };

                        context.Kullanicilar.Add(yeniKullanici);
                        context.SaveChanges();

                        MessageBox.Show("Kayıt başarılı! Giriş yapabilirsiniz.", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("Lütfen geçerli bir kullanıcı adı ve şifre giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }
    }
}