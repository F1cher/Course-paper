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
    public partial class Restoration_status : Form
    {
        DataSet ds;
        SqlDataAdapter da;
        SqlCommand cmd;
        SqlConnection con;
        public Restoration_status()
        {
            InitializeComponent();
        }
        void GetCon()
        {
            con = new SqlConnection(@"Data Source=FICHER;Initial Catalog=Tiunov;Integrated Security=True");
            ds = new DataSet();
        }
        void GetStatus()
        {
            GetCon();
            da = new SqlDataAdapter("SELECT * FROM Restoration_status", con);
            con.Open();
            da.Fill(ds, "Restoration_status");
            dataGridView5.DataSource = ds.Tables["Restoration_status"];
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
        private void Restoration_status_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tiunovDataSet.Restoration_status". При необходимости она может быть перемещена или удалена.
            this.restoration_statusTableAdapter.Fill(this.tiunovDataSet.Restoration_status);
            GetStatus();
        }

        private void SbtnInsert_Click(object sender, EventArgs e)
        {
            if (Status.Text == "")
            {
                MessageBox.Show("Пожалуйста, заполните все поля!");
                return;
            }
            string query = "Insert into Restoration_status (Status) values (@Status)";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Status", Status.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GetStatus();
            toolStripStatusLabel1.Text = "Запись была добавлена!";
        }

        private void SbtnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите редактировать запись?", "Редактировать запись", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "Update Restoration_status Set Status=@Status Where Rstatus=@Rstatus";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Status", Status.Text);
                cmd.Parameters.AddWithValue("@Rstatus", dataGridView5.CurrentRow.Cells[0].Value);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                GetStatus();
                toolStripStatusLabel1.Text = "Запись была изменена!";
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void SbtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить запись?", "Удалить запись", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "Delete From Restoration_status Where Rstatus=@Rstatus";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Rstatus", dataGridView5.CurrentRow.Cells[0].Value);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                GetStatus();
                toolStripStatusLabel1.Text = "Запись была удалена!";
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void SbtnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void dataGridView5_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Status.Text = dataGridView5.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
