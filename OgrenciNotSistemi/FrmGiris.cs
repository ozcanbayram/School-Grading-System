using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace OgrenciNotSistemi
{
    public partial class FrmGiris : Form
    {
        public FrmGiris()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            FrmOgretmenGiris fog = new FrmOgretmenGiris();
            fog.Show();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            FrmOgrenciGiris fog = new FrmOgrenciGiris();
            fog.Show();
        }
    }
}
