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
    public partial class FormMusteriSil : Form
    {
        public FormMusteriSil()
        {
            InitializeComponent();
        }
        Fonksiyon system = new Fonksiyon();
        private void btnMusteriBul_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow drMusteri = system.GetDataRow("select * from Musteriler where ID=" + txtMusteriNo.Text + "");
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
        private void txtClean()
        {
            txtAciklama.Text = "";
            txtAdres.Text = "";
            txtAdSoyad.Text = "";
            txtCepTel.Text = "";
            txtEposta.Text = "";
            txtEvTel.Text = "";
            txtFaxNo.Text = "";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                String MusteriAdi = system.GetDataCell("select AdSoyad from Musteriler where ID=" + txtMusteriNo.Text + "");
                String Uyari = MusteriAdi + " isimli Müşteriyi Silmek İstediğinizden Emin Misiniz ? \nSilinen Müşterinin Bilgilerine Asla Tekrar Ulaşamazsınız.";

                DialogResult verilencevap = MessageBox.Show(Uyari, "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (verilencevap == DialogResult.Yes)
                {
                    system.Sorgu("delete from Musteriler where ID=" + txtMusteriNo.Text + "");
                    system.Sorgu("UPDATE MusHisseleri SET Status='false', MusteriID=0, YapilanOdeme='0',HisseKayitTar='0' WHERE MusteriID ="  + txtMusteriNo.Text+"");
                    system.Sorgu("delete from OdemeKayitlari where MusteriID='" + txtMusteriNo.Text + "'");
                    MessageBox.Show("Müşteri Silindi", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                }
            }
            catch (Exception)
            {
                MessageBox.Show("VT üzerinde veriye ulaşılamadı", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
