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
        SqlDataReader dr;
        SqlCommand cmd;
        SqlConnection con;
        public Authorization()
        {
            InitializeComponent();
        }
        void GetCon()
        {
            con = new SqlConnection(@"Data Source=FICHER;Initial Catalog=Tiunov;Integrated Security=True");
        }
        private void Authbtn_Click(object sender, EventArgs e)
        {
            string usr = Login.Text;
            string psw = Pass.Text;
            GetCon();
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            string str = "SELECT * FROM Sotrudniki where Login='" + Login.Text + "' AND Pass='" + Pass.Text + "'";
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
                MessageBox.Show("Неверный логин или пароль");
            }

            con.Close();
        }
    }
}
