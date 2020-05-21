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
    public partial class Menu : Form
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void lblPengguna_Click(object sender, EventArgs e)
        {
            Pengguna pengguna = new Pengguna();
            this.Hide();
            pengguna.Show();
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {

        }

    }
}
