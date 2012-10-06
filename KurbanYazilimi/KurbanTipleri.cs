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
    public partial class KurbanTipleri : Form
    {
        public KurbanTipleri()
        {
            InitializeComponent();
            Application.Idle += new EventHandler(Application_Idle);
        }
        Fonksiyon system = new Fonksiyon();
        private void btnKaydet_Click(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click_1(object sender, EventArgs e)
        {
            if (txtKurbanTipi.Text != "")
            {
                system.Sorgu("INSERT INTO KurbanTipGruplari(Tipi,HisseFiyati,Aciklama) VALUES" +
                   "('" + txtKurbanTipi.Text + "','" + txtHisseFiyati.Text + "','" + txtAciklama.Text + "')");

                String Uyari = "Kayıt Tamamlandı.";
                MessageBox.Show(Uyari, "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Kurban Tipi Boş Bırakılamaz", "Uyarı !", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            GridGuncelle();
            KurbanTipleriCek();
            txtKurbanTipi.Text = "";
            txtAciklama.Text="";
            txtHisseFiyati.Text="";
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            try
            {
                DataRow drTip = system.GetDataRow("select * from KurbanTipGruplari where Tipi='" + cmbKurbanTipleri.SelectedItem.ToString() + "'");
                if (drTip != null)
                {


                    DialogResult verilencevap = MessageBox.Show("Kurban tiplerini sildiğinizde silinen tipteki tüm mevcut hisseler silinir!\nTipi Silmekten Emin Misiniz ?", "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (verilencevap == DialogResult.Yes)
                    {
                        system.Sorgu("delete from KurbanTipGruplari where Tipi='" + cmbKurbanTipleri.SelectedItem.ToString() + "'");
                        system.Sorgu("delete from MusHisseleri where KurbanAdi LIKE '%"+cmbKurbanTipleri.SelectedItem.ToString()+"%'");
                        MessageBox.Show("Kurban Tip ve Tum Hisseleri Silindi !", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    GridGuncelle();
                    KurbanTipleriCek();
                }
                else lblUyari.Text = "Tip Bulunamadı !";

            }
            catch (Exception)
            {

                MessageBox.Show("VT üzerinde veriye ulaşılamadı !", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void GridGuncelle() {
            dataGridView1.DataSource = system.GetDataTable("select ktg.Tipi as 'Tip' , ktg.HisseFiyati as 'Hisse Fiyati', ktg.Aciklama as 'Açıklama' from KurbanTipGruplari as ktg  Order By Tipi");
        }

        private void KurbanTipleri_Load(object sender, EventArgs e)
        {
            GridGuncelle();
            KurbanTipleriCek();
            Application.Idle += new EventHandler(Application_Idle);
        }
        private void KurbanTipleriCek()
        {
            cmbKurbanTipleri.Items.Clear();
            DataTable dt = system.GetDataTable("select * from KurbanTipGruplari Order By Tipi");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                cmbKurbanTipleri.Items.Add(dr["Tipi"]);
            }
        }

        private void Application_Idle(object sender, EventArgs e)
        {
            int sayi = this.Controls.Count;
            for (int i = 0; i < sayi; i++)
            {
                if (this.Controls[i] is TextBox)
                {
                    if (this.ActiveControl == this.Controls[i])
                        this.Controls[i].BackColor = Color.Blue;
                    else
                        this.Controls[i].BackColor = Color.White;
                }
            }
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {
            
        }

    }
}
