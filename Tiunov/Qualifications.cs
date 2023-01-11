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
    public partial class Qualifications : Form
    {
        DataSet ds;
        SqlDataAdapter da;
        SqlCommand cmd;
        SqlConnection con;
        public Qualifications()
        {
            InitializeComponent();
        }
        void GetCon()
        {
            con = new SqlConnection(@"Data Source=FICHER;Initial Catalog=Tiunov;Integrated Security=True");
            ds = new DataSet();
        }
        void GetKval()
        {
            GetCon();
            da = new SqlDataAdapter("SELECT * FROM Kvalifikacya", con);
            con.Open();
            da.Fill(ds, "Kvalifikacya");
            dataGridView5.DataSource = ds.Tables["Kvalifikacya"];
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
        private void Qualifications_Load(object sender, EventArgs e)
        {
            GetKval();
        }

        private void TbtnInsert_Click(object sender, EventArgs e)
        {
            if (Kval.Text == "")
            {
                MessageBox.Show("Заполните все значения");
                return;
            }
            string query = "Insert into Kvalifikacya (Kval) values (@Kval)";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Kval", Kval.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GetKval();
        }

        private void TbtnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите редактировать запись?", "Редактировать запись", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "Update Kvalifikacya Set Kval=@Kval Where Skval=@Skval";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Kval", Kval.Text);
                cmd.Parameters.AddWithValue("@Skval", dataGridView5.CurrentRow.Cells[0].Value);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                GetKval();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void TbtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить запись?", "Удалить запись", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "Delete From Kvalifikacya Where Skval=@Skval";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Skval", dataGridView5.CurrentRow.Cells[0].Value);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                GetKval();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void TbtnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void dataGridView5_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Kval.Text = dataGridView5.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
