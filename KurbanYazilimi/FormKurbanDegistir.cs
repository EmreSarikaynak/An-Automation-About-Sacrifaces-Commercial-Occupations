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
    public partial class FormKurbanDegistir : Form
    {
        public FormKurbanDegistir()
        {
            InitializeComponent();
        }
        Fonksiyon system = new Fonksiyon();

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
        String MusteriID = "";
        private void btnMusteriBul_Click(object sender, EventArgs e)
        {
            if (txtMusteriNoAra.Text.Equals(""))
            {
                lblUyari.Text = "Müşteri Bulunamadı !";
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
                        txtAdres.Text = drMusteri["Adres"].ToString();
                        lblUyari.Text = "";
                        MusteriID = drMusteri["ID"].ToString();
                        dataGridView1.DataSource = system.GetDataTable("select ID, KurbanAdi as 'Kurban Adı', HisseSirasi as 'Hisse Sırası',HisseKayitTar as 'Hisse Kayit Tarihi',YapilanOdeme as 'Yapılan Ödeme', Toplam from MusHisseleri where MusteriID=" + MusteriID + "");
                        dataGridView1.Columns[0].Visible = false;
                    }
                    else
                    {
                        lblUyari.Text = "Müşteri Bulunamadı !";
                        txtClean();
                    }
                }
                catch (Exception)
                {

                    lblUyari.Text = "Müşteri Bulunamadı !";
                    txtClean();
                }
            }
            
        }
        private void txtClean()
        {
            txtAdSoyad.Text = "";
            txtCepTel.Text = "";
            txtAdres.Text = "";
            MusteriID = "";
        }

        private void FormKurbanDegistir_Load(object sender, EventArgs e)
        {
            //KurbanTipleriCek();
            
        }

        //private void btnHisseEkle_Click(object sender, EventArgs e)
        //{
        //    if (MusteriID == "")
        //    {
        //        MessageBox.Show("Müşteri Belirlenmedi !", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //    else
        //    {
        //        int MusterininIstedigiHissSay = Int32.Parse(cmbEklenecekHisseSayisi.SelectedItem.ToString());
        //        //MessageBox.Show(MusterininIstedigiHissSay + " hisse istiosun", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        DataTable dtSeciliTipKurbanlar = system.GetDataTable("select * from Kurbanlar where Tipi LIKE '%" + cmbKurbanTipiListesi.SelectedItem.ToString() + "%' order by KurbanID");
        //        //dataGridView2.DataSource = dtSeciliTipKurbanlar;
        //        if (dtSeciliTipKurbanlar.Rows.Count < 1)
        //        {
        //            MessageBox.Show("Kurban Kaydı Bulunamadı !", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //        }
        //        for (int i = 0; i < dtSeciliTipKurbanlar.Rows.Count; i++)
        //        {
        //            DataRow drKurban = dtSeciliTipKurbanlar.Rows[i];
        //            //MessageBox.Show(drKurban["KurbanAdi"].ToString(), "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            DataTable dtKurbaninHisseleri = system.GetDataTable("select * from MusHisseleri where KurbanAdi='" + drKurban["KurbanAdi"] + "'");
        //            int KurbaninAlabilcegiHisseSay = 7 - dtKurbaninHisseleri.Rows.Count;
        //            //MessageBox.Show(KurbaninAlabilcegiHisseSay + " hisse alabilio", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //            //lblNotum.Text = KurbaninAlabilcegiHisseSay.ToString();


        //            if (MusterininIstedigiHissSay == 0)
        //            {
        //                break;
        //            }

        //            if (KurbaninAlabilcegiHisseSay >= MusterininIstedigiHissSay) // kurbanın alabileceği hisse sayısı büyükse
        //            {
        //                //MessageBox.Show(" kurbanın alabileceği hisse sayısı büyük", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //                for (int k = 0; k < Int32.Parse(cmbEklenecekHisseSayisi.SelectedItem.ToString()); k++)
        //                {
        //                    if (MusterininIstedigiHissSay < 1)
        //                    {
        //                        break;
        //                    }
        //                    string KurbaninFiyati = system.GetDataCell("select HisseFiyati from KurbanTipGruplari where Tipi='" + drKurban["Tipi"] + "'");
        //                    system.Sorgu("INSERT INTO MusHisseleri(MusteriID,KurbanAdi,Toplam) VALUES" +
        //                   "('" + MusteriID + "','" + drKurban["KurbanAdi"] + "','" + KurbaninFiyati + "')");
        //                    MusterininIstedigiHissSay--;
        //                    //MessageBox.Show("1 tane verdm " + MusterininIstedigiHissSay + " ihtiyacın kaldı", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);

        //                }
        //                //MessageBox.Show("Tüm Hisseni verdim çıkıorz", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                break;
        //            }
        //            else
        //            { // Müşteri daha fazla hissse istiyorsa
        //                //MessageBox.Show(" kurbanın alabileceği hisse sayısı küçük", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                for (int k = 0; k < KurbaninAlabilcegiHisseSay; k++)
        //                {

        //                    string KurbaninFiyati = system.GetDataCell("select HisseFiyati from KurbanTipGruplari where Tipi='" + drKurban["Tipi"] + "'");
        //                    system.Sorgu("INSERT INTO MusHisseleri(MusteriID,KurbanAdi,Toplam) VALUES" +
        //                   "('" + MusteriID + "','" + drKurban["KurbanAdi"] + "','" + KurbaninFiyati + "')");
        //                    MusterininIstedigiHissSay--;

        //                    //MessageBox.Show("1 tane verdm. ihtiyacın :" + MusterininIstedigiHissSay + "", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //                }

        //            }



        //        }

        //        // Hisse Eklendi

        //        dataGridView1.DataSource = system.GetDataTable("select ID as 'Hisse Numarası',KurbanAdi, YapilanOdeme, Toplam from MusHisseleri where MusteriID='" + MusteriID + "'");

        //    }
        //}
        //private void KurbanTipleriCek()
        //{

        //    DataTable dt = system.GetDataTable("select * from KurbanTipGruplari");
        //    for (int i = 0; i < dt.Rows.Count; i++)
        //    {
        //        DataRow dr = dt.Rows[i];
        //        cmbKurbanTipiListesi.Items.Add(dr["Tipi"]);
        //    }
        //}

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //try
            //{
            //    DataRow drHisse = system.GetDataRow("select * from Kurbanlar where KurbanAdi=" + dataGridView1.SelectedRows[0].Cells[1].Value.ToString() + "");
            //    //lblKurbanAdi.Text = drHisse["KurbanAdi"].ToString();
            //}
            //catch (Exception)
            //{

            //    MessageBox.Show("Hatalı İşlem !", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}


        }

        private void btnHisseSil_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnHisseSil_Click_1(object sender, EventArgs e)
        {
            try{

                String Uyari = dataGridView1.SelectedRows[0].Cells[1].Value.ToString() + " Kurbanı" + dataGridView1.SelectedRows[0].Cells[2].Value.ToString() + ". Hissesini ve Hissenin Ödemelerini Silmek İstiyor Musunuz ? ";
                DialogResult verilencevap = MessageBox.Show(Uyari, "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (verilencevap == DialogResult.Yes)
                {
                    system.Sorgu("UPDATE MusHisseleri SET Status='false', MusteriID='0', YapilanOdeme='0', HisseKayitTar=' ' WHERE ID =" + Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()));
                    system.Sorgu("delete from OdemeKayitlari where HisseNo='" + Int32.Parse(dataGridView1.SelectedRows[0].Cells[0].Value.ToString()) + "'");
                    
                    dataGridView1.DataSource = system.GetDataTable("select ID, KurbanAdi as 'Kurban Adı', HisseSirasi as 'Hisse Sırası',HisseKayitTar as 'Hisse Kayit Tarihi',YapilanOdeme as 'Yapılan Ödeme', Toplam from MusHisseleri where MusteriID=" + MusteriID + "");
                    dataGridView1.Columns[0].Visible = false;
                    MessageBox.Show("Hisse ve Hisseye Ait Ödemelerin Tamamı Silindi !", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }
            catch (Exception w)
            {
                MessageBox.Show(w.ToString(), "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //MessageBox.Show("Beklenmedik Bir Hata Oluştu !", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
           this.Close();
        
        }

        private void txtMusteriNoAra_TextChanged(object sender, EventArgs e)
        {

        }

    }
}
