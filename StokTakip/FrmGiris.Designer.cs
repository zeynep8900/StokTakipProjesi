namespace StokTakip
{
    partial class FrmGiris
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
            btnGiris = new Button();
            label1 = new Label();
            label2 = new Label();
            label4 = new Label();
            label5 = new Label();
            txtAd = new TextBox();
            txtSifre = new TextBox();
            txtMail = new TextBox();
            label6 = new Label();
            txtYetki = new TextBox();
            label3 = new Label();
            txtSoyad = new TextBox();
            SuspendLayout();
            // 
            // btnGiris
            // 
            btnGiris.Location = new Point(149, 324);
            btnGiris.Name = "btnGiris";
            btnGiris.Size = new Size(94, 29);
            btnGiris.TabIndex = 0;
            btnGiris.Text = "Giriş Yap";
            btnGiris.UseVisualStyleBackColor = true;
            btnGiris.Click += btnGiris_Click;
            // 
            // label1
            // 
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 162);
            label1.Location = new Point(1, 9);
            label1.Name = "label1";
            label1.Size = new Size(383, 30);
            label1.TabIndex = 1;
            label1.Text = "Giriş Formu";
            label1.TextAlign = ContentAlignment.TopCenter;
            // 
            // label2
            // 
            label2.Location = new Point(12, 79);
            label2.Name = "label2";
            label2.Size = new Size(81, 25);
            label2.TabIndex = 2;
            label2.Text = "Ad";
            // 
            // label4
            // 
            label4.Location = new Point(12, 206);
            label4.Name = "label4";
            label4.Size = new Size(81, 25);
            label4.TabIndex = 2;
            label4.Text = "Mail";
            // 
            // label5
            // 
            label5.Location = new Point(12, 251);
            label5.Name = "label5";
            label5.Size = new Size(81, 25);
            label5.TabIndex = 2;
            label5.Text = "Şifre";
            // 
            // txtAd
            // 
            txtAd.Location = new Point(99, 79);
            txtAd.Name = "txtAd";
            txtAd.Size = new Size(223, 27);
            txtAd.TabIndex = 3;
            // 
            // txtSifre
            // 
            txtSifre.Location = new Point(99, 251);
            txtSifre.Name = "txtSifre";
            txtSifre.Size = new Size(223, 27);
            txtSifre.TabIndex = 3;
            // 
            // txtMail
            // 
            txtMail.Location = new Point(99, 206);
            txtMail.Name = "txtMail";
            txtMail.Size = new Size(223, 27);
            txtMail.TabIndex = 3;
            // 
            // label6
            // 
            label6.Location = new Point(12, 164);
            label6.Name = "label6";
            label6.Size = new Size(81, 25);
            label6.TabIndex = 2;
            label6.Text = "Yetki";
            // 
            // txtYetki
            // 
            txtYetki.Location = new Point(99, 164);
            txtYetki.Name = "txtYetki";
            txtYetki.Size = new Size(223, 27);
            txtYetki.TabIndex = 3;
            // 
            // label3
            // 
            label3.Location = new Point(12, 122);
            label3.Name = "label3";
            label3.Size = new Size(81, 25);
            label3.TabIndex = 2;
            label3.Text = "Soyad";
            // 
            // txtSoyad
            // 
            txtSoyad.Location = new Point(99, 122);
            txtSoyad.Name = "txtSoyad";
            txtSoyad.Size = new Size(223, 27);
            txtSoyad.TabIndex = 3;
            // 
            // FrmGiris
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(396, 450);
            Controls.Add(txtMail);
            Controls.Add(txtSifre);
            Controls.Add(txtYetki);
            Controls.Add(txtSoyad);
            Controls.Add(txtAd);
            Controls.Add(label5);
            Controls.Add(label6);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(btnGiris);
            Name = "FrmGiris";
            Text = "FrmGiris";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnGiris;
        private Label label1;
        private Label label2;
        private Label label4;
        private Label label5;
        private TextBox txtAd;
        private TextBox txtSifre;
        private TextBox txtMail;
        private Label label6;
        private TextBox txtYetki;
        private Label label3;
        private TextBox txtSoyad;
    }
}