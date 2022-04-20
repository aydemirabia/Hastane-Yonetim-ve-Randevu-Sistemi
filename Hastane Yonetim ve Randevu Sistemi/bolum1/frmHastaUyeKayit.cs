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
    public partial class frmHastaUyeKayit : Form
    {
        public frmHastaUyeKayit()
        {
            InitializeComponent();
        }

        SQL_Baglantisi bgln = new SQL_Baglantisi();
        private void btnHastaUyeKaydi_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("insert into tbl_hasta (hastaAd,hastaSoyad,hastaTC,hastaTelefon,hastaSifre,hastaCinsiyet) values (@hAd,@hSoyad,@hTC,@hTel,@hSifre,@hCinsiyet)", bgln.baglanti());
            komut.Parameters.AddWithValue("@hAd", txtHastaAd.Text);
            komut.Parameters.AddWithValue("@hSoyad", txtHastaSoyad.Text);
            komut.Parameters.AddWithValue("@hTC", mskdHastaUyeTC.Text);
            komut.Parameters.AddWithValue("@hTel", mskdHastaUyeTelefon.Text);
            komut.Parameters.AddWithValue("@hSifre", txtHastaUyeSifre.Text);
            komut.Parameters.AddWithValue("hCinsiyet", cbHastaUyeKayitCinsiyet.Text);
            komut.ExecuteNonQuery();
            bgln.baglanti().Close();
            MessageBox.Show("Kaydınız Gerçekleşti. Şifreniz: " + txtHastaUyeSifre.Text);
        }
    }
}
