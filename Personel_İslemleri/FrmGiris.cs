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
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-Q087NT7\\SQLEXPRESS01;Initial Catalog=İlk_Veri_Tabani;Integrated Security=True");

        private void buttonGirisYap_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("select * from Tbl_Yonetici where kullaniciadi=@kadi and parola=@par",con);
            komut.Parameters.AddWithValue("@kadi", textKullaniciAdi.Text);
            komut.Parameters.AddWithValue("@par", textParola.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                FrmAnasayfa frm = new FrmAnasayfa();
                frm.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Kullanıcı adı veya şifre hatalı.","Hata");
            }
            con.Close();
        }
    }
}
