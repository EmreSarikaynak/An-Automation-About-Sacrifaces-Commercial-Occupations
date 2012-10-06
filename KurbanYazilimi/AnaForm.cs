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
    public partial class AnaForm : Form
    {
        public AnaForm()
        {
            InitializeComponent();
        }

        public static String yetki = "";
        private void yeniMüşteriEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {

            YeniKayit YeniKayit = new YeniKayit();
            YeniKayit.MdiParent = this;
            YeniKayit.Show();
        }
        Fonksiyon system = new Fonksiyon();
        private void AnaForm_Load(object sender, EventArgs e)
        {
            DataRow drKurum= system.GetDataRow("select * from Kurum where ID= (select max(ID) from Kurum)");
            if (drKurum["KurumAdi"].ToString().Equals("Genel"))
            {
                IlkKurulum();
            }
            else {
                this.Text = drKurum["KurumAdi"].ToString() + " Kurban Takip Programı 2012 v.1";
                Login();
                if (yetki != "manager")
                {
                    yönetimToolStripMenuItem.Visible = false;
                }


            }

            TimeSpan ts = Convert.ToDateTime(drKurum["LisansBitisTar"].ToString()) - DateTime.Now;


            if (ts.Days < 0)
            {
                lblLisans.Visible = false;
                menuStrip1.Enabled = false;
                contextMenuStrip1.Enabled = false;
                //DialogResult Result = MessageBox.Show("Malesef Programın Kullanım Süresi Dolmuştur.\nOnline Lisans Başvurusu için tıklayınız.", "Uyarı", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                MessageBox.Show("Malesef Programın Kullanım Süresi Dolmuştur.", "Bildirim", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Question);
                //if (Result == DialogResult.Yes)
                //{
                //    OnlineLisans OnlineLisans = new OnlineLisans();
                //    OnlineLisans.MdiParent = this;
                //    OnlineLisans.Show();
                //}
                //else
                //{

                //}
                //this.Close();
            }
            if (ts.Days < 30)
            {
                lblLisans.Text = "Kullanım süresinin sona ermesine " + (ts.Days).ToString() + " gün kaldı.";
            }
            else {
                lblLisans.Text = "";
                //onlineLisansGüncelleToolStripMenuItem.Visible = false;
            }



        }

       


        private void Login()
        {

            FrmLogin frmlogin = new FrmLogin();
            this.Visible = false;
            DialogResult loginResult = frmlogin.ShowDialog();
            if (loginResult == DialogResult.OK)
            {
                this.Visible = true;
            }
            else
            {
                this.Close();

            }
        }
        private void IlkKurulum()
        {
            KurumBilgileriGiris krmBilBel = new KurumBilgileriGiris();
            this.Visible = false;
            DialogResult krmBilBelResult = krmBilBel.ShowDialog();
            if (krmBilBelResult == DialogResult.OK)
            {
                this.Visible = true;
            }
            else
            {
                this.Close();

            }
        }



        private void yeniKurbanEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void kurbanSilToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void müşteriSilToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormMusteriSil musteriSil = new FormMusteriSil();
            musteriSil.MdiParent = this;
            musteriSil.Show();
        }

        private void müşteriBilgiDüzenleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKisiselBilgiDuzenle KisiselBilgiDuzenle = new FormKisiselBilgiDuzenle();
            KisiselBilgiDuzenle.MdiParent = this;
            KisiselBilgiDuzenle.Show();
        }

        private void kurbanıDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKurbanDegistir kurbandegistir = new FormKurbanDegistir();
            kurbandegistir.MdiParent = this;
            kurbandegistir.Show();

        }

        private void iletişimToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Iletisim Iletisim = new Iletisim();
            Iletisim.MdiParent = this;
            Iletisim.Show();
        }

        private void müşterilerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriListesi MusteriListesi = new MusteriListesi();
            MusteriListesi.MdiParent = this;
            MusteriListesi.Show();

        }

        private void kurbanlarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void güvenlikToolStripMenuItem_Click(object sender, EventArgs e)
        {


        }

        private void kurbanTipleriToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnMusteriKayit_Click(object sender, EventArgs e)
        {
            
        }

        private void cmbKurbanTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            

        }

        private void yeniHisseKayıtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            YeniKayit YeniKayit = new YeniKayit();
            YeniKayit.MdiParent = this;
            YeniKayit.Show();
        }

        private void hisseDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormKurbanDegistir kurbandegistir = new FormKurbanDegistir();
            kurbandegistir.MdiParent = this;
            kurbandegistir.Show();
        }

        private void kurbanEkleToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void kurbanSilToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void kurbanTipleriToolStripMenuItem1_Click(object sender, EventArgs e)
        {

        }

        private void şifreDeğiştirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SifreDegistir SifreDegistir = new SifreDegistir();
            SifreDegistir.MdiParent = this;
            SifreDegistir.Show();
        }

        private void çıkışToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //private void müşteriListesiToolStripMenuItem_Click(object sender, EventArgs e)
        //{
   
        //}

        private void kurbanlarToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
 
        }

        private void kurbanEkleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FormKurbanEkleme kurbanekle = new FormKurbanEkleme();
            kurbanekle.MdiParent = this;
            kurbanekle.Show();
        }

        private void kurbanTipleriToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            KurbanTipleri KurbanTipleri = new KurbanTipleri();
            KurbanTipleri.MdiParent = this;
            KurbanTipleri.Show();
        }

        private void kurbanSilToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            KurbanSil KurbanSil = new KurbanSil();
            KurbanSil.MdiParent = this;
            KurbanSil.Show();
        }

        private void arşivleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DBYedekleme DBYedekleme = new DBYedekleme();
            //DBYedekleme.MdiParent = this;
            //DBYedekleme.Show();
        }

        private void onlineLisansGüncelleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OnlineLisans OnlineLisans = new OnlineLisans();
            OnlineLisans.MdiParent = this;
            OnlineLisans.Show();
        }

        private void müşteriListesiToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MusteriListesi MusteriListesi = new MusteriListesi();
            MusteriListesi.MdiParent = this;
            MusteriListesi.Show();
        }

        private void yeniFaturaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormYeniOdeme FormYeniOdeme = new FormYeniOdeme();
            FormYeniOdeme.MdiParent = this;
            FormYeniOdeme.Show();
        }

        private void kurbanListToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void yeniÖdemeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormYeniOdeme FormYeniOdeme = new FormYeniOdeme();
            FormYeniOdeme.MdiParent = this;
            FormYeniOdeme.Show();
        }

       

        private void teknikToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Teknik Teknik = new Teknik();
            Teknik.MdiParent = this;
            Teknik.Show();
        }

        private void ödemeİptalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OdemeIptal OdemeIptal = new OdemeIptal();
            OdemeIptal.MdiParent = this;
            OdemeIptal.Show();
        }



    }
}
