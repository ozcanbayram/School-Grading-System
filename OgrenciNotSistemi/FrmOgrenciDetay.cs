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

namespace OgrenciNotSistemi
{
    public partial class FrmOgrenciDetay : Form
    {
        public FrmOgrenciDetay()
        {
            InitializeComponent();
        }

        SqlConnection baglanti = new SqlConnection("Data Source=OZCAN;Initial Catalog=DbNotKayit;Integrated Security=True");

        
        public string ogrNo;
        private void FrmOgrenciDetay_Load(object sender, EventArgs e)
        {
            lblNumara.Text = ogrNo;

            baglanti.Open();
            SqlCommand komut = new SqlCommand("select * from Tbl_Ders where OGRNUMARA=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", lblNumara.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAd.Text = dr[2].ToString();
                lblSoyad.Text = dr[3].ToString();
                lblS1.Text = dr[4].ToString();
                lblS2.Text = dr[5].ToString();
                lblS3.Text = dr[6].ToString();
                lblOrtalama.Text = dr[7].ToString();
                lblDurum.Text = dr[8].ToString() + " \n \nTrue = Geçti\nFalse = Kaldı";
            }

            
        }
    }
}
