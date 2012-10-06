using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.Net;
using System.Threading;

namespace KurbanYazilimi
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }
        Fonksiyon system = new Fonksiyon();

        public void KullaniciSorgula()
        {
            try
            {
                String sifre = system.GetDataCell("Select Sifre from Kullanicilar where KullaniciAdi='" + txtKullaniciAdi.Text + "' and Tipi='user'");
                if (sifre.Equals(txtSifre.Text))
                {

                    this.DialogResult = DialogResult.OK;
                    AnaForm.yetki = "kullanici";
                }
                else
                {

                    lblUyari.Text = "Log in Hatası !";
                }
            }
            catch (Exception)
            {

                lblUyari.Text = "Log in Hatası !";
            }

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        public void YoneticiSorgula()
        {
            try
            {
                String sifre2 = system.GetDataCell("Select Sifre from Kullanicilar where KullaniciAdi='" + txtKullaniciAdi2.Text + "' and Tipi='manager'");
                if (sifre2.Equals(txtSifre2.Text))
                {

                    this.DialogResult = DialogResult.OK;
                    AnaForm.yetki = "manager";
                }
                else
                {

                    lblUyari2.Text = "Log in Hatası !";
                }
            }
            catch (Exception)
            {

                lblUyari2.Text = "Log in Hatası !";
            }

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            DataRow drKurum = system.GetDataRow("select * from Kurum where ID= (select max(ID) from Kurum)");
            this.Text= drKurum["KurumAdi"].ToString() + " KTP | Güvenlik";
                //

        }

        private void btnKullaniciLogin_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi.Text != "" && txtSifre.Text != "")
            {

                KullaniciSorgula();

            }
            else
            {
                lblUyari.Text = "Kullanıcı Adı yada Şifre Boş Geçilemez !";

            }
        }

        private void btnYoneticiLogin_Click(object sender, EventArgs e)
        {
            if (txtKullaniciAdi2.Text != "" && txtSifre2.Text != "")
            {

                YoneticiSorgula();

            }
            else
            {
                lblUyari.Text = "Kullanıcı Adı yada Şifre Boş Geçilemez !";

            }
            
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            string MailGonderilecekAdres = system.GetDataCell("select Eposta from Kullanicilar where ID=7");
            lblNotum.Text = "Bilgileriniz Gönderiliyor. Lütfen Bekleyiniz...";
            DialogResult verilencevap = MessageBox.Show("Bilgileriniz "+MailGonderilecekAdres+" adresine gönderilmesini istiyor musunuz ?" , "Sorgu", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (verilencevap == DialogResult.Yes) {
                try
                {
                    
                    //Thread.Sleep(2000);
                    string Mesaj = "Akarçeşme Erkek Öğrenci Yurdu KTP Kurban Takip Programı v.1 Uygulamasına ait Log in Bilgileri Aşağıdaki Gibidir :"
                        + "<br/><br/> Tarih : " + System.DateTime.Now.ToShortDateString()
                        + "<br/><br/> <b>Yonetici Kullanici Adi :</b>" + system.GetDataCell("select KullaniciAdi from Kullanicilar where ID=7")
                    + "<br/><b>Yonetici Şifre :</b>" + system.GetDataCell("select Sifre from Kullanicilar where ID=7")
                    + "<br/><br/><b>Diğer Kullanici Adi :</b>" + system.GetDataCell("select KullaniciAdi from Kullanicilar where ID=6")
                    + "<br/><b>Diğer Kullanici Şifre :</b>" + system.GetDataCell("select Sifre from Kullanicilar where ID=6")
                    
                    + "<br/><br/><br/><br/><br/> <I>Bu iletiyi cevaplandırmayınız. Gönderilen mailler değerlendirilmez. Teşekkür Ederiz.</I>";
                    

                    MailMessage msg = new MailMessage();
                    msg.IsBodyHtml = true;
                    msg.To.Add(MailGonderilecekAdres);

                    msg.From = new MailAddress("akarcesmety@gmail.com", "Akarçeşme Erkek Öğrenci Yurdu KTP v.1", System.Text.Encoding.UTF8);
                    msg.Subject = "Log in Bilgileri";
                    msg.Body = Mesaj;

                    SmtpClient smp = new SmtpClient();
                    smp.Credentials = new NetworkCredential("akarcesmety@gmail.com", "Kocaeli41");
                    smp.Port = 465;
                    //smp.Port = 587;
                    smp.Host = "smtp.gmail.com";
                    smp.EnableSsl = true;
                    smp.Send(msg);
                    MessageBox.Show("Log in Bilgileriniz Gönderildi !", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch
                {
                    MessageBox.Show("Hata Oluştu. İnternet Bağlantınızı Kontrol Edin !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
               
            }


            lblNotum.Text = "";
        }

        private void txtKullaniciAdi_MouseClick(object sender, MouseEventArgs e)
        {
            HelpProvider helper = new HelpProvider();

            helper.SetShowHelp(this.txtKullaniciAdi, true);

            helper.SetHelpString(this.txtKullaniciAdi, "Help text");
            
        }

        private void txtKullaniciAdi_TextChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
