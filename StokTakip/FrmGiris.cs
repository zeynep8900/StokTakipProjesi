using StokTakip.Modeller;
using System;
using System.Linq;
using System.Windows.Forms;

namespace StokTakip
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void btnGiris_Click(object sender, EventArgs e)
        {
            DbKullanicilar kullanici = null;
            Db.StokTakipContext context = new Db.StokTakipContext();

            // Try to find the user based on the provided login details
            kullanici = context.Kullanicilar.FirstOrDefault(
                e =>
                e.Ad == txtAd.Text &&
                e.Soyad == txtSoyad.Text &&
                e.KullaniciMail == txtMail.Text &&
                e.Yetki == txtYetki.Text &&
                e.Parola == txtSifre.Text);

            // If the user is found, login is successful
            if (kullanici != null)
            {
                // Open Form1
                Form1 form1 = new Form1();
                form1.Show();
                this.Close();
            }
            else
            {
                // If user is not found, treat it as a registration
                if (MessageBox.Show("Kullanıcı bulunamadı. Kayıt olmak ister misiniz?", "Kayıt", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    // Create a new user object and save to the database
                    DbKullanicilar yeniKullanici = new DbKullanicilar()
                    {
                        Ad = txtAd.Text,
                        Soyad = txtSoyad.Text,
                        KullaniciMail = txtMail.Text,
                        Yetki = txtYetki.Text,
                        Parola = txtSifre.Text
                    };

                    // Add the new user to the database
                    context.Kullanicilar.Add(yeniKullanici);
                    context.SaveChanges();

                    // Inform the user that registration was successful
                    MessageBox.Show("Kayıt başarılı! Giriş yapabilirsiniz.", "Kayıt", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // After registration, you can proceed with the login process
                    Form1 form1 = new Form1();
                    form1.Show();
                    this.Close();
                }
                else
                {
                    // If the user does not want to register, show an error
                    MessageBox.Show("Lütfen geçerli bir kullanıcı adı ve şifre giriniz.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
