﻿using System;
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
    public partial class DashboardAdmin : Form
    {
        public DashboardAdmin()
        {
            InitializeComponent();
        }

        private void lblPengguna_Click(object sender, EventArgs e)
        {

            Pengguna pengguna = new Pengguna();
            this.Hide();
            pengguna.Show();

        }
    }
}
