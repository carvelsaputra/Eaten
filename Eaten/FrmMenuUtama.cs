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
    public partial class FrmMenuUtama : Form
    {
        long harga = 0;
        string desk = "";

        public FrmMenuUtama()
        {
            InitializeComponent();
        }

        private void FrmMenuUtama_Load(object sender, EventArgs e)
        {
            bersih();
            clearListView();
        }

        private void bersih()
        {
            cbjenis.Items.Clear();
            cbjenis.Items.Add("Makanan");
            cbjenis.Items.Add("Minuman");
            cbpilihan.Items.Clear();
            txtdeskripsi.Enabled = false;
            txtdeskripsi.Clear();
            txtharga.Enabled = false;
            txtharga.Clear();
            nrcjumlah.Value = 1;
            nrcjumlah.Minimum = 1;
            lblTotalBayar.Text = "0";
            lblTotalItem.Text = "0";
        }

        private void clearListView()
        {
            lvPesanan.Clear();
            lvPesanan.Columns.Add("No", 30, HorizontalAlignment.Center);
            lvPesanan.Columns.Add("Nama", 117, HorizontalAlignment.Center);
            lvPesanan.Columns.Add("Jenis", 60, HorizontalAlignment.Center);
            lvPesanan.Columns.Add("Jumlah", 90, HorizontalAlignment.Center);
            lvPesanan.Columns.Add("Harga", 110, HorizontalAlignment.Center);
            lvPesanan.Columns.Add("Sub Total", 125, HorizontalAlignment.Center);
            lvPesanan.Columns.Add("Status", 100, HorizontalAlignment.Center);
            lvPesanan.View = View.Details;
            lvPesanan.GridLines = true;
            lvPesanan.FullRowSelect = true;
        }

        private void btnKembali_Click(object sender, EventArgs e)
        {
            FrmLogin login = new FrmLogin();
            login.Show();
            this.Hide();
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            FrmPembayaran bayar = new FrmPembayaran();
            bayar.Show();
            this.Hide();
        }

        private void cbjenis_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbjenis.SelectedItem.ToString().Equals("Makanan"))
            {
                cbpilihan.Items.Add("Bakso");
                cbpilihan.Items.Add("Mie Ayam");
                cbpilihan.Items.Add("Nasi Goreng");
                cbpilihan.Items.Add("Model");
                cbpilihan.Items.Add("Tekwan");
                cbpilihan.Items.Add("Laksan");
                cbpilihan.Items.Add("Lenggang");
                cbpilihan.Items.Add("Mie Celor");
                cbpilihan.Items.Add("Celimpungan");
                cbpilihan.Items.Add("Pempek Kulit");

                cbpilihan.Items.Remove("Es Kacang Merah");
                cbpilihan.Items.Remove("Sop Buah");
                cbpilihan.Items.Remove("Es Teh Manis");
                cbpilihan.Items.Remove("Es Jeruk");
                cbpilihan.Items.Remove("Es Campur");
                cbpilihan.Items.Remove("Kopi Susu");
                cbpilihan.Items.Remove("Air Mineral");
                cbpilihan.Items.Remove("Jus Mangga");
                cbpilihan.Items.Remove("Pop Ice");
                cbpilihan.Items.Remove("Pocari Sweat");
            }
            else if (cbjenis.SelectedItem.ToString().Equals("Minuman"))
            {
                cbpilihan.Items.Remove("Bakso");
                cbpilihan.Items.Remove("Mie Ayam");
                cbpilihan.Items.Remove("Nasi Goreng");
                cbpilihan.Items.Remove("Model");
                cbpilihan.Items.Remove("Tekwan");
                cbpilihan.Items.Remove("Laksan");
                cbpilihan.Items.Remove("Lenggang");
                cbpilihan.Items.Remove("Mie Celor");
                cbpilihan.Items.Remove("Celimpungan");
                cbpilihan.Items.Remove("Pempek Kulit");

                cbpilihan.Items.Add("Es Kacang Merah");
                cbpilihan.Items.Add("Sop Buah");
                cbpilihan.Items.Add("Es Teh Manis");
                cbpilihan.Items.Add("Es Jeruk");
                cbpilihan.Items.Add("Es Campur");
                cbpilihan.Items.Add("Kopi Susu");
                cbpilihan.Items.Add("Air Mineral");
                cbpilihan.Items.Add("Jus Mangga");
                cbpilihan.Items.Add("Pop Ice");
                cbpilihan.Items.Add("Pocari Sweat");
            }
        }

        private void cbpilihan_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (cbpilihan.SelectedItem.ToString())
            {
                // Makanan
                case "Bakso":
                    harga = 12000;
                    desk = "";
                    break;
                case "Mie Ayam":
                    harga = 15000;
                    desk = "";
                    break;
                case "Nasi Goreng":
                    harga = 10000;
                    desk = "";
                    break;
                case "Model":
                    harga = 10000;
                    desk = "";
                    break;
                case "Tekwan":
                    harga = 10000;
                    desk = "";
                    break;
                case "Laksan":
                    harga = 15000;
                    desk = "";
                    break;
                case "Lenggang":
                    harga = 8000;
                    desk = "";
                    break;
                case "Mie Celor":
                    harga = 10000;
                    desk = "";
                    break;
                case "Celimpungan":
                    harga = 10000;
                    desk = "";
                    break;
                case "Pempek Kulit":
                    harga = 2500;
                    desk = "";
                    break;

                // Minuman
                case "Es Kacang Merah":
                    harga = 10000;
                    desk = "";
                    break;
                case "Sop Buah":
                    harga = 9000;
                    desk = "";
                    break;
                case "Es Teh Manis":
                    harga = 4000;
                    desk = "";
                    break;
                case "Es Jeruk":
                    harga = 7000;
                    desk = "";
                    break;
                case "Es Campur":
                    harga = 8000;
                    desk = "";
                    break;
                case "Kopi Susu":
                    harga = 7000;
                    desk = "";
                    break;
                case "Air Mineral":
                    harga = 3000;
                    desk = "";
                    break;
                case "Jus Mangga":
                    harga = 7500;
                    desk = "";
                    break;
                case "Pop Ice":
                    harga = 5000;
                    desk = "";
                    break;
                case "Pocari Sweat":
                    harga = 8500;
                    desk = "";
                    break;
            }
            txtharga.Text = harga.ToString("#,##0");
            txtdeskripsi.Text = desk;
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            bool isFounded = false;
            int position = -1;

            for (int i = 0; i < lvPesanan.Items.Count; i++)
            {
                if (cbpilihan.SelectedItem.Equals(lvPesanan.Items[i].SubItems[1].Text))
                {
                    isFounded = true;
                    position = i;
                    break;
                }
            }

            if (isFounded)
            {
                lvPesanan.Items[position].SubItems[3].Text = (Convert.ToInt64(lvPesanan.Items[position].SubItems[3].Text) + Convert.ToInt64(nrcjumlah.Value)).ToString();
                long subTotal = Convert.ToInt64(lvPesanan.Items[position].SubItems[3].Text) * Convert.ToInt64(lvPesanan.Items[position].SubItems[4].Text.Replace(".", ""));
                lvPesanan.Items[position].SubItems[5].Text = subTotal.ToString("#,##0");
            }
            else
            {
                ListViewItem item = new ListViewItem((lvPesanan.Items.Count + 1).ToString());
                item.SubItems.Add(cbpilihan.SelectedItem.ToString());
                item.SubItems.Add(cbjenis.SelectedItem.ToString());
                item.SubItems.Add(nrcjumlah.Value.ToString());
                item.SubItems.Add(txtharga.Text);
                long subtotal = Convert.ToInt64(txtharga.Text.Replace(".", "")) * Convert.ToInt64(nrcjumlah.Value.ToString());
                item.SubItems.Add(subtotal.ToString("#,##0"));
                lvPesanan.Items.Add(item);
            }

            long total = 0;
            long items = 0;
            for (int i = 0; i < lvPesanan.Items.Count; i++)
            {
                total = total + Convert.ToInt64(lvPesanan.Items[i].SubItems[5].Text.Replace(".", ""));
                items = items + Convert.ToInt64(lvPesanan.Items[i].SubItems[3].Text.Replace(".", ""));
            }
            lblTotalItem.Text = items.ToString("#,##0");
            lblTotalBayar.Text = total.ToString("#,##0");
        }

        private void btnBatal_Click(object sender, EventArgs e)
        {
            bersih();
            clearListView();
        }

        private void lvPesanan_KeyDown(object sender, KeyEventArgs e)
        {
            if (lvPesanan.Items.Count > 0)
            {
                if (e.KeyCode == Keys.Delete)
                {
                    int pos = lvPesanan.FocusedItem.Index;

                    DialogResult result = MessageBox.Show("Are you sure to delete '"
                        + lvPesanan.Items[pos].SubItems[1].Text
                        + "' ?", "Confirm?"
                        , MessageBoxButtons.YesNo
                        , MessageBoxIcon.Question
                        , MessageBoxDefaultButton.Button2);

                    if (result == DialogResult.Yes)
                    {
                        lvPesanan.Items.Remove(lvPesanan.FocusedItem);

                        for (int i = pos; i < lvPesanan.Items.Count; i++)
                        {
                            lvPesanan.Items[i].SubItems[0].Text = (i + 1).ToString();
                        }

                        long total = 0;
                        long items = 0;
                        for (int i = 0; i < lvPesanan.Items.Count; i++)
                        {
                            total = total + Convert.ToInt64(lvPesanan.Items[i].SubItems[5].Text.Replace(".", ""));
                            items = items + Convert.ToInt64(lvPesanan.Items[i].SubItems[3].Text.Replace(".", ""));
                        }
                        lblTotalItem.Text = items.ToString("#,##0");
                        lblTotalBayar.Text = total.ToString("#,##0");
                    }
                }
            }
        }
    }
}
