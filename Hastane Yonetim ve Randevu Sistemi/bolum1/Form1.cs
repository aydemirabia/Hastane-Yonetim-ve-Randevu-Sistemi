using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace bolum1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHastaGirisi_Click(object sender, EventArgs e)
        {
            frmHastaGiris frhastagiris = new frmHastaGiris();
            frhastagiris.Show();
            this.Hide();
        }

        private void btnDoktorGirisi_Click(object sender, EventArgs e)
        {
            frmDoktorGiris frdoktorgiris = new frmDoktorGiris();
            frdoktorgiris.Show();
            this.Hide();
        }

        private void btnSekreterGirisi_Click(object sender, EventArgs e)
        {
            frmSekreterGiris frsekretergiris = new frmSekreterGiris();
            frsekretergiris.Show();
            this.Hide();
        }
    }
}
