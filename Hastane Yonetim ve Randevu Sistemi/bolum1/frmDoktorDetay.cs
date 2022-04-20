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
    public partial class frmDoktorDetay : Form
    {
        public frmDoktorDetay()
        {
            InitializeComponent();
        }
        SQL_Baglantisi bgl = new SQL_Baglantisi();

        public string TC;
        private void frmDoktorDetay_Load(object sender, EventArgs e)
        {
            lblDoktorTC.Text = TC;

            //doktor ad-soyad
            SqlCommand komut = new SqlCommand("select doktorAd,doktorSoyad from tbl_doktor where doktorTC=@drTC", bgl.baglanti());
            komut.Parameters.AddWithValue("@drTC", lblDoktorTC.Text);
            SqlDataReader drDr = komut.ExecuteReader();
            while (drDr.Read())
            {
                lblDoktorAdSoyad.Text = drDr[0] + " " + drDr[1];
            }
            bgl.baglanti().Close();

            //Randevular
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter("select * from tbl_randevu where randevuDoktor='" + lblDoktorAdSoyad.Text + "'", bgl.baglanti());
            da.Fill(dt);
            dataGridView1.DataSource = dt;
        
        }

        private void btnBilgiDuzenle_Click(object sender, EventArgs e)
        {
            frmBilgiDuzenle fr = new frmBilgiDuzenle();
            fr.tcNo = lblDoktorAdSoyad.Text;
            fr.Show();
        }

        private void btnDuyuru_Click(object sender, EventArgs e)
        {
            frmDuyurular fr = new frmDuyurular();
            fr.Show();
        }

        private void btnCikis_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            rchTxtDoktorSikayet.Text = dataGridView1.Rows[secilen].Cells[7].Value.ToString();
        }
    }
}
