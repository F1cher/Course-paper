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
    public partial class Charts : Form
    {
        DataSet ds;
        SqlDataAdapter da;
        SqlCommand cmd;
        SqlConnection con;
        public Charts()
        {
            InitializeComponent();
        }
        void GetCon()
        {
            con = new SqlConnection(@"Data Source=FICHER;Initial Catalog=Tiunov;Integrated Security=True");
            ds = new DataSet();
        }

        void GetSotr()
        {
            da = new SqlDataAdapter("SELECT Sotrudniki.Snum, Sotrudniki.Sfam, Sotrudniki.Snam, Sotrudniki.Sotch, Sotrudniki.Stel, Kvalifikacya.Kval, Grafiki.Grafik, Sotrudniki.Login, Sotrudniki.Pass, Accesses.Access FROM Sotrudniki INNER JOIN Accesses ON Sotrudniki.Saccess = Accesses.Saccess INNER JOIN Grafiki ON Sotrudniki.Sgraf = Grafiki.Sgraf INNER JOIN Kvalifikacya ON Sotrudniki.Skval = Kvalifikacya.Skval", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Sotrudniki");
            con.Close();
        }
        void GetCharts()
        {
            GetCon();
            da = new SqlDataAdapter("SELECT * FROM Grafiki", con);
            con.Open();
            da.Fill(ds, "Grafiki");
            dataGridView4.DataSource = ds.Tables["Grafiki"];
            con.Close();
        }
        public void ClearTextBoxes()
        {
            foreach (Control control in this.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = string.Empty;
                }

                if (control is ComboBox)
                {
                    (control as ComboBox).SelectedValue = -1;
                }
            }
        }
        private void Charts_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tiunovDataSet.Grafiki". При необходимости она может быть перемещена или удалена.
            this.grafikiTableAdapter.Fill(this.tiunovDataSet.Grafiki);
            GetCharts();
        }

        private void GbtnInsert_Click(object sender, EventArgs e)
        {
            if (Grafik.Text == "")
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            string query = "Insert into Grafiki (Grafik) values (@Grafik)";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Grafik", Grafik.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GetCharts();
        }

        private void GbtnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите редактировать запись?", "Редактировать запись", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "Update Grafiki Set Grafik=@Grafik Where Sgraf=@Sgraf";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Grafik", Grafik.Text);
                cmd.Parameters.AddWithValue("@Sgraf", dataGridView4.CurrentRow.Cells[0].Value);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                GetCharts();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void GbtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить запись?", "Удалить запись", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "Delete From Grafiki Where Sgraf=@Sgraf";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Sgraf", dataGridView4.CurrentRow.Cells[0].Value);
                con.Open();
                try
                {
                    cmd.ExecuteNonQuery();
                }
                catch (Exception)
                {
                    MessageBox.Show("Невозможно удалить данную запись");
                    con.Close();
                    return;
                }
                GetCharts();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void GbtnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void dataGridView4_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Grafik.Text = dataGridView4.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
