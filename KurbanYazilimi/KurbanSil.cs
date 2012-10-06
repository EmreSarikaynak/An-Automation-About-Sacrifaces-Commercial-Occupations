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
    public partial class KurbanSil : Form
    {
        public KurbanSil()
        {
            InitializeComponent();
        }
        Fonksiyon system = new Fonksiyon();
        private void cmbKurbanTip_SelectedIndexChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = system.GetDataTable("select distinct(h1.KurbanAdi) from MusHisseleri as h1 where h1.KurbanAdi LIKE '%" + cmbKurbanTip.SelectedItem.ToString() + "%' Order By h1.KurbanAdi asc");
        }

        private void KurbanListesi_Load(object sender, EventArgs e)
        {
            KurbanTipleriCek();
        }
        private void KurbanTipleriCek()
        {

            DataTable dt = system.GetDataTable("select * from KurbanTipGruplari Order By Tipi");
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                DataRow dr = dt.Rows[i];
                cmbKurbanTip.Items.Add(dr["Tipi"]);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label3.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + " Hissedarları :";
            button1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString() +" Kurbanını Sil";
            DataTable dtKurban = system.GetDataTable("select  h.HisseSirasi as 'Hissenin Sirasi', m.AdSoyad as 'Musteri Ad Soyad', h.YapilanOdeme from MusHisseleri as h left join Musteriler as m ON m.ID=h.MusteriID where h.KurbanAdi='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'");

            dataGridView2.DataSource = dtKurban;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String Uyari =dataGridView1.SelectedRows[0].Cells[0].Value.ToString() +" Kurbanını Silmek İstediğinize Emin Misiniz ?";
            DialogResult verilencevap = MessageBox.Show(Uyari, "Uyarı", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (verilencevap == DialogResult.Yes)
            {

                system.Sorgu("delete from MusHisseleri where KurbanAdi='" + dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + "'");

                MessageBox.Show(dataGridView1.SelectedRows[0].Cells[0].Value.ToString() + " Kurbanı ve Hisseleri Silindi !", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataGridView1.DataSource = system.GetDataTable("select distinct(h1.KurbanAdi) from MusHisseleri as h1 where h1.KurbanAdi LIKE '%" + cmbKurbanTip.SelectedItem.ToString() + "%' Order By h1.KurbanAdi asc");

            }
        }
    }
}
