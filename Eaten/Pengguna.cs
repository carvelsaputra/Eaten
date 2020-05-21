using MySql.Data.MySqlClient;
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
    public partial class Pengguna : Form
    {
        private Connection koneksi = new Connection();
        public Pengguna()
        {
            InitializeComponent();
        }

        private void lblMenu_Click(object sender, EventArgs e)
        {

        }

        private void lblPengguna_Click(object sender, EventArgs e)
        {

        }

        private void btnTambah_Click(object sender, EventArgs e)
        {

        }
        private void bersih()
        {
            txtUsername.Clear();
            txtPassword.Clear();
            tampilData();
        }
        private void tampilData()
        {
            if(koneksi.openConnection())
            {
                string query = "SELECT username,password,status FROM tb_user";
                koneksi.cmd = new MySqlCommand(query, koneksi.connection);
                koneksi.dataAdapter = new MySqlDataAdapter();
                koneksi.dataAdapter.SelectCommand = koneksi.cmd;
                koneksi.dataSet = new DataSet();
                koneksi.dataAdapter.Fill(koneksi.dataSet, "datauser");
                int row = koneksi.dataSet.Tables["datauser"].Rows.Count;
                dgvPengguna.Rows.Clear();
                for(int i = 0; i < row; i++)
                {
                    dgvPengguna.Rows.Add();
                    dgvPengguna.Rows[i].Cells[0].Value = i + 1;
                    dgvPengguna.Rows[i].Cells[1].Value = koneksi.dataSet.Tables["datauser"].Rows[i].ItemArray[0];
                    dgvPengguna.Rows[i].Cells[2].Value = koneksi.dataSet.Tables["datauser"].Rows[i].ItemArray[1];
                    dgvPengguna.Rows[i].Cells[3].Value = koneksi.dataSet.Tables["datauser"].Rows[i].ItemArray[2];
                }
                dgvPengguna.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
                dgvPengguna.AllowUserToAddRows = false;
                koneksi.closeConnection();
            }
        }

        private void Pengguna_Load(object sender, EventArgs e)
        {
            bersih();
            dgvPengguna.Columns[0].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
            dgvPengguna.Columns[0].DefaultCellStyle.Padding = new Padding(0, 0, 5, 0);

            dgvPengguna.Columns[1].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvPengguna.Columns[1].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);

            dgvPengguna.Columns[2].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvPengguna.Columns[2].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);

            dgvPengguna.Columns[3].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dgvPengguna.Columns[3].DefaultCellStyle.Padding = new Padding(4, 0, 0, 0);
        }
    }
}
