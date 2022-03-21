using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;//deklarasi class service 

namespace ProjectUASPABD
{
    public partial class Barang : Form
    {
        //koneksi kedalam database 
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RB36HA3\UNANG;Initial Catalog=UASAPLIKASIKASBON;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        public Barang()
        {
            InitializeComponent();
            // untuk menampilkan tabel kedalam gridview 
            tampiltabel();
        }
        
        classService cs = new classService();

        //methode untuk menambahkan barang kedalam database dengan nama tabel barang 
        private void btnbrngtmbh_Click(object sender, EventArgs e)
        {
            // untuk menjalankan fungsi tambah barang dengan memanggil methode dari classservice
            cs.tambahBrg(txtnamabarang.Text,txtharga.Text,txtjumlah.Text);
            tampiltabel();
        }
        //methode untuk menampilkan tabel kedalam gridview
        private void tampiltabel()
        {

            SqlCommand cmd = new SqlCommand("Select * from Barang", con);
            DataTable dt = new DataTable();

            con.Open();

            dr = cmd.ExecuteReader();
            dt.Load(dr);
            con.Close();

            dataGridView1.DataSource = dt;
        }

        
        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if(e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtid.Text = row.Cells[0].Value.ToString();
                txtnamabarang.Text = row.Cells[1].Value.ToString();
                txtharga.Text = row.Cells[2].Value.ToString();
                txtjumlah.Text = row.Cells[3].Value.ToString();
            }
        }

        private void btnubahbrg_Click(object sender, EventArgs e)
        {
            // untuk menjalankan fungsi ubah barang dengan memanggil methode dari classservice 
            cs.ubahBrg(txtid.Text, txtnamabarang.Text, txtharga.Text, txtjumlah.Text);
            // untuk menampilkan ke tabel yang ada di gridview
            tampiltabel();
        }

        private void btnbrghapus_Click(object sender, EventArgs e)
        {
            // untuk menjalankan fungsi hapus barang dengan memanggil methode dari classservice 
            cs.HapusBrg(txtid.Text);
            // untuk menampilkan ke tabel yang ada di gridview
            tampiltabel();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }

        private void Barang_Load(object sender, EventArgs e)
        {

        }
    }
}
