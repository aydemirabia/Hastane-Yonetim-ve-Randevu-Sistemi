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
    public partial class frmDoktorPaneli : Form
    {
        public frmDoktorPaneli()
        {
            InitializeComponent();
        }
        SQL_Baglantisi bgl = new SQL_Baglantisi();
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void frmDoktorPaneli_Load(object sender, EventArgs e)
        {
            DataTable dtD = new DataTable();
            SqlDataAdapter daD = new SqlDataAdapter("select * from tbl_doktor", bgl.baglanti());
            daD.Fill(dtD);
            dataGridView1.DataSource = dtD;

            //Branşları ComboBox'a Aktarma
            SqlCommand komutBrans = new SqlCommand("select doktorBrans from tbl_doktor", bgl.baglanti());
            SqlDataReader drBrans = komutBrans.ExecuteReader();
            while (drBrans.Read())
            {
                cbBrans.Items.Add(drBrans[0]);
            }
            bgl.baglanti().Close();
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komutDrP = new SqlCommand("insert into tbl_doktor (doktorAd,doktorSoyad,doktorBrans,doktorTC,doktorSifre) values (@dAd,@dSoyad,@dBrans,@dTc,@dSifre)", bgl.baglanti());
            komutDrP.Parameters.AddWithValue("@dAd", txtAd.Text);
            komutDrP.Parameters.AddWithValue("@dSoyad", txtSoyad.Text);
            komutDrP.Parameters.AddWithValue("@dBrans", cbBrans.Text);
            komutDrP.Parameters.AddWithValue("@dTc", mskdTC.Text);
            komutDrP.Parameters.AddWithValue("@dSifre", txtSifre.Text);
            komutDrP.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Doktor Eklendi.", "Bilgi ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
            txtSoyad.Text = dataGridView1.Rows[secilen].Cells[2].Value.ToString();
            cbBrans.Text = dataGridView1.Rows[secilen].Cells[3].Value.ToString();
            mskdTC.Text = dataGridView1.Rows[secilen].Cells[4].Value.ToString();
            txtSifre.Text = dataGridView1.Rows[secilen].Cells[5].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutSil = new SqlCommand("delete from tbl_doktor where doktorTC=@dTC", bgl.baglanti());
            komutSil.Parameters.AddWithValue("@dTC", mskdTC.Text);
            komutSil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi", "Uyarı ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutGuncelle = new SqlCommand("update tbl_doktor set doktorAd=@dad,doktorSoyad=@dsoyad,doktorBrans=@dbrans,doktorSifre=@dsifre where doktorTC=@dtc", bgl.baglanti());
            komutGuncelle.Parameters.AddWithValue("@dad", txtAd.Text);
            komutGuncelle.Parameters.AddWithValue("@dsoyad", txtSoyad.Text);
            komutGuncelle.Parameters.AddWithValue("@dbrans", cbBrans.Text);
            komutGuncelle.Parameters.AddWithValue("@dtc", mskdTC.Text);
            komutGuncelle.Parameters.AddWithValue("@dsifre", txtSifre.Text);
            komutGuncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Kayıt Silindi", "Uyarı ", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
