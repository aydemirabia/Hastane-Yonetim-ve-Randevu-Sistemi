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

namespace bolum1
{
    public partial class frmHastaDetay : Form
    {
        public frmHastaDetay()
        {
            InitializeComponent();
        }

        public string tc;

        SQL_Baglantisi bgl = new SQL_Baglantisi();
        private void frmHastaDetay_Load(object sender, EventArgs e)
        {
            lblHastaDetayTC.Text = tc;

            //Ad-Soyad Çekme
            SqlCommand komut = new SqlCommand("select hastaAd,hastaSoyad from tbl_hasta where hastaTC=@hTC", bgl.baglanti());
            komut.Parameters.AddWithValue("@hTC", lblHastaDetayTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                lblAdSoyad.Text = dr[0] + " " + dr[1];
            }
            bgl.baglanti().Close();

            //Randevu Geçmişi
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_randevu where hastaTC=" + tc, bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;

            //Branşları Çekme
            SqlCommand komut_brans = new SqlCommand("select bransAd from tbl_brans", bgl.baglanti());
            SqlDataReader dr_brans = komut_brans.ExecuteReader();
            while (dr_brans.Read())
            {
                hstbilgi_brans.Items.Add(dr_brans[0]);
            }
            bgl.baglanti().Close();
        }

        private void hstbilgi_brans_SelectedIndexChanged(object sender, EventArgs e)
        {
            hstbilgi_doktor.Items.Clear();
            SqlCommand komut_dr = new SqlCommand("select doktorAd,doktorSoyad from tbl_doktor where doktorBrans=@drBrans", bgl.baglanti());
            komut_dr.Parameters.AddWithValue("@drBrans", hstbilgi_brans.Text);
            SqlDataReader drReader = komut_dr.ExecuteReader();
            while (drReader.Read())
            {
                hstbilgi_doktor.Items.Add(drReader[0] + " " + drReader[1]);
            }
            bgl.baglanti().Close();
        
        }

        private void hstbilgi_doktor_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da_Dr = new SqlDataAdapter("select * from tbl_randevu where randevuBrans='" + hstbilgi_brans.Text + "'" + " and randevuDoktor='" + hstbilgi_doktor.Text + "'and randevuDurum=0", bgl.baglanti());
            da_Dr.Fill(dt);
            dataGridView2.DataSource = dt;
        }

        private void LnkHstBilgi_blgDzn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmBilgiDuzenle frBD = new frmBilgiDuzenle();
            frBD.tcNo = lblHastaDetayTC.Text;
            frBD.Show ();
        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView2.SelectedCells[0].RowIndex;
            txtId.Text = dataGridView2.Rows[secilen].Cells[0].Value.ToString();
        }

        private void btnRandevuAl_Click(object sender, EventArgs e)
        {
            SqlCommand komutRndvAl = new SqlCommand("update tbl_randevu set randevudurum=1, hastaTC=@htc,hastaSikayet=@hsikayet where randevuId=@rndvId", bgl.baglanti());
            komutRndvAl.Parameters.AddWithValue("@htc", lblHastaDetayTC.Text);
            komutRndvAl.Parameters.AddWithValue("@hsikayet", richtexthstbilgi_sikayet.Text);
            komutRndvAl.Parameters.AddWithValue("@rndvId", txtId.Text);
            komutRndvAl.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Alındı.", "Uyarı", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
