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
    public partial class Kasbon : Form
    {
        //koneksi kedalam database 
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RB36HA3\UNANG;Initial Catalog=UASAPLIKASIKASBON;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        // variabel 
        int idbarang = 0;
        int idpembeli = 0;
        int hargadasar = 0;
        int totalhrg = 0;
        int qtykasbon = 0;
        int qtybarang = 0;
        int qtysisa = 0;
        int qtysisa1 = 0;

        public Kasbon()
        {
            InitializeComponent();
            tampilNamaBrg();
            tampilNamaPembeli();
            tampiltabel();
        }

        classService cs = new classService();

        private void Kasbon_Load(object sender, EventArgs e)
        {

        }
        // methode untuk menampikan data dari database ke dalam gridview
        private void tampiltabel()
        {
            //query untuk menampilkan tabel
            SqlCommand cmd = new SqlCommand("select c.ID_Kasbon, b.Nama, a.Nama_Barang, c.Qty ,c.Status , c.Total_Harga from Barang a Inner join Kasbon c On a.ID_Barang = c.ID_Barang Inner Join Pembeli b on b.ID_Pembeli = c.ID_Pembeli", con);
            DataTable dt = new DataTable();

            con.Open();

            dr = cmd.ExecuteReader();
            dt.Load(dr);
            con.Close();

            dataGridView1.DataSource = dt;
        }
        //methode untuk menampilkan nama barang dari database  dengan nama dataabse barang
        // yang telah berhasil ditambahkan kemudian ditampilkan kedalam combobox 
        private void tampilNamaBrg()
        {
            string query = "Select * from dbo.Barang";
            con.Open();

            cmd = new SqlCommand(query, con);
            dr = cmd.ExecuteReader();

            //untuk memasukkin Nama barang dari database tabel barang ke dalam combobox
            while (dr.Read())
            {
                comboBox2.Items.Add(dr.GetString(1));
            }
            con.Close();
        }
        //methode untuk menampilkan nama pembeli dari database  dengan nama dataabse pembeli
        // yang telah berhasil ditambahkan kemudian ditampilkan kedalam combobox 
        private void tampilNamaPembeli()
        {
            string query = "Select * from dbo.Pembeli";
            con.Open();

            cmd = new SqlCommand(query, con);
            dr = cmd.ExecuteReader();

            //untuk memasukkin Nama pembeli dari database tabel barang ke dalam combobox
            while (dr.Read())
            {
                comboBox1.Items.Add(dr.GetString(1));
            }
            con.Close();
        }
        //methode untuk mengambil jumlah barang dari tabel barang 
        private void selectQtyBarang()
        {
            string query = "Select * from dbo.Barang";
            con.Open();


            cmd = new SqlCommand(query, con);
            dr = cmd.ExecuteReader();
            //untuk memasukkin Nama barang dari database tabel barang ke dalam combobox
            while (dr.Read())
            {
                qtybarang = dr.GetInt32(3);
            }
            con.Close();
        }
        //methode untuk mengurangi jumlah barang yang sebelumnya telah dimasukkan 
        private void kurangiQtyBrg() 
        {
            selectQtyBarang();
            qtykasbon = Int32.Parse(txtqtyksbn.Text);
            qtysisa = qtybarang - qtykasbon;

        }
        //methode menambah jumlah barang digunakan untuk ketika input kasbon
        private void tambahQtyBrg()
        {
            selectQtyBarang();
            qtykasbon = Int32.Parse(txtqtyksbn.Text);
            qtysisa1 = qtybarang + qtykasbon;

        }
        // methode untuk mengambil data id barang berdasarkan nama barang
        private void selectIdBarang(string nama)
        {
            cmd = new SqlCommand("select * from dbo.Barang where Nama_Barang = @nama ", con);
            cmd.Parameters.AddWithValue("@nama", nama);
            con.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                idbarang = dr.GetInt32(0);
            }
            con.Close();
        }
        // methode untuk mengambil data id pembeli berdasarkan nama pembeli
        private void selectIdPembeli(string nama)
        {
            //query untuk mengambil nama pembeli dari tabel pembeli 
            cmd = new SqlCommand("select * from dbo.Pembeli where Nama = @nama ", con);
            cmd.Parameters.AddWithValue("@nama", nama);
            con.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                idpembeli = dr.GetInt32(0);
            }
            con.Close();
        }
        //methode untuk mengambil data harga barang bedasarkan id
        private void selectHargaBrg()
        {
            selectIdBarang(comboBox2.SelectedItem.ToString());
            cmd = new SqlCommand("select * from dbo.Barang where ID_Barang = @id ", con);
            cmd.Parameters.AddWithValue("@id", idbarang);
            con.Open();
            dr = cmd.ExecuteReader();

            while (dr.Read())
            {
                hargadasar = dr.GetInt32(2);
            }
            con.Close();
        }

        private void btntmbhksbn_Click(object sender, EventArgs e)
        {
            selectQtyBarang();
            qtykasbon = Int32.Parse(txtqtyksbn.Text);
            //kondisi dimana ketika qty barang mencukupi dari qty yang ada 
            if (qtybarang != 0 && qtybarang >= qtykasbon)
            {
                selectIdPembeli(comboBox1.SelectedItem.ToString());
                selectIdBarang(comboBox2.SelectedItem.ToString());

                //method untuk mengurangi qty pada barang 
                kurangiQtyBrg();
                cs.tambahKasbon(idpembeli, idbarang, txtqtyksbn.Text, comboBox3.SelectedItem.ToString(), txttotalhrgksbn.Text);
                // untuk update qty setelah kita masukkan kedalam kasbon
                cs.updateAfterInput(qtysisa, idbarang);
            }
            //kondisi dimana ketika qty tidak mencukupi
            else 
            {
                MessageBox.Show("Stok Barang Tidak Mencukupi!");
            }
            tampiltabel();
        }
        //event untuk menampilkan total harga barang 
        private void txtqtyksbn_TextChanged(object sender, EventArgs e)
        {
            
            if (txtqtyksbn.Text == "")
            {
                txttotalhrgksbn.Text = "";
            }
            else 
            {
                selectHargaBrg();
                qtykasbon = Int32.Parse(txtqtyksbn.Text);
                totalhrg = qtykasbon * hargadasar;
                txttotalhrgksbn.Text = totalhrg.ToString();
            }
        }
        //methode digunakan untuk menghapus  data kasbon
        private void btnhapusksbn_Click(object sender, EventArgs e)
        {
            selectIdBarang(comboBox2.SelectedItem.ToString());
            cs.hapusKasbon(txtidksbnksbn.Text);
            tambahQtyBrg();
            cs.updateAfterInput(qtysisa1, idbarang);
            tampiltabel();
        }

        private void btnubahksbn_Click(object sender, EventArgs e)
        {
            cs.editKasbon(txtidksbnksbn.Text,comboBox3.SelectedItem.ToString());
            tampiltabel();
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            //kondisi dimana untuk memunculkan Data pada Datagridview ke Textbox
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                txtidksbnksbn.Text = row.Cells[0].Value.ToString();
                comboBox1.Text = row.Cells[1].Value.ToString();
                comboBox2.Text = row.Cells[2].Value.ToString();
                txtqtyksbn.Text = row.Cells[3].Value.ToString();
                comboBox3.Text = row.Cells[4].Value.ToString();
                txttotalhrgksbn.Text = row.Cells[5].Value.ToString();


            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            this.Hide();
            Menu menu = new Menu();
            menu.Show();
        }
    }
}
