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
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            FrmRegister regis = new FrmRegister();
            regis.Show();
            this.Hide();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            FrmMenuUtama utama = new FrmMenuUtama();
            utama.Show();
            this.Hide();
        }
    }
}
