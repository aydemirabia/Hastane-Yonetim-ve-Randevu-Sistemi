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
    public partial class frmDoktorBilgiDuzenle : Form
    {
        public frmDoktorBilgiDuzenle()
        {
            InitializeComponent();
        }
        SQL_Baglantisi bgl = new SQL_Baglantisi();
        public string tcNo;
        private void frmDoktorBilgiDuzenle_Load(object sender, EventArgs e)
        {
            mskdDoktorDuzenTC.Text = tcNo;
            SqlCommand komut = new SqlCommand("select * from tbl_doktor where doktorTC=@drTC", bgl.baglanti());
            komut.Parameters.AddWithValue("@drTC", mskdDoktorDuzenTC.Text);
            SqlDataReader dr = komut.ExecuteReader();
            while (dr.Read())
            {
                txtDoktorDuzenAd.Text = dr[1].ToString();
                txtDoktorDuzenSoyad.Text = dr[2].ToString();
                cbDoktorDuzenBrans.Text = dr[3].ToString();
                txtDoktorDuzenSifre.Text = dr[4].ToString();
            }
            bgl.baglanti().Close();
        }

        private void btnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("update tbl_doktor set doktorAd=@drAd,doktorSoyad=@drSoyad,doktorBrans=@drbrans,doktorSifre=@drSifre where doktorTC=@drTC", bgl.baglanti());
            komut.Parameters.AddWithValue("@drAd", txtDoktorDuzenAd.Text);
            komut.Parameters.AddWithValue("@drSoyad", txtDoktorDuzenSoyad.Text);
            komut.Parameters.AddWithValue("@drbrans", cbDoktorDuzenBrans.Text);
            komut.Parameters.AddWithValue("@drSifre", txtDoktorDuzenSifre.Text);
            komut.Parameters.AddWithValue("@drTC", mskdDoktorDuzenTC.Text);
            komut.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Güncellendi.");
        }
    }
}
