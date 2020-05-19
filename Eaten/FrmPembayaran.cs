using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Eaten
{
    public partial class FrmPembayaran : Form
    {
        public FrmPembayaran()
        {
            InitializeComponent();
        }

        private void FrmPembayaran_Load(object sender, EventArgs e)
        {

        }

        private void btnkembali_Click(object sender, EventArgs e)
        {
         FrmMenuUtama utama = new FrmMenuUtama();
         utama.Show();
         this.Hide();
        }
    }
}
