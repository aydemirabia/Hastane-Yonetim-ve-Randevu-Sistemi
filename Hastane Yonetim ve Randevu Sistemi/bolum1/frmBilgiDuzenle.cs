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
    public partial class frmBilgiDuzenle : Form
    {
        public frmBilgiDuzenle()
        {
            InitializeComponent();
        }

        public string tcNo;
        SQL_Baglantisi bgl = new SQL_Baglantisi();
        private void frmBilgiDuzenle_Load(object sender, EventArgs e)
        {
            mskdTC.Text = tcNo;
            SqlCommand komut = new SqlCommand("select * from tbl_hasta where hastaTC=@hTC", bgl.baglanti());
            komut.Parameters.AddWithValue("@hTC", mskdTC.Text);
            SqlDataReader dr_Tc = komut.ExecuteReader();
            while (dr_Tc.Read())
            {
                txtAd.Text = dr_Tc[1].ToString();
                txtSoyad.Text = dr_Tc[2].ToString();
                mskdTC.Text = dr_Tc[3].ToString();
                mskdTel.Text = dr_Tc[4].ToString();
                txtSifre.Text = dr_Tc[5].ToString();
                cbCinsiyet.Text = dr_Tc[6].ToString();
            }
            bgl.baglanti().Close();
        }

        private void btnBilgiGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutGuncelle = new SqlCommand("update tbl_hasta set hastaAd=@hAd, hastaSoyad=@hSoyad,hastaTelefon=@hTel,hastaSifre=@hSifre,hastaCinsiyet=@hCinsiyet where hastaTC=@hTc", bgl.baglanti());
            komutGuncelle.Parameters.AddWithValue("@hAd", txtAd.Text);
            komutGuncelle.Parameters.AddWithValue("@hSoyad", txtSoyad.Text);
            komutGuncelle.Parameters.AddWithValue("@hTc", mskdTC.Text);
            komutGuncelle.Parameters.AddWithValue("@hTel", mskdTel.Text);
            komutGuncelle.Parameters.AddWithValue("@hSifre", txtSifre.Text);
            komutGuncelle.Parameters.AddWithValue("@hCinsiyet", cbCinsiyet.Text);
           
            komutGuncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Bilgileriniz Güncellendi!","Bilgi ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
