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
    public partial class FrmOgrenciGiris : Form
    {
        public FrmOgrenciGiris()
        {
            InitializeComponent();
        }

        
        private void btnOgrenciGiris_Click(object sender, EventArgs e)
        {
            FrmOgrenciDetay fod = new FrmOgrenciDetay();
            fod.ogrNo = mskOgrenciNo.Text;
            fod.Show();
            this.Close();
        }

        private void FrmOgrenciGiris_Load(object sender, EventArgs e)
        {

        }
    }
}
