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
    public partial class FrmAnasayfa : Form
    {
        public FrmAnasayfa()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection("Data Source=DESKTOP-Q087NT7\\SQLEXPRESS01;Initial Catalog=İlk_Veri_Tabani;Integrated Security=True");

        void temizle()
        {
            textAd.Text = "";
            textSoyad.Text = "";
            textSehir.Text = "";
            textMaas.Text = "";
            radioButton1.Checked = false;
            radioButton2.Checked = false;
            textAd.Focus();
        }

        void grafik()
        {
            chart1.Series["Şehir-Maaş"].Points.Clear();
            con.Open();
            SqlCommand komut = new SqlCommand("select persehir,avg(permaas) from Tbl_Personel group by persehir", con);
            SqlDataReader dr1 = komut.ExecuteReader();
            while (dr1.Read())
            {
                chart1.Series["Şehir-Maaş"].Points.AddXY(dr1[0], dr1[1]);
            }
            con.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'İlk_Veri_TabaniDataSet.Tbl_Personel' table. You can move, or remove it, as needed.
            this.tbl_PersonelTableAdapter.Fill(this.İlk_Veri_TabaniDataSet.Tbl_Personel);

            grafik();
        }

        private void buttonGuncelle_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("update Tbl_Personel set perad=@ad,persoyad=@soyad,persehir=@sehir,permaas=@maas,perdurum=@durum where perid=@id",con);
            komut.Parameters.AddWithValue("@ad", textAd.Text);
            komut.Parameters.AddWithValue("@soyad", textSoyad.Text);
            komut.Parameters.AddWithValue("@sehir", textSehir.Text);
            komut.Parameters.AddWithValue("@maas", textMaas.Text);
            if (radioButton1.Checked==true)
            {
                komut.Parameters.AddWithValue("@durum", true);
            }
            else
            {
                komut.Parameters.AddWithValue("@durum", false);
            }
            komut.Parameters.AddWithValue("@id",mtextİd.Text);
            komut.ExecuteNonQuery();
            con.Close();

            grafik();

            this.tbl_PersonelTableAdapter.Fill(this.İlk_Veri_TabaniDataSet.Tbl_Personel);
        }

        private void buttonKaydet_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("insert into Tbl_Personel(perad,persoyad,persehir,permaas,perdurum) values (@ad,@soyad,@sehir,@maas,@durum)", con);
            komut.Parameters.AddWithValue("@ad", textAd.Text);
            komut.Parameters.AddWithValue("@soyad", textSoyad.Text);
            komut.Parameters.AddWithValue("@sehir", textSehir.Text);
            komut.Parameters.AddWithValue("@maas", textMaas.Text);
            if (radioButton1.Checked == true) komut.Parameters.AddWithValue("@durum", true);
            else komut.Parameters.AddWithValue("@durum", false);
            komut.ExecuteNonQuery();
            con.Close();

            grafik();

            this.tbl_PersonelTableAdapter.Fill(this.İlk_Veri_TabaniDataSet.Tbl_Personel);
        }

        private void buttonSil_Click(object sender, EventArgs e)
        {
            con.Open();
            SqlCommand komut = new SqlCommand("delete from Tbl_Personel where perid=@id",con);
            komut.Parameters.AddWithValue("@id",mtextİd.Text);
            komut.ExecuteNonQuery();
            con.Close();

            grafik();

            this.tbl_PersonelTableAdapter.Fill(this.İlk_Veri_TabaniDataSet.Tbl_Personel);
        }

        private void buttonTemizle_Click(object sender, EventArgs e)
        {
            temizle();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int iSecilen = dataGridView1.SelectedCells[0].RowIndex;
            mtextİd.Text = dataGridView1.Rows[iSecilen].Cells[0].Value.ToString();
            textAd.Text = dataGridView1.Rows[iSecilen].Cells[1].Value.ToString();
            textSoyad.Text = dataGridView1.Rows[iSecilen].Cells[2].Value.ToString();
            textSehir.Text = dataGridView1.Rows[iSecilen].Cells[3].Value.ToString();
            textMaas.Text = dataGridView1.Rows[iSecilen].Cells[4].Value.ToString();
            if (Convert.ToBoolean(dataGridView1.Rows[iSecilen].Cells[5].Value)==true)
            {
                radioButton1.Checked = true;
            }
            else
            {
                radioButton2.Checked = true;
            }
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Frmİstatistik ist = new Frmİstatistik();
            ist.Show();
        }
        private void FrmAnasayfa_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
