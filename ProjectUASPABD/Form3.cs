using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectUASPABD
{
    public partial class Form3 : Form
    {
        //koneksi kedalam database 
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RB36HA3\UNANG;Initial Catalog=UASAPLIKASIKASBON;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;
        public Form3()
        {
            InitializeComponent();
            // untuk menampilkan tabel kedalam gridview 
            tampiltabel();
        }
        //methode untuk menampilkan tabel kedalam gridview
        private void tampiltabel()
        {
            SqlCommand cmd = new SqlCommand("Select * from Pembeli", con);
            DataTable dt = new DataTable();

            con.Open();

            dr = cmd.ExecuteReader();
            dt.Load(dr);
            con.Close();

            dataGridViewpembeli.DataSource = dt;
        }
        //deklarasi class service 
        classService cs = new classService();
        //methode untuk menambahkan pembeli 
        private void btntmbhpmbli_Click(object sender, EventArgs e)
        {
            // untuk menjalankan fungsi tambah pembeli dengan memanggil methode dari classservice
            cs.tambahpembeli(txtnama.Text, txtnohp.Text);
            tampiltabel();
            
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnubahpmbli_Click(object sender, EventArgs e)
        {
            // untuk menjalankan fungsi ubah pembeli dengan memanggil methode dari classservice
            cs.ubahpembeli(txtidpmbli.Text, txtnama.Text, txtnohp.Text);
            tampiltabel();
        }

        private void dataGridViewpembeli_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            DataGridViewRow row = dataGridViewpembeli.Rows[e.RowIndex];
            txtidpmbli.Text = row.Cells[0].Value.ToString();
            txtnama.Text = row.Cells[1].Value.ToString();
            txtnohp.Text = row.Cells[2].Value.ToString();
        }

        private void btnhapuspmbli_Click(object sender, EventArgs e)
        {
            // untuk menjalankan fungsi hapus pembeli dengan memanggil methode dari classservice
            cs.Hapuspembeli(txtidpmbli.Text);
            tampiltabel();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
