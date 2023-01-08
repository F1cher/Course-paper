using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Tiunov
{
    public partial class Charts : Form
    {
        OleDbConnection con;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        public Charts()
        {
            InitializeComponent();
        }
        void GetCharts()
        {
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Program Files\projects\Tiunov\Tiunov_BD.mdb");
            da = new OleDbDataAdapter("SELECT * FROM Grafiki", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Grafiki");
            dataGridView1.DataSource = ds.Tables["Grafiki"];
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tiunov_BDDataSet.Grafiki". При необходимости она может быть перемещена или удалена.
            this.grafikiTableAdapter.Fill(this.tiunov_BDDataSet.Grafiki);
            GetCharts();
        }

        private void GbtnInsert_Click(object sender, EventArgs e)
        {
            if (Grafik.Text == "")
            {
                MessageBox.Show("Заполните все значения");
                return;
            }
            string query = "Insert into Grafiki (Grafik) values (@Grafik)";
            cmd = new OleDbCommand(query, con);
            cmd.Parameters.AddWithValue("@Grafik", Grafik.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GetCharts();
        }

        private void GbtnUpdate_Click(object sender, EventArgs e)
        {
            string query = "Update Grafiki Set Grafik=@Grafik Where Sgraf=@Sgraf";
            cmd = new OleDbCommand(query, con);
            cmd.Parameters.AddWithValue("@Grafik", Grafik.Text);
            cmd.Parameters.AddWithValue("@Sgraf", Convert.ToInt32(Sgraf.Text));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GetCharts();
        }

        private void GbtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверенны, что хотите удалить запись?", "Удалить запись", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "Delete From Grafiki Where Sgraf=@Sgraf";
                cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@Sgraf", dataGridView1.CurrentRow.Cells[0].Value);
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

        private void GbtnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Sgraf.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Grafik.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
