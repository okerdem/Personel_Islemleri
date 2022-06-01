using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Personel_İslemleri
{
    public partial class Frmİstatistik : Form
    {
        public Frmİstatistik()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-Q087NT7\\SQLEXPRESS01;Initial Catalog=İlk_Veri_Tabani;Integrated Security=True");

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Per_İstatistik_Load(object sender, EventArgs e)
        {
            //Toplam personel sayısı
            con.Open();
            SqlCommand komut1 = new SqlCommand("select count(*) from Tbl_Personel",con);
            SqlDataReader dr1 = komut1.ExecuteReader();
            while (dr1.Read())
            {
                labelPerSay.Text = dr1[0].ToString();
            }
            con.Close();

            //Evli personel sayısı
            con.Open();
            SqlCommand komut2 = new SqlCommand("select count(*) from Tbl_Personel where perdurum=1", con);
            SqlDataReader dr2= komut2.ExecuteReader();
            while (dr2.Read())
            {
                labelEvliPerSay.Text = dr2[0].ToString();
            }
            con.Close();

            //Şehir sayısı
            con.Open();
            SqlCommand komut3 = new SqlCommand("select count(distinct(persehir)) from Tbl_Personel ",con);
            SqlDataReader dr3 = komut3.ExecuteReader();
            while (dr3.Read())
            {
                labelSehirSay.Text = dr3[0].ToString();
            }
            con.Close();

            //Toplam maaş
            con.Open();
            SqlCommand komut4 = new SqlCommand("select sum(permaas) from Tbl_Personel", con);
            SqlDataReader dr4 = komut4.ExecuteReader();
            while (dr4.Read())
            {
                labelTopMaas.Text = dr4[0].ToString();
            }
            con.Close();

            //Ortalama maaş
            con.Open();
            SqlCommand komut5 = new SqlCommand("select avg(permaas) from Tbl_Personel",con);
            SqlDataReader dr5 = komut5.ExecuteReader();
            while (dr5.Read())
            {
                labelOrtMaas.Text = dr5[0].ToString();
            }
            con.Close();
        }
    }
}
