using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Data;
using System.Windows.Forms;

namespace KurbanYazilimi
{
    public class Fonksiyon
    {

        public Fonksiyon()
        {

        }
        
        public OleDbConnection Baglan()
        {
            OleDbConnection Baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Application.StartupPath + "\\tool\\kurbandb.mdb; Jet OLEDB:Database Password=P@ssw0rddd;"); 
            //OleDbConnection Baglanti = new OleDbConnection(@"Provider=Microsoft.Jet.OLEDB.4.0; Data Source=" + Application.StartupPath + "\\tool\\kurbandb.mdb;"); 

            Baglanti.Open();
            return Baglanti;
        }

        public int Sorgu(string SqlMetin)
        {
            OleDbConnection Baglanti = this.Baglan();
            OleDbCommand komut = new OleDbCommand(SqlMetin, Baglanti);
            int islem = komut.ExecuteNonQuery();
            komut.Dispose();
            Baglanti.Dispose();
            Baglanti.Close();
            return islem;
        }

        public DataTable GetDataTable(string SqlMetin)
        {
            DataTable dt = new DataTable();
            OleDbConnection Baglanti = this.Baglan();
            OleDbDataAdapter adapter = new OleDbDataAdapter(SqlMetin, Baglanti);
            adapter.Fill(dt);
            adapter.Dispose();
            Baglanti.Dispose();
            Baglanti.Close();
            return dt;
        }

        public DataRow GetDataRow(string SqlMetin)
        {
            DataTable dt = new DataTable();
            OleDbConnection Baglanti = this.Baglan();
            OleDbDataAdapter adapter = new OleDbDataAdapter(SqlMetin, Baglanti);
            adapter.Fill(dt);
            adapter.Dispose();
            Baglanti.Dispose();
            Baglanti.Close();
            return dt.Rows[0];
        }

        public string GetDataCell(string SqlMetin)
        {
            DataTable dt = new DataTable();
            OleDbConnection Baglanti = this.Baglan();
            OleDbDataAdapter adapter = new OleDbDataAdapter(SqlMetin, Baglanti);
            adapter.Fill(dt);
            adapter.Dispose();
            Baglanti.Dispose();
            Baglanti.Close();
            return dt.Rows[0][0].ToString();
        }

        public DataSet GetDataSet(string SqlMetin)
        {
            DataSet ds = new DataSet();
            OleDbConnection Baglanti = this.Baglan();
            OleDbDataAdapter adapter = new OleDbDataAdapter(SqlMetin, Baglanti);
            adapter.Fill(ds);
            adapter.Dispose();
            Baglanti.Dispose();
            Baglanti.Close();
            return ds;
        }
    }
}
