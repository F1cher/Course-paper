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
    public partial class Qualifications : Form
    {
        OleDbConnection con;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        public Qualifications()
        {
            InitializeComponent();
        }
        void GetKval()
        {
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Program Files\projects\Tiunov\Tiunov_BD.mdb");
            da = new OleDbDataAdapter("SELECT * FROM Kvalifikacya", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Kvalifikacya");
            dataGridView1.DataSource = ds.Tables["Kvalifikacya"];
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
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tiunov_BDDataSet.Kvalifikacya". При необходимости она может быть перемещена или удалена.
            this.kvalifikacyaTableAdapter.Fill(this.tiunov_BDDataSet.Kvalifikacya);
            GetKval();
        }

        private void KbtnInsert_Click(object sender, EventArgs e)
        {
            if (Kval.Text == "")
            {
                MessageBox.Show("Заполните все значения");
                return;
            }
            string query = "Insert into Kvalifikacya (Kval) values (@Kval)";
            cmd = new OleDbCommand(query, con);
            cmd.Parameters.AddWithValue("@Kval", Kval.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GetKval();
        }

        private void KbtnUpdate_Click(object sender, EventArgs e)
        {
            string query = "Update Kvalifikacya Set Kval=@Kval Where Skval=@Skval";
            cmd = new OleDbCommand(query, con);
            cmd.Parameters.AddWithValue("@Kval", Kval.Text);
            cmd.Parameters.AddWithValue("@Skval", Convert.ToInt32(Skval.Text));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GetKval();
        }

        private void KbtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверенны, что хотите удалить запись?", "Удалить запись", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "Delete From Kvalifikacya Where Skval=@Skval";
                cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@Skval", dataGridView1.CurrentRow.Cells[0].Value);
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

        private void KbtnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Skval.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Kval.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
