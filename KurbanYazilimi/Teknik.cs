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
    public partial class Teknik : Form
    {
        public Teknik()
        {
            InitializeComponent();
        }
        Fonksiyon system = new Fonksiyon();
        private void Teknik_Load(object sender, EventArgs e)
        {
            
            DataRow drKurum = system.GetDataRow("select * from Kurum where ID= (select max(ID) from Kurum)");

            String KurumAdi = drKurum["KurumAdi"].ToString();
            String Adres = drKurum["Adres"].ToString();
            String Yil = drKurum["Yil"].ToString();
            txtAciklama.Text = "Bu Yazılım Ürünü Bir Kurban Takip Programıdır. Mevcut Program " + KurumAdi + " Adına "
                + " Kayıtlıdır. \r\nLisans Bitiş Tarihine 1 Ay Süre Kaldığında, Lisans Güncelleme İşlemleri İçin, AnaForm da Yardım Sekmesi Altında"
                + " LİSANS KAYIT Adında Yeni Bir Sekme Çıkacaktır. LİSANS KAYIT Formunda Yazılı Sistem Numarasını, İletişim Formunda Yazılı Mail Adresine Göndererek"
                + " Yeni LİSANS Numarası isteğinde Bulunabilirsiniz.\r\nKullanıcı Adı: \'user\'  Ve Yönetici Adı : 'admin' Olarak Belirlenmiştir. Değiştirilemez.\r\n"
                + "\r\nLisansın Güncellendiği Tarih.:" + drKurum["LisansBaslamaTar"].ToString() + "\r\n"
                + "Bitiş Tarihi....................................:" + drKurum["LisansBitisTar"].ToString()
                + "\r\n \r\nTeknik Sorularınız İçin <<< rp.bostanci@gmail.com >>> adresine mail atabilirsiniz.";
        }
    }
}
