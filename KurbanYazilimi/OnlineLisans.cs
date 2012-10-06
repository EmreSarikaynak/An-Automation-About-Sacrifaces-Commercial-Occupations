using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Management;
using System.Collections;

namespace KurbanYazilimi
{

    public partial class OnlineLisans : Form
    {
        public OnlineLisans()
        {
            InitializeComponent();
        }
        Fonksiyon system = new Fonksiyon();
        

        private void OnlineLisans_Load(object sender, EventArgs e)
        {
            string cpuInfo = string.Empty;
            ManagementClass mc = new ManagementClass("win32_processor");
            ManagementObjectCollection moc = mc.GetInstances();

            foreach (ManagementObject mo in moc)
            {
                if (cpuInfo == "")
                {
                    //Get only the first CPU's ID
                    cpuInfo = mo.Properties["processorID"].Value.ToString();
                    break;
                }
            }
            txtSistemNo.Text = cpuInfo;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            String CPUID = txtSistemNo.Text;
            ArrayList ASCIIs = new ArrayList();
            ArrayList CodeASCIIs = new ArrayList();
            for (int i = 0; i < CPUID.Length; i++)
            {
                ASCIIs.Add(Convert.ToInt32(CPUID[i]));

            }

            for (int i = 0; i < ASCIIs.Count; i++)
            {
                CodeASCIIs.Add(Int32.Parse(ASCIIs[i].ToString()) + 3 * i);

            }
            String licence = "";
            for (int i = 0; i < CodeASCIIs.Count; i++)
            {
                licence = licence + Convert.ToChar(Int32.Parse(CodeASCIIs[i].ToString()));
            }

            if (txtLicence.Text == licence)
            {
                DataRow drKurum = system.GetDataRow("select * from Kurum where ID= (select max(ID) from Kurum)");
                
                // VT KAYIT
                //system.Sorgu();
                String KurumAdi = drKurum["KurumAdi"].ToString();
                String Adres = drKurum["Adres"].ToString();
                String Yil = drKurum["Yil"].ToString();

                system.Sorgu("INSERT INTO Kurum(KurumAdi,Adres,Yil,LisansBaslamaTar,LisansBitisTar) VALUES" +
              "('" + KurumAdi + "','" + Adres + "','" +  Yil + "','" + DateTime.Now.ToShortDateString() + "','" + DateTime.Now.AddYears(2).ToShortDateString() + "')");


                MessageBox.Show("Kayıt Tamamlandı. Program Kapatılıyor. Lütfen Yeniden Başlatınız !", "Bildirim", MessageBoxButtons.OK, MessageBoxIcon.Information);

                MessageBox.Show("Lisans Numaranız Doğrulandı. Program Kurumunuz Adına 2 Yıl Süreyle Lisanslanmıştır.","Bidirim", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        

    }
}
