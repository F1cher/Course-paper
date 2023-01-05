using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiunov
{
    public partial class Authorization : Form
    {
        OleDbConnection con;
        OleDbCommand cmd;
        OleDbDataReader dr;
        public Authorization()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usr = textBox1.Text;
            string psw = textBox2.Text;
            con = new OleDbConnection(@"Provider=Microsoft.ACE.Oledb.12.0;Data Source=E:\Program Files\projects\Tiunov\bin\Debug\Tiunov_BD.mdb");
            cmd = new OleDbCommand();
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
