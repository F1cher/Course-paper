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

namespace Tiunov
{
    public partial class Authorization : Form
    {
        SqlConnection con;
        SqlCommand cmd;
        SqlDataReader dr;
        public Authorization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usr = textBox1.Text;
            string psw = textBox2.Text;
            con = new SqlConnection(@"Data Source=FICHER;Initial Catalog=Tiunov;Integrated Security=True");
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            string str = "SELECT * FROM Sotrudniki where Login='" + textBox1.Text + "' AND Pass='" + textBox2.Text + "'";
            cmd.CommandText = str;

            dr = cmd.ExecuteReader();

            if (dr.Read())
            {
                Main frm2 = new Main();
                frm2.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неправильный логин или пароль");
            }

            con.Close();
        }
    }
}
