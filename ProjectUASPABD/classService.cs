using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectUASPABD
{
    /// <summary>
    /// kelas utama dalam project
    /// </summary>
    /// <remarks>
    /// terdapat kelas service untuk fungsi CRUD
    /// </remarks>
    class classService
    {
        ///<remarks>
        ////// fungsinya untuk mengakses database
        ///</remarks>
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-RB36HA3\UNANG;Initial Catalog=UASAPLIKASIKASBON;Integrated Security=True");
        SqlCommand cmd;
        SqlDataReader dr;

        ///<remarks>
        ////// untuk 
        ///</remarks>
        int qtyawal;
        int qtykasbon;
        int qtysisa;


        /// <summary>
        /// Method digunakan untuk login 
        /// </summary>
        /// <param name="user">baris pada methode halaman untuk memasukkan username </param>
        /// <param name="pass">baris pada methode halaman untuk memasukkan Password</param>
        public void Login(string user, string pass)
        {
             
            if (user != string.Empty || pass != string.Empty)
            {
                cmd = new SqlCommand("select * from Admin where username='" + user + "' and password='" + pass + "'", con);
                con.Open();
                dr = cmd.ExecuteReader();
                if (dr.Read())
                {
                    dr.Close();
                    loginpage lg = new loginpage();
                    lg.Hide();
                    Menu mn = new Menu();
                    mn.Show();
                }
                else
                {
                   
                    MessageBox.Show("No Account avilable with this username and password ", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                con.Close();

            }
            else
            {
                MessageBox.Show("Please enter value in all field.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Methode digunakan untuk menambahkan data barang
        /// </summary>
        /// <param name="nama">untuk menambahkan data nama pada tambah barang</param>
        /// <param name="harga">untuk menambahkan data harga pada tambah barang</param>
        /// <param name="qty">untuk menambahkan data qty pada tambah barang</param>
        public void tambahBrg(string nama, string harga, string qty) 
        { 
            if (nama != "" && harga != "" && qty != "")
            {
                cmd = new SqlCommand("insert into dbo.Barang(Nama_Barang, Harga, Qty) values(@name,@harga,@qty)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@name", nama);
                cmd.Parameters.AddWithValue("@harga", harga);
                cmd.Parameters.AddWithValue("@qty", qty);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        /// <summary>
        /// Methode digunakan untuk mengubah Data Barang
        /// </summary>
        /// <param name="id">untuk mengubah data id pada ubah barang</param>
        /// <param name="nama">untuk mengubah data nama pada ubah barang</param>
        /// <param name="harga">untuk mengubah data harga pada ubah barang</param>
        /// <param name="qty">untuk mengubah data qty pada ubah barang</param>
        public void ubahBrg(string id, string nama, string harga, string qty) 
        {        
            if (nama != "" && harga != "" && qty != "" && id != "")
            {
                cmd = new SqlCommand("update dbo.Barang set Nama_Barang = @name, Harga=@harga, Qty=@qty where ID_Barang = @id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", nama);
                cmd.Parameters.AddWithValue("@harga", harga);
                cmd.Parameters.AddWithValue("@qty", qty);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Edited Successfully");
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        /// <summary>
        /// Methode digunakan untuk mengHapus Data Barang
        /// </summary>
        /// <param name="id">untuk menghapus data barang pada hapus barang</param>
        public void HapusBrg(string id)
        {
            if (id != "")
            {
                cmd = new SqlCommand("delete from dbo.Barang where ID_Barang = @id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully");
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        /// <summary>
        /// methode digunakan untuk menambah data pembeli
        /// </summary>
        /// <param name="nama">untuk menambahkan data nama pembeli pada tambah pembeli</param>
        /// <param name="nohp">untuk menambahkan data nohp pembeli pada tambah pembeli</param>
        public void tambahpembeli(string nama, string nohp)
        {
            if (nama != "" && nohp != "")
            {
                cmd = new SqlCommand("insert into dbo.Pembeli(Nama, NoHp) values(@name,@nohp)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@name", nama);
                cmd.Parameters.AddWithValue("@nohp", nohp);

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Inserted Successfully");
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }

        }

        /// <summary>
        /// Methode digunakan untuk mengUbah Data pembeli
        /// </summary>
        /// <param name="id">untuk mengubah data id pembeli pada ubah pembeli</param>
        /// <param name="nama">untuk mengubah data nama pembeli pada ubah pembeli</param>
        /// <param name="nohp">untuk mengubah data nohp pembeli pada ubah pembeli</param>
        public void ubahpembeli(string id, string nama, string nohp)
        {
            if (nama != "" && nohp != "" && id != "")
            {
                cmd = new SqlCommand("update dbo.Pembeli set Nama = @name, NoHp=@nohp where ID_Pembeli = @id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@name", nama);
                cmd.Parameters.AddWithValue("@nohp", nohp);
                

                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Edited Successfully");
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }

        }

        /// <summary>
        /// methode digunakan untuk menghapus data pembeli 
        /// </summary>
        /// <param name="id">untuk menghapus data pembeli dengan menggunakan parameter id pada hapus pembeli</param>
        public void Hapuspembeli(string id)

        {
            if (id != "")
            {
                cmd = new SqlCommand("delete from dbo.Pembeli where ID_Pembeli = @id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully");
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        /// <summary>
        /// methode untuk menambah data kasbon
        /// </summary>
        /// <param name="idpembeli">untuk menambahkan data idpembeli pembeli pada tambah kasbon</param>
        /// <param name="idbrg">untuk menambahkan data idbarang  pada tambah kasbon</param>
        /// <param name="qty">untuk menambahkan data qty  pada tambah kasbon</param>
        /// <param name="status">untuk menambahkan data status pada tambah kasbon</param>
        /// <param name="totalhrg">untuk menambahkan data total harga pada tambah kasbon</param>
        public void tambahKasbon(int idpembeli,int idbrg, string qty, string status, string totalhrg) 
        {

            if ( qty != "" && status != "" && totalhrg !="")
            {
                cmd = new SqlCommand("insert into dbo.Kasbon(ID_Pembeli, ID_Barang, QTy, Status, Total_Harga) values(@idpmbl,@idbrg,@qty,@status,@totalhrg)", con);
                con.Open();
                cmd.Parameters.AddWithValue("@idpmbl", idpembeli);
                cmd.Parameters.AddWithValue("@idbrg", idbrg);
                cmd.Parameters.AddWithValue("@qty", qty);
                cmd.Parameters.AddWithValue("@status", status);
                cmd.Parameters.AddWithValue("@totalhrg", totalhrg);


                cmd.ExecuteNonQuery();
                con.Close(); 
                MessageBox.Show("Record Inserted Successfully");
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        /// <summary>
        /// methode untuk mengedit kasbon
        /// </summary>
        /// <param name="id">untuk mengedit data id pada edit kasbon</param>
        /// <param name="status">untuk mengedit data status pada edit kasbon</param>
        public void editKasbon(string id, string status) 
        {

            if (id != "" && status != "" )
            {
                cmd = new SqlCommand("update dbo.Kasbon set Status = @status where ID_Kasbon = @id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.Parameters.AddWithValue("@status", status);
                
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Edited Successfully");
            }
            else
            {
                //pessan yang akan di tampilkan ketika gagal
                MessageBox.Show("Please Provide Details!");
            }

        }

        /// <summary>
        /// methode digunakan untuk menghapus kasbon
        /// </summary>
        /// <param name="id">untuk menghapus data Kasbon dari database dengan nama tabel Kasbon</param>
        public void hapusKasbon(string id) 
        {
            if (id != "")
            {
                cmd = new SqlCommand("delete from dbo.Kasbon where ID_Kasbon = @id", con);
                con.Open();
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
                con.Close();
                MessageBox.Show("Record Deleted Successfully");
            }
            else
            {
                MessageBox.Show("Please Provide Details!");
            }
        }

        /// <summary>
        /// methode digunakan untuk mengubah jumlah barang setelah input kasbon
        /// </summary>
        /// <param name="qtysisa">untuk mengubah jumlah update qty sisa dari database dengan nama tabel barang</param>
        /// <param name="id">untuk mengubah jumlah update id dari database dengan nama tabel barang</param>
        public void updateAfterInput(int qtysisa, int id) 
        {
            cmd = new SqlCommand("update dbo.Barang set QTy = @qty where ID_Barang = @id", con);
            con.Open();
            cmd.Parameters.AddWithValue("@qty", qtysisa);
            cmd.Parameters.AddWithValue("@id", id);

            cmd.ExecuteNonQuery();
            con.Close();
            MessageBox.Show("Record Edited Successfully");
        }

    }
}

    

    



