using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading;

namespace KurbanYazilimi
{
    public partial class FormKurbanEkleme : Form
    {
        public FormKurbanEkleme()
        {
            InitializeComponent();
        }
        Fonksiyon system = new Fonksiyon();
        //Thread t1;
        //ThreadStart ts1;
        private void button1_Click(object sender, EventArgs e)
        {
            
            //ts1 = new ThreadStart(btnKaydetMetot);
            //t1 = new Thread(ts1);
            //t1.Start();


            btnKaydetMetot();


        }
        public void btnKaydetMetot()
        {
            lock (this)
            {
                if (cmbKurbanTipi.SelectedItem.ToString() != "")
                {
                    String KurbanTipiFiyati = system.GetDataCell("select HisseFiyati from KurbanTipGruplari where Tipi='" + cmbKurbanTipi.SelectedItem.ToString() + "'");
                    // Sistemde daha öncesinden kayıtlı var mı 
                    DataTable dtKurbanlar = system.GetDataTable("SELECT * FROM MusHisseleri where KurbanAdi LIKE '%" + cmbKurbanTipi.SelectedItem.ToString() + "%'");
                    int ilkSayi = dtKurbanlar.Rows.Count / 7;
                    progressBar1.Maximum = Decimal.ToInt32(nmKurbanSay.Value);
                    for (int i = 1; i < nmKurbanSay.Value + 1; i++)
                    {
                        progressBar1.Value = i;
                        int siraNo = ilkSayi + i;
                        // system.Sorgu("INSERT INTO Kurbanlar(Tipi,KurbanAdi) VALUES" +
                        //"('" + cmbKurbanTipi.SelectedItem.ToString() + "','" + cmbKurbanTipi.SelectedItem.ToString() + siraNo + "')");

                        for (int k = 0; k < 7; k++)
                        {
                            system.Sorgu("INSERT INTO MusHisseleri(KurbanAdi,Status,HisseSirasi,YapilanOdeme,Toplam) VALUES" +
                                "('" + cmbKurbanTipi.SelectedItem.ToString() + siraNo + "','false','" + (k + 1) + "','0','" + KurbanTipiFiyati + "')");

                        }

                    }

                    String Uyari = cmbKurbanTipi.SelectedItem.ToString() + " Tipi " + nmKurbanSay.Value + " adet Kurban Kaydedildi.";
                    MessageBox.Show(Uyari, "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    lblFiyat.Text = "";
                    lblKurbanSay.Text = "";
                    progressBar1.Value = 0;
                }
                else
                {
                    MessageBox.Show("Kurban Tipi Seçmediniz !", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }

        }

        private void FormKurbanEkleme_Load(object sender, EventArgs e)
        {
            System.Windows.Forms.Control.CheckForIllegalCrossThreadCalls = false;
            KurbanTipleriCek();
        }
        private void KurbanTipleriCek()
        {

            DataTable dt = system.GetDataTable("select * from KurbanTipGruplari Order by Tipi");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                cmbKurbanTipi.Items.Add(dr["Tipi"]);
            }
        }

        private void cmbKurbanTipi_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Random sayi = new Random();
            //int sira = sayi.Next(1, 4);
            //pictureBox1.Load("..\\..\\images/cow-"+sira.ToString()+".png");
            lblFiyat.Text = system.GetDataCell("select HisseFiyati from KurbanTipGruplari where Tipi='" + cmbKurbanTipi.SelectedItem.ToString() + "'").ToString();
            DataTable dtKurbanlar = system.GetDataTable("SELECT * FROM MusHisseleri where KurbanAdi LIKE '%" + cmbKurbanTipi.SelectedItem.ToString() + "%'");
            int TiptekiKurbanSay = dtKurbanlar.Rows.Count / 7;
            lblKurbanSay.Text = "Mevcut Kurban Sayısı : " + TiptekiKurbanSay;
        }
    }
}
