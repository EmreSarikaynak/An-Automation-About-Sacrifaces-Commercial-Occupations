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
    public partial class MusteriListesi : Form
    {
        public MusteriListesi()
        {
            InitializeComponent();
        }

        Fonksiyon system = new Fonksiyon();
        private void MusteriListesi_Load(object sender, EventArgs e)
        {
            dataGridView1.DataSource = system.GetDataTable("select ID as Musteri_No, AdSoyad as Ad_Soyad, CepNo as Cep_No, KayitTar as Kayit_Tarihi from Musteriler");

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //txtAdSoyad.Text= dataGridView1.CurrentRow.Cells["ID"].ToString();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            dataGridView1.DataSource = system.GetDataTable("select ID as Musteri_No, AdSoyad as Ad_Soyad, CepNo as Cep_No, KayitTar as Kayit_Tarihi from Musteriler");

        }

        private void txtAdSoyadAra_TextChanged(object sender, EventArgs e)
        {
            try
            {
                dataGridView1.DataSource = system.GetDataTable("select ID as Musteri_No, AdSoyad as Ad_Soyad, CepNo as Cep_No, KayitTar as Kayit_Tarihi from Musteriler where AdSoyad LIKE '%" + txtAdSoyadAra.Text + "%'");
                txtClean();
                DataRow drMusteri = system.GetDataRow("select * from Musteriler where ID=" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "");
                txtAciklama.Text = drMusteri["Aciklama"].ToString();
                txtAdres.Text = drMusteri["Adres"].ToString();
                txtAdSoyad.Text = drMusteri["AdSoyad"].ToString();
                txtCepNo.Text = drMusteri["CepNo"].ToString();
                txtEposta.Text = drMusteri["Eposta"].ToString();
                txtEvNo.Text = drMusteri["EvNo"].ToString();
                txtFax.Text = drMusteri["Fax"].ToString();
                dataGridView2.DataSource = system.GetDataTable("select KurbanAdi as 'Kurban Adı',HisseSirasi as 'Hisse Sırası',  YapilanOdeme as 'Yapılan Ödeme', Toplam from MusHisseleri where MusteriID=" + dataGridView2.SelectedRows[0].Cells[0].Value.ToString() + "");

            }
            catch (Exception)
            {
                
                
            }
            
        }
        private void txtClean() {
            txtAciklama.Text = "";
            txtAdres.Text = "";
            txtAdSoyad.Text = "";
            txtCepNo.Text = "";
            txtEposta.Text = "";
            txtEvNo.Text = "";
            txtFax.Text = "";
        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataRow drMusteri = system.GetDataRow("select * from Musteriler where ID=" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "");
                txtAciklama.Text = drMusteri["Aciklama"].ToString();
                txtAdres.Text = drMusteri["Adres"].ToString();
                txtAdSoyad.Text = drMusteri["AdSoyad"].ToString();
                txtCepNo.Text = drMusteri["CepNo"].ToString();
                txtEposta.Text = drMusteri["Eposta"].ToString();
                txtEvNo.Text = drMusteri["EvNo"].ToString();
                txtFax.Text = drMusteri["Fax"].ToString();

                dataGridView2.DataSource = system.GetDataTable("select KurbanAdi as 'Kurban Adı',HisseSirasi as 'Hisse Sırası',  YapilanOdeme as 'Yapılan Ödeme', Toplam from MusHisseleri where MusteriID=" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "");

            }
            catch (Exception)
            {
                
                
            }
            
        }

        private void txtAdSoyadAra_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
