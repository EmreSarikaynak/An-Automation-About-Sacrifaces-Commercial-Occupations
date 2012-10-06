using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Drawing.Printing;
using System.IO;
using Excel = Microsoft.Office.Interop.Excel;
using System.Reflection;

namespace KurbanYazilimi
{
    public partial class FormYeniOdeme : Form
    {
        Fonksiyon system = new Fonksiyon();
        String SCHisseNo="0", SCYapilanOdeme="0", SCToplamOdenmesiBeklenen="0";
        String SCMusteriEposta = "";
        String SCMusteriAdres = "";
        public FormYeniOdeme()
        {
            InitializeComponent();
        }
        
       


        private void Yazdir(DataTable dtHisseler,String MuseriAdi, String MuseriNo, String CepTel, String Eposta, String Adres, String FaturaNo, String KurbanAdi, String HisseSirasi, String OdenenTutar, String KalanTutar, String FaturaAciklamasi) {

            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("tr-TR");
            Excel._Application xlApp = new Excel.Application();
            xlApp.Visible = false; // Excel dosyasını, kullanıcının düzenleme yapabilmesi için görünür yapıyor
            Excel._Workbook xlWorkbook = xlApp.Workbooks.Open(Application.StartupPath+"\\tool\\faturaformat.xlsx");
            Excel._Worksheet xlWorksheet = xlWorkbook.Worksheets[1];
            xlWorksheet.Cells[2, 5] = DateTime.Now.Day.ToString()+"-"+DateTime.Now.Month.ToString()+"-"+DateTime.Now.Year.ToString() ;  // Günün Tarih
            xlWorksheet.Cells[5,2] = MuseriAdi; // Müşteri adı
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
                xlWorksheet.Cells[21+i, 1] = drHisse["KurbanAdi"].ToString();
                xlWorksheet.get_Range("A" + (21 + i).ToString()).Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                xlWorksheet.Cells[21+i, 2] = drHisse["HisseSirasi"].ToString();
                xlWorksheet.get_Range("B" + (21 + i).ToString()).Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                xlWorksheet.Cells[21+i, 3] = drHisse["YapilanOdeme"].ToString();
                xlWorksheet.get_Range("C" + (21 + i).ToString()).Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                int Kalan = Int32.Parse(drHisse["Toplam"].ToString()) - Int32.Parse(drHisse["YapilanOdeme"].ToString());
                xlWorksheet.Cells[21 + i, 4] = Kalan.ToString();
                xlWorksheet.get_Range("D" + (21 + i).ToString()).Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
                xlWorksheet.get_Range("E" + (21 + i).ToString()).Borders.LineStyle = Excel.XlLineStyle.xlContinuous;
            }
            //xlWorksheet.Range["A25"].Borders[Microsoft.Office.Interop.Excel.XlBordersIndex.xlEdgeBottom].LineStyle = Excel.XlLineStyle.xlContinuous;
    //        xlWorksheet.PageSetup.LeftFooter = "Önemli Not : Vekalet, Kurban Hisse Bedeli Tamamen Ödendiğinde Alınacaktır."
    //+ "\nKurbanınız Hisse Adedince (Kemikli Olarak) Terazi İle Tartılıp, Eşit Olarak Teslim Edilir."
    //+ "\nHissenizi Teslim Alırken ÖDENDİ MAKBUZUNUZU Mutlaka Getiriniz."
    //+ "\nHisseniz Hazır Olduğunda Size Haber Verilecektir."
    //+ "\nHissenizi Almak İçin Poşet Getirmeyiniz."
    //+ "\nKesim Ve Tanzim Bedeli Hisse Fiyatına Dahildir.";
            AnaForm.ActiveForm.WindowState = FormWindowState.Minimized; 
            xlApp.Dialogs[Excel.XlBuiltInDialog.xlDialogPrint].Show(); 
            xlWorkbook.Close(false, Missing.Value, Missing.Value);
            xlApp.Quit(); 
        }

        private void FormYeniOdeme_Load(object sender, EventArgs e)
        {
            btnOdemeyiYap.Enabled = false;
        }
        

        private void btnMusteriBul_Click(object sender, EventArgs e)
        {
            String MusteriID = null;
            if (txtMusteriNoAra.Text.Equals(""))
            {
                lblUyari.Text = "Müşteri Bulunamadı !";
                txtClean();
                btnOdemeyiYap.Enabled = false;
                dataGridView1.DataSource = system.GetDataTable("select ID, KurbanAdi as 'Kurban Adı', HisseSirasi as 'Hisse Sırası',HisseKayitTar as 'Hisse Kayit Tarihi',YapilanOdeme as 'Yapılan Ödeme', Toplam as 'Hisse Fiyatı' from MusHisseleri where MusteriID=-1");
            }
            else
            {
                try
                {
                    DataRow drMusteri = system.GetDataRow("select * from Musteriler where ID=" + txtMusteriNoAra.Text + "");
                    if (drMusteri != null)
                    {

                        txtAdSoyad.Text = drMusteri["AdSoyad"].ToString();
                        txtCepTel.Text = drMusteri["CepNo"].ToString();
                        SCMusteriAdres = drMusteri["Adres"].ToString();
                        SCMusteriEposta = drMusteri["Eposta"].ToString();
                        lblUyari.Text = "";
                        MusteriID = drMusteri["ID"].ToString();
                        dataGridView1.DataSource = system.GetDataTable("select ID, KurbanAdi as 'Kurban Adı', HisseSirasi as 'Hisse Sırası',HisseKayitTar as 'Hisse Kayit Tarihi',YapilanOdeme as 'Yapılan Ödeme', Toplam as 'Hisse Fiyatı' from MusHisseleri where MusteriID=" + MusteriID + "");
                        dataGridView1.Columns[0].Visible = false;
                        btnOdemeyiYap.Enabled = true;
                        
                    }
                    else
                    {
                        lblUyari.Text = "Müşteri Bulunamadı !";
                        txtClean();
                        btnOdemeyiYap.Enabled = false;
                        dataGridView1.DataSource = system.GetDataTable("select ID, KurbanAdi as 'Kurban Adı', HisseSirasi as 'Hisse Sırası',HisseKayitTar as 'Hisse Kayit Tarihi',YapilanOdeme as 'Yapılan Ödeme', Toplam as 'Hisse Fiyatı' from MusHisseleri where MusteriID=-1");
                    }
                }
                catch (Exception)
                {

                    lblUyari.Text = "Müşteri Bulunamadı !";
                    txtClean();
                    btnOdemeyiYap.Enabled = false;
                    dataGridView1.DataSource = system.GetDataTable("select ID, KurbanAdi as 'Kurban Adı', HisseSirasi as 'Hisse Sırası',HisseKayitTar as 'Hisse Kayit Tarihi',YapilanOdeme as 'Yapılan Ödeme', Toplam as 'Hisse Fiyatı' from MusHisseleri where MusteriID=-1");
                }
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            SCHisseNo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            SCYapilanOdeme = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            SCToplamOdenmesiBeklenen = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            txtHisseNo.Text = SCHisseNo;
            txtToplamOdenen.Text = SCYapilanOdeme;
            txtBeklenenOdeme.Text = SCToplamOdenmesiBeklenen;
            txtKalanOdeme.Text = (Int32.Parse(SCToplamOdenmesiBeklenen) - Int32.Parse(SCYapilanOdeme)).ToString();
        }

        private void btnOdemeyiYap_Click(object sender, EventArgs e)
        {
            try
            {
                if (Int32.Parse(txtKalanOdeme.Text) < Int32.Parse(txtOdemeMiktari.Text))
                {
                    MessageBox.Show("Ödeme Miktarı, Kalan Ödemeden Daha Az Olmalıdır !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                }
                else
                {

                    String Uyari = dataGridView1.SelectedRows[0].Cells[1].Value.ToString() + " Kurbanı " + dataGridView1.SelectedRows[0].Cells[2].Value.ToString() + ". Hissesi için " + txtAdSoyad.Text + " adına " + txtOdemeMiktari.Text + " TL Ödeme Yapmak İstiyor Musunuz ?";

                    DialogResult verilencevap = MessageBox.Show(Uyari, "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (verilencevap == DialogResult.Yes)
                    {
                        //system.Sorgu("delete from Musteriler where ID=" + txtMusteriNo.Text + "");
                        String HisseFiyati = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                        int HisseninOncekiOdemesi = Int32.Parse(SCYapilanOdeme);
                        int Odenecek = Int32.Parse(txtOdemeMiktari.Text);
                        int VTYazOdenen = HisseninOncekiOdemesi + Odenecek;
                        int KalanOdeme = Int32.Parse(HisseFiyati) - VTYazOdenen;
                        system.Sorgu("UPDATE MusHisseleri SET YapilanOdeme=" + VTYazOdenen.ToString() + "  WHERE ID=" + Int32.Parse(SCHisseNo));
                        // Odeme Kayitlarını Da ekle
                        String KayitTar = System.DateTime.Now.ToShortDateString() + " " + System.DateTime.Now.ToShortTimeString();
                        system.Sorgu("insert into OdemeKayitlari(HisseNo,Tarih,Saat,Miktar,MusteriID,MusteriAdSoyad,KurbanAdi,HisseSirasi,Aciklama) values('" + SCHisseNo + "','" + System.DateTime.Now.ToShortDateString() + "','" + System.DateTime.Now.ToShortTimeString() + "','" + txtOdemeMiktari.Text + "','" + txtMusteriNoAra.Text + "','" + txtAdSoyad.Text + "','" + dataGridView1.SelectedRows[0].Cells[1].Value.ToString() + "','" + dataGridView1.SelectedRows[0].Cells[2].Value.ToString() + "','" + txtFaturaAciklamasi.Text + "')");
                        DialogResult CiktiAlacagim = MessageBox.Show("Ödeme Başarıyla Yapıldı. Fatura Çıktısı Almak İstiyor Musunuz ?", "Bildirim-Sorgu", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                        if (CiktiAlacagim == DialogResult.Yes)
                        {
                            String FaturaNo = system.GetDataCell("select ID from OdemeKayitlari where ID= (select max(ID) from OdemeKayitlari)");
                            Yazdir(system.GetDataTable("select * from MusHisseleri where MusteriID=" + txtMusteriNoAra.Text + ""),txtAdSoyad.Text, txtMusteriNoAra.Text, txtCepTel.Text, SCMusteriEposta, SCMusteriAdres, FaturaNo, dataGridView1.SelectedRows[0].Cells[1].Value.ToString(), dataGridView1.SelectedRows[0].Cells[2].Value.ToString(), txtOdemeMiktari.Text, KalanOdeme.ToString(), txtFaturaAciklamasi.Text);
                        }

                        dataGridView1.DataSource = system.GetDataTable("select ID, KurbanAdi as 'Kurban Adı', HisseSirasi as 'Hisse Sırası',HisseKayitTar as 'Hisse Kayit Tarihi',YapilanOdeme as 'Yapılan Ödeme', Toplam as 'Hisse Fiyatı' from MusHisseleri where MusteriID=" + txtMusteriNoAra.Text + "");
                        dataGridView1.Columns[0].Visible = false;
                        dataGridView1.ClearSelection();
                        txtBeklenenOdeme.Text = "";
                        txtHisseNo.Text = "";
                        txtOdemeMiktari.Text = "";
                        txtToplamOdenen.Text = "";
                        txtFaturaAciklamasi.Text = "";
                        txtKalanOdeme.Text = "";
                    }
                    else
                    {

                    }
                }
            }
            catch (Exception w)
            {

                MessageBox.Show("Bir Hata İle Karşılaşıldı. Lütfen Bilgileri Kontrol Ediniz!", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

       
        public void txtClean(){
            txtAdSoyad.Text = "";
            txtBeklenenOdeme.Text = "";
            txtCepTel.Text = "";
            txtHisseNo.Text = "";
            txtMusteriNoAra.Text = "";
            txtOdemeMiktari.Text = "";
            txtToplamOdenen.Text = "";
            txtKalanOdeme.Text = "";
        }
       
    }
   
}
