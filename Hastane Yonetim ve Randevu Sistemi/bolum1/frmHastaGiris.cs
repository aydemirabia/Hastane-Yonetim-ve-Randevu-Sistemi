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
    public partial class frmHastaGiris : Form
    {
        public frmHastaGiris()
        {
            InitializeComponent();
        }
        SQL_Baglantisi bgln = new SQL_Baglantisi();

        private void linkGirisYap_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            frmHastaUyeKayit frhastaUyeKayit = new frmHastaUyeKayit();
            frhastaUyeKayit.Show();
            this.Hide();
        }

        private void btnHastaGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from tbl_hasta where hastaTC=@hTC and hastaSifre=@hSifre", bgln.baglanti());
            komut.Parameters.AddWithValue("@hTC", mskdHastaGirisTC.Text);
            komut.Parameters.AddWithValue("@hSifre", txtHastaGirisSifre.Text);
            SqlDataReader dr = komut.ExecuteReader();
            if (dr.Read())
            {
                frmHastaDetay frhastadetay = new frmHastaDetay();
                frhastadetay.tc = mskdHastaGirisTC.Text;
                frhastadetay.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC & Şifre");
            }
            bgln.baglanti().Close();
        }
    }
}
