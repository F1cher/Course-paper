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
            string user = Convert.ToString(Login.SelectedValue);
            string pass = Pass.Text;
            GetCon();
            cmd = new SqlCommand();
            con.Open();
            cmd.Connection = con;
            string str = "SELECT * FROM Sotrudniki where Login='" + user + "' AND Pass='" + pass + "'";
            cmd.CommandText = str;
            dr = cmd.ExecuteReader();
            if (dr.Read())
            {
                string name = dr["Snam"].ToString();
                MessageBox.Show("Добро пожаловать, " + name + "!");
                string Saccess = dr["Saccess"].ToString();
                Main Main = new Main(Saccess);
                Main.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Неверный логин или пароль");
            }
            con.Close();
        }
        private void Authorization_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tiunovDataSet.Sotrudniki". При необходимости она может быть перемещена или удалена.
            this.sotrudnikiTableAdapter.Fill(this.tiunovDataSet.Sotrudniki);

        }
    }
}
