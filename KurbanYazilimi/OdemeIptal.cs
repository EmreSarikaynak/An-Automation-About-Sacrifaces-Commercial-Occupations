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
    public partial class OdemeIptal : Form
    {
        Fonksiyon system = new Fonksiyon();
        public OdemeIptal()
        {
            InitializeComponent();
        }


        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {

        }

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
                        //dtGridOdemeler.DataSource = system.GetDataTable("select KurbanAdi, HisseSirasi, Miktar,Tarih, Saat from OdemeKayitlari where MusteriID='" + drMusteri["ID"].ToString() + "'");
                        dtGridOdemeler.DataSource = system.GetDataTable("select * from OdemeKayitlari where MusteriID='" + drMusteri["ID"].ToString() + "'");
                        dtGridOdemeler.Columns[0].Visible = false;
                        dtGridOdemeler.Columns[1].Visible = false;
                        dtGridOdemeler.Columns[7].Visible = false;
                        dtGridOdemeler.Columns[8].Visible = false;
                        dtGridOdemeler.Columns[9].Visible = false;
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
            txtAdres.Text = "";
            txtAdSoyad.Text = "";
            txtCepTel.Text = "";
            txtMusteriNoAra.Text = "";

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Uyari = dtGridOdemeler.SelectedRows[0].Cells[2].Value.ToString() + " Kurbanı " + dtGridOdemeler.SelectedRows[0].Cells[3].Value.ToString() + ". Hissesi için Yapılan " + dtGridOdemeler.SelectedRows[0].Cells[4].Value.ToString() + " TL lik Ödemeyi İPTAL Etmek İstiyor Musunuz ?";
             
            DialogResult verilencevap = MessageBox.Show(Uyari, "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (verilencevap == DialogResult.Yes)
                {
                    String MusteriNo = dtGridOdemeler.SelectedRows[0].Cells[7].Value.ToString();
                    //system.Sorgu("delete from OdemeKayitlari where ID=" + txtMusteriNo.Text + "");
                    int yapilanOdeme = Int32.Parse(system.GetDataCell("select YapilanOdeme from MusHisseleri WHERE ID =" + dtGridOdemeler.SelectedRows[0].Cells[1].Value.ToString() + "")); 
                    int kesilecekOdeme = Int32.Parse(dtGridOdemeler.SelectedRows[0].Cells[4].Value.ToString());
                    int son = yapilanOdeme-kesilecekOdeme;
                    system.Sorgu("UPDATE MusHisseleri SET YapilanOdeme='"+son.ToString()+"' WHERE ID =" + dtGridOdemeler.SelectedRows[0].Cells[1].Value.ToString() + "");
                    system.Sorgu("delete from OdemeKayitlari where ID =" + dtGridOdemeler.SelectedRows[0].Cells[0].Value.ToString() + "");
                    MessageBox.Show("Hisse Bilgileri Güncellendi.", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    dtGridOdemeler.DataSource = system.GetDataTable("select * from OdemeKayitlari where MusteriID='" + dtGridOdemeler.SelectedRows[0].Cells[7].Value.ToString() + "'");
                }
                else
                {

                }
        }
    }
}
