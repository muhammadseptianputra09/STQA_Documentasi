using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace ProjectUASPABD
{
    public partial class loginpage : Form
    {
        public loginpage()
        {
            InitializeComponent();
        }
        //deklarasi classservice 
        classService cs = new classService();
        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtusername_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnmasuk_Click(object sender, EventArgs e)
        {
            // untuk menjalankan fungsi dengan memanggil methode dari classservice 
            cs.Login(txtusername.Text, txtpassword.Text);
            

        }

        private void loginpage_Load(object sender, EventArgs e)
        {

        }
    }
}
