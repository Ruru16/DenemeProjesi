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

namespace Proje2
{
    public partial class loginPage : Form
    {
        public loginPage()
        {
            InitializeComponent();
        }
        SqlConnection baglan;
        SqlDataReader dr;
        SqlCommand com;
        private void button1_Click(object sender, EventArgs e)
        {
            string user = textBox1.Text;
            string password = textBox2.Text;
            baglan = new SqlConnection("Data Source=HARUN\\SQLEXPRESS;Initial Catalog=loginDB;Integrated Security=True");
            com = new SqlCommand();
            baglan.Open();
            com.Connection = baglan;
            com.CommandText = "Select*From loginDB where username='" + user + "'And password ='" + password + "'";
            dr = com.ExecuteReader();
            if (dr.Read())
            {
                //MessageBox.Show("tebrikler giriş başarılı");
                Form1 gecis = new Form1();
                gecis.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("hatalı kullancı adı veya şifre girdiniz");
            }
            baglan.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
    
}
