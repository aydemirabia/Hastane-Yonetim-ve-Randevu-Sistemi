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
    public partial class frmSekreterDetay : Form
    {
        public frmSekreterDetay()
        {
            InitializeComponent();
        }
        public string TCno;
        SQL_Baglantisi bgl = new SQL_Baglantisi();
        private void frmSekreterDetay_Load(object sender, EventArgs e)
        {
            lblTC.Text = TCno;

            //Ad-Soyad
            SqlCommand komutS = new SqlCommand("select sekreterAdSoyad from tbl_sekreter where sekreterTc=@sTC", bgl.baglanti());
            komutS.Parameters.AddWithValue("@sTC", lblTC.Text);            
            SqlDataReader drS = komutS.ExecuteReader();
            while (drS.Read())
            {
                lbl_adsoyad.Text = drS[0].ToString();
            }
            bgl.baglanti().Close();


            //Branşları Datagrid'e Aktarma
            DataTable dtS = new DataTable();
            SqlDataAdapter daS = new SqlDataAdapter("select bransAd from tbl_brans", bgl.baglanti());
            daS.Fill(dtS);
            dataGridView1.DataSource = dtS;

            //Doktorları Listeye Aktarma
            DataTable dtD = new DataTable();
            SqlDataAdapter daD = new SqlDataAdapter("select (doktorAd+' '+doktorSoyad) as 'Doktorlar',doktorBrans from tbl_doktor", bgl.baglanti());
            daD.Fill(dtD);
            dataGridView2.DataSource = dtD;

            //Branşları ComboBox'a Aktarma
            SqlCommand komutBrans = new SqlCommand("select doktorBrans from tbl_doktor", bgl.baglanti());
            SqlDataReader drBrans = komutBrans.ExecuteReader();
            while (drBrans.Read())
            {
                cbBrans.Items.Add(drBrans[0]);
            }
            bgl.baglanti().Close();
        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            SqlCommand komutKaydet = new SqlCommand("insert into tbl_randevu (randevuTarih,randevuSaati,randevuBrans,randevuDoktor) values(@rTrh,@rSaat,@rBrns,@rDr)", bgl.baglanti());
            komutKaydet.Parameters.AddWithValue("@rTrh", mskdTarih.Text);
            komutKaydet.Parameters.AddWithValue("@rSaat", mskdSaat.Text);
            komutKaydet.Parameters.AddWithValue("@rBrns", cbBrans.Text);
            komutKaydet.Parameters.AddWithValue("@rDr", cbDoktor.Text);
            komutKaydet.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Randevu Oluşturuldu");
        }

        private void cbBrans_SelectedIndexChanged(object sender, EventArgs e)
        {
            cbDoktor.Items.Clear();
            SqlCommand komutDrB = new SqlCommand("select doktorAd,doktorSoyad from tbl_doktor where doktorBrans=@drB", bgl.baglanti());
            komutDrB.Parameters.AddWithValue("@drB", cbBrans.Text);
            SqlDataReader drB = komutDrB.ExecuteReader();
            while (drB.Read())
            {
                cbDoktor.Items.Add(drB[0] + " " +drB[1]);
            }
            bgl.baglanti().Close();

        }

        private void btnOlustur_Click(object sender, EventArgs e)
        {
            SqlCommand komutDuyuru = new SqlCommand("insert into tbl_duyuru (duyuru) values (@d1)", bgl.baglanti());
            komutDuyuru.Parameters.AddWithValue("@d1", richTxtDuyuru.Text);
            komutDuyuru.ExecuteNonQuery();
            bgl.baglanti().Close();
            MessageBox.Show("Duyuru Oluşturuldu");
        }

        private void btnDoktorPaneli_Click(object sender, EventArgs e)
        {
            frmDoktorPaneli frDrPanel = new frmDoktorPaneli();
            frDrPanel.Show();
        }

        private void btnBransPaneli_Click(object sender, EventArgs e)
        {
            frmBrans frB = new frmBrans();
            frB.Show();
        }

        private void btnRandevuListe_Click(object sender, EventArgs e)
        {
            frmRandevuListesi frRL = new frmRandevuListesi();
            frRL.Show();
        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            
        }

        private void btnDuyurular_Click(object sender, EventArgs e)
        {
            frmDuyurular frdyr = new frmDuyurular();
            frdyr.Show();
        }
    }
}
