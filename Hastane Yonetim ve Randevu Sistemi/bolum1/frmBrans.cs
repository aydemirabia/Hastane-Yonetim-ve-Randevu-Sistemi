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
    public partial class frmBrans : Form
    {
        public frmBrans()
        {
            InitializeComponent();
        }
        SQL_Baglantisi bgl = new SQL_Baglantisi();

        private void frmBrans_Load(object sender, EventArgs e)
        {
            DataTable dtB = new DataTable();
            SqlDataAdapter daB = new SqlDataAdapter("select * from tbl_brans", bgl.baglanti());
            daB.Fill(dtB);
            dataGridView1.DataSource = dtB;
        }

        private void btnEkle_Click(object sender, EventArgs e)
        {
            SqlCommand komutEkle = new SqlCommand("insert into tbl_brans (bransAd) values (@brans)", bgl.baglanti());
            komutEkle.Parameters.AddWithValue("@brans", txtBransAd.Text);
            komutEkle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş eklendi.", "Bilgi ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int secilen = dataGridView1.SelectedCells[0].RowIndex;
            txtBransID.Text = dataGridView1.Rows[secilen].Cells[0].Value.ToString();
            txtBransAd.Text = dataGridView1.Rows[secilen].Cells[1].Value.ToString();
        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            SqlCommand komutSil = new SqlCommand("delete from tbl_brans where bransId=@bransid", bgl.baglanti());
            komutSil.Parameters.AddWithValue("@bransid", txtBransID.Text);
            komutSil.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Silindi.");

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            SqlCommand komutGuncelle = new SqlCommand("update tbl_brans set bransAd=@bransad where bransId=@bransid", bgl.baglanti());
            komutGuncelle.Parameters.AddWithValue("@bransad", txtBransAd.Text);
            komutGuncelle.Parameters.AddWithValue("@bransid", txtBransID.Text);
            komutGuncelle.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Branş Güncellendi.");
        }
    }
}
