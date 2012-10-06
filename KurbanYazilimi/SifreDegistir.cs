using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace KurbanYazilimi
{
    public partial class SifreDegistir : Form
    {
        public SifreDegistir()
        {
            InitializeComponent();
        }
        Fonksiyon system = new Fonksiyon();

        private void button1_Click(object sender, EventArgs e)
        {
           
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            try
            {
                if (txtMevcutSifre.Text != "" && maskedTextBox1.Text != "")
                {
                    if (maskedTextBox1.Text == maskedTextBox2.Text)
                    {
                        String sifre = system.GetDataCell("select Sifre from Kullanicilar where ID=7 ");
                        if (sifre == txtMevcutSifre.Text)
                        {
                            system.Sorgu("UPDATE Kullanicilar SET Sifre = '" + maskedTextBox1.Text + "' where ID=7 ");
                            MessageBox.Show("Yönetici Şifre Güncellemesi Yapıldı !", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else MessageBox.Show("Mevcut Şifreyi Yanlış Girdiniz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else MessageBox.Show("Yeni Şifre Tekrarı Yanlış Girdiniz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else MessageBox.Show("Mevcut Şifre ve Yeni Şifre Boş Geçilemez !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch { MessageBox.Show("Beklenmedik Bir Hata Oluştu", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void btnOnayla2_Click(object sender, EventArgs e)
        {
            try
            {
                if (txt2MevcutSifre.Text != "" && maskedTextBox3.Text != "")
                {
                    if (maskedTextBox3.Text == maskedTextBox4.Text)
                    {
                        String sifre = system.GetDataCell("select Sifre from Kullanicilar where ID=6 ");
                        if (sifre == txt2MevcutSifre.Text)
                        {
                            system.Sorgu("UPDATE Kullanicilar SET Sifre = '" + maskedTextBox3.Text + "' where ID=6 ");
                            MessageBox.Show("Kullanıcı Şifre Güncellemesi Yapıldı !", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        }
                        else MessageBox.Show("Mevcut Şifreyi Yanlış Girdiniz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    else MessageBox.Show("Yeni Şifre Tekrarı Yanlış Girdiniz !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else MessageBox.Show("Mevcut Şifre ve Yeni Şifre Boş Geçilemez !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            catch { MessageBox.Show("Beklenmedik Bir Hata Oluştu", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void SifreDegistir_Load(object sender, EventArgs e)
        {
            txtEposta.Text = system.GetDataCell("select Eposta from Kullanicilar where ID=7");
        }

        private void btnEpostaGuncelle_Click(object sender, EventArgs e)
        {
            system.Sorgu("UPDATE Kullanicilar SET Eposta = '" + txtEposta.Text + "' where ID=7 ");
            MessageBox.Show("Eposta Güncellemesi Yapıldı !", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
