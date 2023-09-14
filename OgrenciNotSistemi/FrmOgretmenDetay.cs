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
    public partial class FrmOgretmenDetay : Form
    {
        public FrmOgretmenDetay()
        {
            InitializeComponent();
        }

        private void FrmOgretmenDetay_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dbNotKayitDataSet.Tbl_Ders' table. You can move, or remove it, as needed.
            this.tbl_DersTableAdapter.Fill(this.dbNotKayitDataSet.Tbl_Ders);

        }

        SqlConnection baglanti = new SqlConnection("Data Source=OZCAN;Initial Catalog=DbNotKayit;Integrated Security=True");



        private void btbKaydet_Click(object sender, EventArgs e) // All debugging is complated.
        {
            
                
                SqlCommand komut = new SqlCommand("insert into Tbl_Ders (OGRNUMARA,OGRAD,OGRSOYAD) values (@p1,@p2,@p3)", baglanti);
                komut.Parameters.AddWithValue("@p1", mskNo.Text);
                komut.Parameters.AddWithValue("@p2", txtAd.Text);
                komut.Parameters.AddWithValue("@p3", txtSoyad.Text);

                if (mskNo.Text == "" || txtAd.Text == "" || txtSoyad.Text == "")
                {
                    MessageBox.Show("Lütfen eklemek istediğiniz öğrencinin bilgilerini eksiksiz giriniz.");
                }

                else
                {
                    komut.ExecuteNonQuery();
                    baglanti.Close();
                    MessageBox.Show("Öğrenci sisteme kaydedildi.");
                    this.tbl_DersTableAdapter.Fill(this.dbNotKayitDataSet.Tbl_Ders);
                }
            
            



        }

        private void btnSil_Click(object sender, EventArgs e) //All debugging is complated.
        {
            baglanti.Open();
            SqlCommand komut = new SqlCommand("delete from Tbl_ders where OGRNUMARA=@p1", baglanti);
            komut.Parameters.AddWithValue("@p1", mskNo.Text);
            if (mskNo.Text == "" || txtAd.Text == "" || txtSoyad.Text == "")
            {
                MessageBox.Show("Lütfen silmek istediğiniz öğrenciyi seçiniz ya da id numarasını giriniz.");
            }

            else
            {
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Öğrenci sistemden silindi.");
                this.tbl_DersTableAdapter.Fill(this.dbNotKayitDataSet.Tbl_Ders);
            }



        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmOgretmenDetay fod = new FrmOgretmenDetay();
            this.Close();
            fod.Show();
        }



        private void btnGuncelle_Click(object sender, EventArgs e)
        {

            double ortalama, s1, s2, s3;

            string durum;
            bool durumSonucu;

            s1 = Convert.ToDouble(txtS1.Text);
            s2 = Convert.ToDouble(txtS2.Text);
            s3 = Convert.ToDouble(txtS3.Text);
            ortalama = (s1 + s2 + s3) / 3;
            lblOrtalama.Text = ortalama.ToString("00.00");

            if (ortalama >= 50)
            {
                lblDurum.Text = "GEÇTİ";
                durumSonucu = true;
            }
            else
            {
                lblDurum.Text = "KALDI";
                durumSonucu = false;
            }


            baglanti.Open();
            SqlCommand komut = new SqlCommand("Update Tbl_Ders Set S1=@p1, S2=@p2, S3=@p3, ORTALAMA=@p5, DURUM=@p6 where OGRNUMARA=@p4", baglanti);
            komut.Parameters.AddWithValue("@p1", txtS1.Text);
            komut.Parameters.AddWithValue("@p2", txtS2.Text);
            komut.Parameters.AddWithValue("@p3", txtS3.Text);
            komut.Parameters.AddWithValue("@p4", mskNo.Text);
            komut.Parameters.AddWithValue("@p5", decimal.Parse(lblOrtalama.Text));
            komut.Parameters.AddWithValue("@p6", (durumSonucu));

            if (txtS1.Text == "" || txtS2.Text == "" || txtS3.Text == "" || mskNo.Text == "")
            {
                MessageBox.Show("Lütfen bilgilerini güncellemek istediğiniz öğrenciyi seçiniz ya da numarasını giriniz.");
            }

            else
            {
                komut.ExecuteNonQuery();
                baglanti.Close();
                MessageBox.Show("Öğrenci notları güncellendi.");
                this.tbl_DersTableAdapter.Fill(this.dbNotKayitDataSet.Tbl_Ders);
            }






        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;

            mskNo.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtAd.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            txtS1.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtS2.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
            txtS3.Text = dataGridView1.Rows[secilen].Cells[6].Value.ToString();
        }
    }
}
