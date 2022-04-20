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
    public partial class frmRandevuListesi : Form
    {
        public frmRandevuListesi()
        {
            InitializeComponent();
        }
        SQL_Baglantisi bgl = new SQL_Baglantisi();
        private void frmRandevuListesi_Load(object sender, EventArgs e)
        {
            DataTable dtRL = new DataTable();
            SqlDataAdapter daRL = new SqlDataAdapter("select * from tbl_randevu", bgl.baglanti());
            daRL.Fill(dtRL);
            dataGridView1.DataSource = dtRL;
        }
        
    }
}
