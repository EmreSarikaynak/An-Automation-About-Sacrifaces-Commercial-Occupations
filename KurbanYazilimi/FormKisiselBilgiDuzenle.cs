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
    public partial class FormKisiselBilgiDuzenle : Form
    {
        public FormKisiselBilgiDuzenle()
        {
            InitializeComponent();
        }
        Fonksiyon system = new Fonksiyon();

        private String MusDegisecekID = "";
        private void btnMusteriBul_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow drMusteri = system.GetDataRow("select * from Musteriler where ID=" + txtMusteriNoAra.Text + "");
                if (drMusteri != null)
                {
                    txtAciklama.Text = drMusteri["Aciklama"].ToString();
                    txtAdres.Text = drMusteri["Adres"].ToString();
                    txtAdSoyad.Text = drMusteri["AdSoyad"].ToString();
                    txtCepTel.Text = drMusteri["CepNo"].ToString();
                    txtEposta.Text = drMusteri["Eposta"].ToString();
                    txtEvTel.Text = drMusteri["EvNo"].ToString();
                    txtFaxNo.Text = drMusteri["Fax"].ToString();
                    lblUyari.Text = "";
                    MusDegisecekID = txtMusteriNoAra.Text;
                }
                else
                {
                    lblUyari.Text = "Müşteri Bulunamadı !";
                    TxtClean();
                }


            }
            catch (Exception)
            {

                lblUyari.Text = "Müşteri Bulunamadı !";
                TxtClean();
            }
        }
        private void TxtClean(){
            txtAciklama.Text = "";
            txtAdres.Text = "";
            txtAdSoyad.Text = "";
            txtCepTel.Text = "";
            txtEposta.Text = "";
            txtEvTel.Text = "";
            txtFaxNo.Text = "";
        
        }
        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            try
            {
                if (MusDegisecekID == txtMusteriNoAra.Text)
                {

                    system.Sorgu("UPDATE Musteriler SET AdSoyad = '" + txtAdSoyad.Text + "'," +
    "Aciklama = '" + txtAciklama.Text + "',Adres = '" + txtAdres.Text + "'," +
    "Eposta = '" + txtEposta.Text + "',EvNo = '" + txtEvTel.Text + "'," +
    "Fax = '" + txtFaxNo.Text + "', CepNo = '" + txtCepTel.Text + "' WHERE ID = " + MusDegisecekID + "");
                    MessageBox.Show("Müşteri Güncellemesi Yapıldı !", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else MessageBox.Show("Müşteri No ile tekrar arama yapınız !", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);


            }
            catch { MessageBox.Show("Beklenmedik Bir Hata Oluştu", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning); }
        }

        private void FormKisiselBilgiDuzenle_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
