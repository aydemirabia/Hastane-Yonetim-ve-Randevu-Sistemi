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
    public partial class frmSekreterGiris : Form
    {
        public frmSekreterGiris()
        {
            InitializeComponent();
        }
        SQL_Baglantisi bgl = new SQL_Baglantisi();
        private void btnHastaGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komut = new SqlCommand("select * from tbl_sekreter where sekreterTC=@sTc and sekreterSifre=@sSifre", bgl.baglanti());
            komut.Parameters.AddWithValue("@sTc", mskdHastaGirisTC.Text);
            komut.Parameters.AddWithValue("@sSifre", txtHastaGirisSifre.Text);
            SqlDataReader dr_S = komut.ExecuteReader();
            if (dr_S.Read())
            {
                frmSekreterDetay frS = new frmSekreterDetay();
                frS.TCno = mskdHastaGirisTC.Text;
                frS.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Hatalı TC & Şifre");
            }
            bgl.baglanti().Close();
        }
    }
}
