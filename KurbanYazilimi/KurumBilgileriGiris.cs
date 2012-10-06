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
    public partial class KurumBilgileriGiris : Form
    {
        public KurumBilgileriGiris()
        {
            InitializeComponent();
        }
        Fonksiyon system = new Fonksiyon();
        private void btnKaydet_Click(object sender, EventArgs e)
        {
            if (txtKurumAdi.Text != "")
            {
                kayit();
            }
            else
            {
                lblUyari.Text = "Kurum Adı Boş Geçilemez !";
            }

        }
        public void kayit()
        {
            try
            {
                system.Sorgu("INSERT INTO Kurum(KurumAdi,Adres,Yil,LisansBaslamaTar,LisansBitisTar) VALUES" +
              "('" + txtKurumAdi.Text + "','" + txtAdres.Text + "','"+txtYil.Text+"','"+DateTime.Now.ToShortDateString()+"','"+DateTime.Now.AddDays(10).ToShortDateString()+"')");

              
                MessageBox.Show("Kayıt Tamamlandı. Program Kapatılıyor. Lütfen Yeniden Başlatınız !", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Application.Exit();
                this.DialogResult = DialogResult.OK;
            }
            catch (Exception)
            {

                throw;
            }

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtAdres_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
