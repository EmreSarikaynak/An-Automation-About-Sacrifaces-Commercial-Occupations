using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Collections;
using System.Data.OleDb;
using Ms = Microsoft.Office.Interop.Excel;
using System.Reflection;
using System.Threading;


namespace KurbanYazilimi
{
    public partial class YeniKayit : Form
    {
        public YeniKayit()
        {
            InitializeComponent();
            
        }
        Fonksiyon system = new Fonksiyon();
        int gezebilecegisayfa = 0;
        String OIMusteriNo = "";
        private void btnMusteriKayit_Click(object sender, EventArgs e)
        {
            gezebilecegisayfa = 1;
            tabControl1.SelectedTab = tabPage2;
        }

        private void YeniKayit_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            progressBar1.Visible = false;
            btnMusteriKayit.Enabled = false;
            button2.Enabled = false;
            KurbanTipleriCek();
            try
            {
                cmbBosHisseSay.SelectedIndex = 0;
                cmbKurbanTip.SelectedIndex = 0;
                //button1.Text = cmbKurbanTip.SelectedItem.ToString() + " Grubu " + cmbBosHisseSay.SelectedItem.ToString() + " Hissesi Boş Olanlar";
            }
            catch (Exception)
            {
                //lblUyari.Text = "Sistemde Kayıtlı Kurban YOK";

            }
            btnOdeme.Enabled = false;
            button6.Enabled = false;
            
        }


        private void KurbanTipleriCek()
        {
            try
            {
                DataTable dt = system.GetDataTable("select * from KurbanTipGruplari order by Tipi");
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    DataRow dr = dt.Rows[i];
                    cmbKurbanTip.Items.Add(dr["Tipi"]);

                }
            }
            catch (Exception)
            {


            }


        }

        private void cmbKurbanTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Text = cmbKurbanTip.SelectedItem.ToString() + " Grubu "+cmbBosHisseSay.SelectedItem.ToString()+" Hissesi Boş Olanlar";
            btnTumListe.Text = cmbKurbanTip.SelectedItem.ToString() + " Grubu TÜM HİSSELER";



        }
        private void HisseListele()
        {



            try
            {

                DataTable dt = system.GetDataTable("select KurbanAdi,ID as 'Hisse No', HisseSirasi as 'Hissenin Sirasi', MusteriID as 'Musteri Ad Soyad' from MusHisseleri where KurbanAdi LIKE '%" + cmbKurbanTip.SelectedItem.ToString() + "%' and Status='false'  and KurbanAdi IN (select KurbanAdi from MusHisseleri where" +
                    " KurbanAdi LIKE '%" + cmbKurbanTip.SelectedItem.ToString() + "%' and Status='false' Group By KurbanAdi HAVING COUNT(*)=" + Int32.Parse(cmbBosHisseSay.SelectedItem.ToString()) + ") Order By ID");
                dataGridView1.DataSource = dt;

                lblUyari.Text = cmbKurbanTip.SelectedItem.ToString() + " grubunda " + cmbBosHisseSay.SelectedItem.ToString() + " hissesi boş olan " + dt.Rows.Count / Int32.Parse(cmbBosHisseSay.SelectedItem.ToString()) + " kurban bulunmaktadır.";

                // renklendirme

                for (int i = 1; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[1].Value.ToString() == dataGridView1.Rows[i - 1].Cells[1].Value.ToString())
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = dataGridView1.Rows[i - 1].DefaultCellStyle.BackColor;
                    }
                    else dataGridView1.Rows[i].DefaultCellStyle.BackColor = RenkDegistir(dataGridView1.Rows[i - 1].DefaultCellStyle.BackColor);

                }
            }
            catch (Exception w)
            {
                MessageBox.Show(w.ToString(), "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void TumHisseListele()
        {

            
                try
                {
                    DataTable dt = system.GetDataTable("select h.KurbanAdi, h.ID as 'Hisse No', h.HisseSirasi as 'Hissenin Sirasi', m.AdSoyad as 'Musteri Ad Soyad', h.Status " +
                       " from MusHisseleri as h left join Musteriler as m ON m.ID=h.MusteriID where  h.KurbanAdi LIKE '%" + cmbKurbanTip.SelectedItem.ToString() + "%' Order By h.ID");
                    dataGridView1.DataSource = dt;

                    DataTable dtBoslar = system.GetDataTable("select KurbanAdi, MusHisseleri.ID as 'Hisse No', HisseSirasi as 'Hissenin Sirasi', MusteriID as 'Musteri Ad Soyad' from MusHisseleri where KurbanAdi LIKE '%" + cmbKurbanTip.SelectedItem.ToString() + "%' and Status='false'");


                    lblUyari.Text = cmbKurbanTip.SelectedItem.ToString() + " Grubunda toplam " + dt.Rows.Count / 7 + " kurban ve " + dtBoslar.Rows.Count + " boş hisse bulunmaktadır.";

                     //renklendirme

                    for (int i = 1; i < dataGridView1.Rows.Count; i++)
                    {
                        if (i == 1)
                        {
                            if (dataGridView1.Rows[i - 1].Cells[5].Value.ToString().Equals("true"))
                            {
                                dataGridView1.Rows[i - 1].Cells[0].Value = true;
                            }
                            if (dataGridView1.Rows[i].Cells[5].Value.ToString().Equals("true"))
                            {
                                dataGridView1.Rows[i].Cells[0].Value = true;
                            }
                        }
                        else
                        {
                            if (dataGridView1.Rows[i].Cells[5].Value.ToString().Equals("true"))
                            {
                                dataGridView1.Rows[i].Cells[0].Value = true;
                            }
                        }

                        //else dataGridView1.Rows[i].DefaultCellStyle.BackColor = RenkDegistir(dataGridView1.Rows[i - 1].DefaultCellStyle.BackColor);
                        // RENKLENDIRME
                        if (dataGridView1.Rows[i].Cells[1].Value.ToString() == dataGridView1.Rows[i - 1].Cells[1].Value.ToString())
                        {
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = dataGridView1.Rows[i - 1].DefaultCellStyle.BackColor;
                        }
                        else dataGridView1.Rows[i].DefaultCellStyle.BackColor = RenkDegistir(dataGridView1.Rows[i - 1].DefaultCellStyle.BackColor);

                    }
                }
                catch (Exception w)
                {
                    MessageBox.Show(w.ToString(), "");
                }
                dataGridView1.Columns[2].Visible = false;
                dataGridView1.Columns[5].Visible = false;
            

        }
        private Color RenkDegistir(Color gelenrenk)
        {
            if (gelenrenk == Color.LightSteelBlue)
            {
                return Color.White;
            }
            else return Color.LightSteelBlue;
        }



        private void btnKaydet_Click(object sender, EventArgs e)
        {
            String KayitTar = System.DateTime.Now.ToShortDateString() + " "+System.DateTime.Now.ToShortTimeString();
            if (txtAdSoyad.Text != "")
            {
                if (SecilenHisselerIDs.Count > 0)
                {
                    system.Sorgu("INSERT INTO Musteriler(AdSoyad,EvNo, CepNo,Adres,Aciklama,Eposta,Fax,KayitTar) VALUES" +
                  "('" + txtAdSoyad.Text + "','" + txtEvTel.Text + "','" + txtCepTel.Text + "','" + txtAdres.Text + "','" + txtAciklama.Text + "','" + txtEposta.Text + "','" + txtFaxNo.Text + "','" + KayitTar + "')");
                    String MusteriID = system.GetDataCell("select ID from Musteriler where ID = (Select Max(ID) from Musteriler)").ToString();
                    String Uyari = "Müşteri Kayıt Tamamlandı. Müşteri No : " + MusteriID;
                    button6.Enabled = true;
                    btnKaydet.Enabled = false;
                    MessageBox.Show(Uyari, "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    for (int i = 0; i < SecilenHisselerIDs.Count; i++)
                    {

                        system.Sorgu("UPDATE MusHisseleri SET MusteriID = '" + MusteriID + "', Status='true', HisseKayitTar='" + KayitTar + "' WHERE ID = " + SecilenHisselerIDs[i] + "");

                    }
                    OIMusteriNo = MusteriID;
                }
                else
                {
                    button6.Enabled = false;
                    btnKaydet.Enabled = true;
                    MessageBox.Show("Hisse Seçilmedi ! Lütfen öncelikle hisseleri belirleyiniz !", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

                SecilenleriTemizle();
                btnMusteriKayit.Enabled = false;
                button2.Enabled = false;
                //
            }
            else
            {
                button6.Enabled = false;
                btnKaydet.Enabled = true;
                MessageBox.Show("Ad Soyad Boş Bırakılamaz", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        //private void btnTemizle_Click(object sender, EventArgs e)
        //{
        //    txtAciklama.Text = "";
        //    txtAdres.Text = "";
        //    txtAdSoyad.Text = "";
        //    txtCepTel.Text = "";
        //    txtEposta.Text = "";
        //    txtEvTel.Text = "";
        //    txtFaxNo.Text = "";
        //}

        ArrayList SecilenHisselerAds = new ArrayList();
        ArrayList SecilenHisselerIDs_SiraNo = new ArrayList();

        ArrayList SecilenHisselerIDs = new ArrayList();
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex == -1) return;
                // Secilenin Durumunu Sorgula 
                string Durum = system.GetDataCell("select Status from MusHisseleri Where ID=" + dataGridView1.SelectedRows[0].Cells[2].Value.ToString() + "");
                if (Durum.Equals("true"))
                {
                    notifyIcon1.Visible = true;
                    notifyIcon1.ShowBalloonTip(1000, "Test App",
                "The App has be moved to the tray.",
                ToolTipIcon.Info);
                    //MessageBox.Show("Müşterisi daha önceden belirlenmiştir !", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }
                if (e.ColumnIndex == 0)
                {
                    if (dataGridView1.Rows[e.RowIndex].Cells[0].Value == null)
                    {
                        dataGridView1.Rows[e.RowIndex].Cells[0].Value = true;

                    }
                    else
                    {
                        bool bChecked = (bool)dataGridView1.Rows[e.RowIndex].Cells[0].Value;
                        dataGridView1.Rows[e.RowIndex].Cells[0].Value = !bChecked;



                    }
                    if ((bool)dataGridView1.Rows[e.RowIndex].Cells[0].Value == true)
                    {
                        SecilenHisselerIDs.Add(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
                        SecilenHisselerAds.Add(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                        SecilenHisselerIDs_SiraNo.Add(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
                    }
                    else
                    {
                        SecilenHisselerAds.Remove(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                        SecilenHisselerIDs.Remove(dataGridView1.SelectedRows[0].Cells[2].Value.ToString());
                        SecilenHisselerIDs_SiraNo.Remove(dataGridView1.SelectedRows[0].Cells[3].Value.ToString());
                    }


                }
                listBox1.Items.Clear();
                for (int i = 0; i < SecilenHisselerAds.Count; i++)
                {
                    listBox1.Items.Add(SecilenHisselerAds[i] + " Kurbanında " + SecilenHisselerIDs_SiraNo[i] + ". Hisse");


                }

            }

            catch (Exception)
            {


            }
            if (listBox1.Items.Count > 0)
            {
                btnMusteriKayit.Enabled = true;
                button2.Enabled = true;
            }
            else
            {
                btnMusteriKayit.Enabled = false;
                button2.Enabled = false;
            }

        }

        private void cmbBosHisseSay_SelectedIndexChanged(object sender, EventArgs e)
        {
            button1.Text = cmbKurbanTip.SelectedItem.ToString() + " Grubu " + cmbBosHisseSay.SelectedItem.ToString() + " Hissesi Boş Olanlar";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                HisseListele();
                SecilenleriTemizle();
            }
            catch (Exception)
            {


            }

        }

        //Thread t1;
        //ThreadStart ts1;
        private void btnTumListe_Click(object sender, EventArgs e)
        {
            SecilenleriTemizle();
            try
            {


                //ts1 = new ThreadStart(TumHisseListele);
                //t1 = new Thread(ts1);
                //t1.Start();
                TumHisseListele();
            }
            catch (Exception)
            {


            }

        }
        private void SecilenleriTemizle()
        {

            SecilenHisselerAds.Clear();
            SecilenHisselerIDs.Clear();
            SecilenHisselerIDs_SiraNo.Clear();
            listBox1.Items.Clear();
        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            //tabControl1.SelectedTab = tabPage1;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void btnHisselereDon_Click(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = system.GetDataTable("select * from MusHisseleri where ID=0");
            }
            catch (Exception)
            {


            }
            gezebilecegisayfa = 0;
            tabControl1.SelectedIndex = 0;
            button6.Enabled = false;
            btnKaydet.Enabled = true;

            button2.Enabled = false;
            btnMusteriKayit.Enabled = false;
            txtAciklama.Text = "";
            txtAdres.Text = "";
            txtAdSoyad.Text = "";
            txtCepTel.Text = "";
            txtEposta.Text = "";
            txtEvTel.Text = "";
            txtFaxNo.Text = "";
        }

        private void tabControl1_Selecting(object sender, TabControlCancelEventArgs e)
        {
            TabControl tc = sender as TabControl;
            if (!(gezebilecegisayfa == tabControl1.Controls.IndexOf(e.TabPage)))
            {
                e.Cancel = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            gezebilecegisayfa = 2;
            tabControl1.SelectedIndex = 2;
            btnOdeme.Enabled = false;
        }

        private void btnHisselereDon2_Click(object sender, EventArgs e)
        {
            gezebilecegisayfa = 0;
            tabControl1.SelectedIndex = 0;
            try
            {
                dataGridView1.DataSource = system.GetDataTable("select * from MusHisseleri where ID=0");
            }
            catch (Exception)
            {


            }
            button6.Enabled = false;
            btnKaydet.Enabled = true;
            dataGridView2.DataSource = system.GetDataTable("select * from MusHisseleri where ID=0");
            dataGridView3.DataSource = system.GetDataTable("select * from MusHisseleri where ID=0");
            txtAdSoyadAra.Text = "";
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAdSoyadAra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView2.DataSource = system.GetDataTable("select ID as Musteri_No, AdSoyad as Ad_Soyad, CepNo as Cep_No from Musteriler where AdSoyad LIKE '%" + txtAdSoyadAra.Text + "%'");
                dataGridView2.ClearSelection();

                //dataGridView3.DataSource = system.GetDataTable("select KurbanAdi as 'Kurban Adı',HisseSirasi as 'Hisse Sırası',  YapilanOdeme as 'Yapılan Ödeme', Toplam from MusHisseleri where MusteriID=" + dataGridView2.SelectedRows[0].Cells[0].Value.ToString() + "");
                MevcutMusSecildi = false;
                lblSecilenMusteriAdSoyad.Text = "";
                lblSecilenMusteriCep.Text = "";

            }
            catch (Exception)
            {


            }
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                dataGridView3.DataSource = system.GetDataTable("select KurbanAdi as 'Kurban Adı',HisseSirasi as 'Hisse Sırası',  YapilanOdeme as 'Yapılan Ödeme', Toplam from MusHisseleri where MusteriID=" + dataGridView2.SelectedRows[0].Cells[0].Value.ToString() + "");
                dataGridView2.DataSource = system.GetDataTable("select ID as Musteri_No, AdSoyad as Ad_Soyad, CepNo as Cep_No from Musteriler where ID=" + dataGridView2.SelectedRows[0].Cells[0].Value.ToString() + "");
                lblSecilenMusteriAdSoyad.Text = system.GetDataCell("select AdSoyad from Musteriler Where ID=" + dataGridView2.SelectedRows[0].Cells[0].Value.ToString() + "").ToString();
                lblSecilenMusteriCep.Text = system.GetDataCell("select CepNo from Musteriler Where ID=" + dataGridView2.SelectedRows[0].Cells[0].Value.ToString() + "").ToString();
                MevcutMusSecildi = true;
                button5.Enabled = true;
            }
            catch (Exception)
            {
                MevcutMusSecildi = false;
            }
        }
        private Boolean MevcutMusSecildi = false;
        private void button5_Click(object sender, EventArgs e)
        {
            String KayitTar = System.DateTime.Now.ToShortDateString() + " " + System.DateTime.Now.ToShortTimeString();
            try
            {
                String SeciliMusteriID = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                if (MevcutMusSecildi == true)
                {
                    if (SecilenHisselerIDs.Count > 0)
                    {

                        for (int i = 0; i < SecilenHisselerIDs.Count; i++)
                        {
                            system.Sorgu("UPDATE MusHisseleri SET MusteriID = '" + SeciliMusteriID + "', Status='true',HisseKayitTar='" + KayitTar + "' WHERE ID = " + SecilenHisselerIDs[i] + "");

                        }
                        MessageBox.Show("Hisse Kaydı Tamamlandı!", "Bilgi", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        OIMusteriNo = SeciliMusteriID;
                        lblSecilenMusteriAdSoyad.Text = "";
                        lblSecilenMusteriCep.Text = "";
                        //dataGridView2.DataSource = system.GetDataTable("select ID as Musteri_No, AdSoyad as Ad_Soyad, CepNo as Cep_No from Musteriler where ID=0");
                        dataGridView3.DataSource = system.GetDataTable("select KurbanAdi as 'Kurban Adı',HisseSirasi as 'Hisse Sırası',  YapilanOdeme as 'Yapılan Ödeme', Toplam from MusHisseleri where MusteriID=" + SeciliMusteriID);
                        btnMusteriKayit.Enabled = false;
                        button2.Enabled = false;
                        btnOdeme.Enabled = true;
                        button5.Enabled = false;
                    }
                    else
                    {
                        MessageBox.Show("Hisse Seçilmedi ! Lütfen öncelikle hisseleri belirleyiniz !", "Uyari", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        btnOdeme.Enabled = false;
                        button5.Enabled = true;
                    }


                    SecilenleriTemizle();
                    MevcutMusSecildi = false;

                    //
                }
                else
                {
                    MessageBox.Show("Müşteri Seçilmedi", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    btnOdeme.Enabled = false;
                    button5.Enabled = true;
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Müşteri Seçilmedi", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                btnOdeme.Enabled = false;
                button5.Enabled = true;
            }

        }

        private void btnOdeme_Click(object sender, EventArgs e)
        {
            gezebilecegisayfa = 3;
            tabControl1.SelectedIndex = 3;
            dataGV_4Review();
            button5.Enabled = true;
            btnOdemeyiYap.Enabled = false;
            dataGridView2.DataSource = system.GetDataTable("select * from MusHisseleri where ID=0");
            dataGridView3.DataSource = system.GetDataTable("select * from MusHisseleri where ID=0");
            txtAdSoyadAra.Text = "";
        }


        private void button6_Click(object sender, EventArgs e)
        {
            gezebilecegisayfa = 3;
            tabControl1.SelectedIndex = 3;
            dataGV_4Review();
            btnOdemeyiYap.Enabled = false;


            txtAciklama.Text = "";
            txtAdres.Text = "";
            txtAdSoyad.Text = "";
            txtCepTel.Text = "";
            txtEposta.Text = "";
            txtEvTel.Text = "";
            txtFaxNo.Text = "";
        }

        private void button7_Click(object sender, EventArgs e)
        {
            gezebilecegisayfa = 0;
            tabControl1.SelectedIndex = 0;
            try
            {
                dataGridView1.DataSource = system.GetDataTable("select * from MusHisseleri where ID=0");
                dataGridView4.DataSource = system.GetDataTable("select * from MusHisseleri where ID=0");
            }
            catch (Exception)
            {


            }
            button6.Enabled = false;
            btnKaydet.Enabled = true;
        }
        public void dataGV_4Review() {
            try
            {
                DataRow drMusteri = system.GetDataRow("select * from Musteriler where ID=" + OIMusteriNo + "");
                if (drMusteri != null)
                {

                    txtOIMusteriAdSoyad.Text = drMusteri["AdSoyad"].ToString();
                    txtOICepTel.Text = drMusteri["CepNo"].ToString();
                    SCMusteriAdres = drMusteri["Adres"].ToString();
                    SCMusteriEposta = drMusteri["Eposta"].ToString();
                    lblUyari.Text = "";
                    //MusteriID = drMusteri["ID"].ToString();
                    dataGridView4.DataSource = system.GetDataTable("select ID, KurbanAdi as 'Kurban Adı', HisseSirasi as 'Hisse Sırası',HisseKayitTar as 'Hisse Kayit Tarihi',YapilanOdeme as 'Yapılan Ödeme', Toplam as 'Hisse Fiyatı' from MusHisseleri where MusteriID=" + OIMusteriNo + "");
                    dataGridView4.Columns[0].Visible = false;
                    dataGridView4.ClearSelection();

                }
                else
                {
                    lblUyari.Text = "Müşteri Bulunamadı !";
                    //txtClean();
                }
            }
            catch (Exception)
            {

                lblUyari.Text = "Müşteri Bulunamadı !";
                //txtClean();
            }
        
        }

        private void btnExceleaktar_Click(object sender, EventArgs e)
        {
            String KayıtYapılacakDizin = "";
            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                KayıtYapılacakDizin = folderBrowserDialog1.SelectedPath;


                progressBar1.Visible = true;

                Ms.Application exceluygulama = new Ms.Application();
                Ms.Workbook ekitap = exceluygulama.Workbooks.Add(true);//bitane kitap
                //exceluygulama.Visible = true;//sayfa göster
                for (int z=cmbKurbanTip.Items.Count-1; z>-1 ; z--)
                {

                    Ms.Worksheet tablo = (Ms.Worksheet)ekitap.Worksheets.Add();//kitaptan bir sayfa türettik
                    tablo.Name = cmbKurbanTip.Items[z].ToString() + " Grubu";
                    DataTable dt = system.GetDataTable("select h.KurbanAdi, h.ID as 'Hisse No', h.HisseSirasi as 'Hissenin Sirasi', m.AdSoyad as 'Musteri Ad Soyad', h.Status, " +
                          "m.CepNo, h.YapilanOdeme, h.Toplam, m.Adres, m.Aciklama from MusHisseleri as h left join Musteriler as m ON m.ID=h.MusteriID where  h.KurbanAdi LIKE '%" + cmbKurbanTip.Items[z].ToString() + "%' Order By h.ID");
                    progressBar1.Value = 0;
                    progressBar1.Maximum = dt.Rows.Count + 1;
                    int sayac = 1;
                    int satir = 1;
                    //int sutun = 1;
                    tablo.Cells[1, 1] = "KURBAN ADI";
                    tablo.Cells[1, 2] = "HİSSE SIRASI";
                    tablo.Cells[1, 3] = "MÜŞTERİ AD-SOYAD";
                    tablo.Cells[1, 4] = "YAPILAN ÖDEME";
                    tablo.Cells[1, 5] = "TOPLAM";
                    tablo.Cells[1, 6] = "CEP NO             ";
                    tablo.Cells[1, 7] = "ADRES                     ";
                    tablo.Cells[1, 8] = "AÇIKLAMA                                  ";
                    tablo.get_Range("a1").Columns.AutoFit();
                    tablo.get_Range("A1").Font.Bold = true;
                    tablo.get_Range("b1").Columns.AutoFit();
                    tablo.get_Range("B1").Font.Bold = true;
                    tablo.get_Range("C1").Columns.AutoFit();
                    tablo.get_Range("C1").Font.Bold = true;
                    tablo.get_Range("D1").Columns.AutoFit();
                    tablo.get_Range("D1").Font.Bold = true;
                    tablo.get_Range("E1").Columns.AutoFit();
                    tablo.get_Range("E1").Font.Bold = true;
                    tablo.get_Range("F1").Columns.AutoFit();
                    tablo.get_Range("F1").Font.Bold = true;
                    tablo.get_Range("G1").Columns.AutoFit();
                    tablo.get_Range("G1").Font.Bold = true;
                    tablo.get_Range("H1").Columns.AutoFit();
                    tablo.get_Range("H1").Font.Bold = true;
                    tablo.get_Range("I1").Columns.AutoFit();
                    tablo.get_Range("I1").Font.Bold = true;
                    for (int i = 0; i < dt.Rows.Count; i++)
                    {
                        progressBar1.Value++;
                        tablo.Cells.RowHeight = 20;

                        satir = i + 2;
                        DataRow dr = dt.Rows[i];
                        tablo.Cells[satir, 1] = dr["KurbanAdi"];
                        tablo.get_Range("A" + satir).Font.Bold = true;
                        //tablo.Range[tablo.Cells[i + 1, 1]].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                        //tablo.Range[tablo.Cells[i + 1, 1]].Orientation = Microsoft.Office.Interop.Excel.XlOrientation.xlUpward;

                        tablo.Cells[satir, 2] = dr["'Hissenin Sirasi'"];
                        tablo.get_Range("B" + satir).HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;

                        tablo.Cells[satir, 3] = dr["'Musteri Ad Soyad'"];
                        //tablo.get_Range("c" + satir).Columns.AutoFit();

                        tablo.Cells[satir, 4] = dr["YapilanOdeme"];
                        tablo.Cells[satir, 5] = dr["Toplam"];
                        tablo.Cells[satir, 6] = dr["CepNo"];
                        tablo.Cells[satir, 7] = dr["Adres"];
                        tablo.Cells[satir, 8] = dr["Aciklama"];

                        if (sayac != 7) // önceki satırla birüleştir
                        {

                            tablo.Range[tablo.Cells[satir, 1], tablo.Cells[satir + 1, 1]].Merge();
                            tablo.Range[tablo.Cells[satir, 1], tablo.Cells[satir + 1, 1]].Orientation = Microsoft.Office.Interop.Excel.XlOrientation.xlUpward;
                            tablo.Range[tablo.Cells[satir, 1], tablo.Cells[satir + 1, 1]].HorizontalAlignment = Microsoft.Office.Interop.Excel.XlHAlign.xlHAlignCenter;
                            tablo.Range[tablo.Cells[satir, 1], tablo.Cells[satir + 1, 1]].VerticalAlignment = Microsoft.Office.Interop.Excel.XlVAlign.xlVAlignCenter;

                            sayac++;

                        }
                        else
                        {
                            sayac = 1;
                        }




                    }
                    // RENKLER AYARLA
                    tablo.get_Range("a1", "h" + satir).Borders.Weight = 2;
                    //Ms.Worksheet tablo2 = (Ms.Worksheet)ekitap.Worksheets[2];
                    //Ms.Worksheet tablo2 = (Ms.Worksheet)ekitap.Worksheets.Add();
                }



                ekitap.SaveAs(KayıtYapılacakDizin+"\\KurbanListesi_v.1.1.xlsx");
                //ekitap.Close(true, Missing.Value, Missing.Value);
                exceluygulama.Quit();
                progressBar1.Visible = false;
            }
        }
        String SCHisseNo = "0", SCYapilanOdeme = "0", SCToplamOdenmesiBeklenen = "0";
        String SCMusteriEposta = "";
        String SCMusteriAdres = "";
        
        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SCHisseNo = dataGridView4.SelectedRows[0].Cells[0].Value.ToString();
            SCYapilanOdeme = dataGridView4.SelectedRows[0].Cells[4].Value.ToString();
            SCToplamOdenmesiBeklenen = dataGridView4.SelectedRows[0].Cells[5].Value.ToString();
            txtOIHisseNo.Text = SCHisseNo;
            txtOIToplamOdenen.Text = SCYapilanOdeme;
            txtOIBeklenenOdeme.Text = SCToplamOdenmesiBeklenen;
            txtOIKalanOdeme.Text = (Int32.Parse(SCToplamOdenmesiBeklenen) - Int32.Parse(SCYapilanOdeme)).ToString();
            if ((Int32.Parse(SCToplamOdenmesiBeklenen) - Int32.Parse(SCYapilanOdeme))<1)
            {
                btnOdemeyiYap.Enabled = false;
            }
            else btnOdemeyiYap.Enabled = true;
        }

        private void btnOdemeyiYap_Click(object sender, EventArgs e)
        {
            try
            {
                if (Int32.Parse(txtOIKalanOdeme.Text) < Int32.Parse(txtOIOdemeMiktari.Text))
                {
                    MessageBox.Show("Ödeme Miktarı, Kalan Ödemeden Daha Az Olmalıdır !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {

                    String Uyari = dataGridView4.SelectedRows[0].Cells[1].Value.ToString() + " Kurbanı " + dataGridView4.SelectedRows[0].Cells[2].Value.ToString() + ". Hissesi için " + txtOIMusteriAdSoyad.Text + " adına " + txtOIOdemeMiktari.Text + " TL Ödeme Yapmak İstiyor Musunuz ?";

                    DialogResult verilencevap = MessageBox.Show(Uyari, "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (verilencevap == DialogResult.Yes)
                    {
                        //system.Sorgu("delete from Musteriler where ID=" + txtMusteriNo.Text + "");
                        String HisseFiyati = dataGridView4.SelectedRows[0].Cells[5].Value.ToString();
                        int HisseninOncekiOdemesi = Int32.Parse(SCYapilanOdeme);
                        int Odenecek = Int32.Parse(txtOIOdemeMiktari.Text);
                        int VTYazOdenen = HisseninOncekiOdemesi + Odenecek;
                        int KalanOdeme = Int32.Parse(HisseFiyati) - VTYazOdenen;
                        system.Sorgu("UPDATE MusHisseleri SET YapilanOdeme=" + VTYazOdenen.ToString() + "  WHERE ID=" + Int32.Parse(SCHisseNo));
                        // Odeme Kayitlarını Da ekle
                        String KayitTar = System.DateTime.Now.ToShortDateString() + " " + System.DateTime.Now.ToShortTimeString();
                        system.Sorgu("insert into OdemeKayitlari(HisseNo,Tarih,Saat,Miktar,MusteriID,MusteriAdSoyad,KurbanAdi,HisseSirasi,Aciklama) values('" + SCHisseNo + "','" + System.DateTime.Now.ToShortDateString() + "','" + System.DateTime.Now.ToShortTimeString() + "','" + txtOIOdemeMiktari.Text + "','" + OIMusteriNo + "','" + txtOIMusteriAdSoyad.Text + "','" + dataGridView4.SelectedRows[0].Cells[1].Value.ToString() + "','" + dataGridView4.SelectedRows[0].Cells[2].Value.ToString() + "','" + txtOIFaturaAciklamasi.Text + "')");
                        DialogResult CiktiAlacagim = MessageBox.Show("Ödeme Başarıyla Yapıldı. Fatura Çıktısı Almak İstiyor Musunuz ?", "Bildirim-Sorgu", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (CiktiAlacagim == DialogResult.Yes)
                        {
                            String FaturaNo = system.GetDataCell("select ID from OdemeKayitlari where ID= (select max(ID) from OdemeKayitlari)");
                            Yazdir(system.GetDataTable("select * from MusHisseleri where MusteriID=" + OIMusteriNo + ""), txtOIMusteriAdSoyad.Text, OIMusteriNo, txtOICepTel.Text, SCMusteriEposta, SCMusteriAdres, FaturaNo, dataGridView4.SelectedRows[0].Cells[1].Value.ToString(), dataGridView4.SelectedRows[0].Cells[2].Value.ToString(), txtOIOdemeMiktari.Text, KalanOdeme.ToString(), txtOIFaturaAciklamasi.Text);
                        }
                        btnOdemeyiYap.Enabled = false;

                    }
                    else
                    {

                    }
                }
            }
            catch (Exception)
            {
                btnOdemeyiYap.Enabled = false;
                MessageBox.Show("Bir Hata İle Karşılaşıldı. Lütfen Bilgileri Kontrol Ediniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            dataGridView4.DataSource = system.GetDataTable("select ID, KurbanAdi as 'Kurban Adı', HisseSirasi as 'Hisse Sırası',HisseKayitTar as 'Hisse Kayit Tarihi',YapilanOdeme as 'Yapılan Ödeme', Toplam as 'Hisse Fiyatı' from MusHisseleri where MusteriID=" + OIMusteriNo + "");
            dataGridView4.Columns[0].Visible = false;
            dataGridView4.ClearSelection();
            txtOIBeklenenOdeme.Text = "";
            txtOIHisseNo.Text = "";
            txtOIOdemeMiktari.Text = "";
            txtOIToplamOdenen.Text = "";
            txtOIFaturaAciklamasi.Text = "";
            txtOIKalanOdeme.Text = "";
        }


        private void Yazdir(DataTable dtHisseler,String MuseriAdi, String MuseriNo, String CepTel, String Eposta, String Adres, String FaturaNo, String KurbanAdi, String HisseSirasi, String OdenenTutar, String KalanTutar, String FaturaAciklamasi)
        {

            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("tr-TR");
            Microsoft.Office.Interop.Excel._Application xlApp = new Microsoft.Office.Interop.Excel.Application();
            xlApp.Visible = false; // Excel dosyasını, kullanıcının düzenleme yapabilmesi için görünür yapıyor
            Microsoft.Office.Interop.Excel._Workbook xlWorkbook = xlApp.Workbooks.Open(Application.StartupPath + "\\tool\\faturaformat.xlsx");
            Microsoft.Office.Interop.Excel._Worksheet xlWorksheet = xlWorkbook.Worksheets[1];
            xlWorksheet.Cells[2, 5] = DateTime.Now.Day.ToString() + "-" + DateTime.Now.Month.ToString() + "-" + DateTime.Now.Year.ToString();  // Günün Tarih
            xlWorksheet.Cells[5, 2] = MuseriAdi; // Müşteri adı
            xlWorksheet.Cells[6, 2] = MuseriNo;
            xlWorksheet.Cells[7, 2] = CepTel;
            xlWorksheet.Cells[8, 2] = Adres;
            xlWorksheet.Cells[9, 2] = Eposta;
            xlWorksheet.Cells[12, 2] = FaturaNo;
            xlWorksheet.Cells[13, 2] = KurbanAdi;
            xlWorksheet.Cells[14, 2] = HisseSirasi;
            xlWorksheet.Cells[15, 2] = OdenenTutar;
            xlWorksheet.Cells[16, 2] = KalanTutar;
            xlWorksheet.Cells[17, 2] = FaturaAciklamasi;
            for (int i = 0; i < dtHisseler.Rows.Count; i++)
            {
                DataRow drHisse = dtHisseler.Rows[i];
                xlWorksheet.Cells[21 + i, 1] = drHisse["KurbanAdi"].ToString();
                xlWorksheet.get_Range("A" + (21 + i).ToString()).Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                xlWorksheet.Cells[21 + i, 2] = drHisse["HisseSirasi"].ToString();
                xlWorksheet.get_Range("B" + (21 + i).ToString()).Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                xlWorksheet.Cells[21 + i, 3] = drHisse["YapilanOdeme"].ToString();
                xlWorksheet.get_Range("C" + (21 + i).ToString()).Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                int Kalan = Int32.Parse(drHisse["Toplam"].ToString()) - Int32.Parse(drHisse["YapilanOdeme"].ToString());
                xlWorksheet.Cells[21 + i, 4] = Kalan.ToString();
                xlWorksheet.get_Range("D" + (21 + i).ToString()).Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
                xlWorksheet.get_Range("E" + (21 + i).ToString()).Borders.LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            }
            //xlWorksheet.Range["A25"].Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Microsoft.Office.Interop.Excel.XlLineStyle.xlContinuous;
            //xlWorksheet.PageSetup.LeftFooter = "Önemli Not : Vekalet, Kurban Hisse Bedeli Tamamen Ödendiğinde Alınacaktır."
            //    + "\nKurbanınız Hisse Adedince (Kemikli Olarak) Terazi İle Tartılıp, Eşit Olarak Teslim Edilir."
            //    + "\nHissenizi Teslim Alırken ÖDENDİ MAKBUZUNUZU Mutlaka Getiriniz."
            //    + "\nHisseniz Hazır Olduğunda Size Haber Verilecektir."
            //    + "\nHissenizi Almak İçin Poşet Getirmeyiniz."
            //    + "\nKesim Ve Tanzim Bedeli Hisse Fiyatına Dahildir.";
            AnaForm.ActiveForm.WindowState = FormWindowState.Minimized;
            xlApp.Dialogs[Microsoft.Office.Interop.Excel.XlBuiltInDialog.xlDialogPrint].Show();
            xlWorkbook.Close(false, Missing.Value, Missing.Value);
            xlApp.Quit();


        }


    }
}
