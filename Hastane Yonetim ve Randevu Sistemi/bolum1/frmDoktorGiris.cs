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
    public partial class frmDoktorGiris : Form
    {
        public frmDoktorGiris()
        {
            InitializeComponent();
        }
        SQL_Baglantisi bgl = new SQL_Baglantisi();
   
        private void btnDoktorGirisYap_Click(object sender, EventArgs e)
        {
            SqlCommand komutDr = new SqlCommand("select * from tbl_doktor where doktorTC=@drTC and doktorSifre=@drsifre", bgl.baglanti());
            komutDr.Parameters.AddWithValue("@drTC", mskdTC.Text);
            komutDr.Parameters.AddWithValue("drSifre", txtboxSifre.Text);
            SqlDataReader drDr = komutDr.ExecuteReader();
            if (drDr.Read())
            {
                frmDoktorDetay fr = new frmDoktorDetay();
                fr.TC = mskdTC.Text;
                fr.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Yanlış kullanıcı adı veya şifre");
            }
            bgl.baglanti().Close();

        }
    }
}
