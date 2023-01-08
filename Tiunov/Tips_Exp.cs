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
    public partial class Tips_Exp : Form
    {
        OleDbConnection con;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        public Tips_Exp()
        {
            InitializeComponent();
        }
        void GetTips()
        {
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Program Files\projects\Tiunov\Tiunov_BD.mdb");
            da = new OleDbDataAdapter("SELECT * FROM Exponat_tip", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Exponat_tip");
            dataGridView1.DataSource = ds.Tables["Exponat_tip"];
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
        private void Tips_Pom_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tiunov_BDDataSet.Exponat_tip". При необходимости она может быть перемещена или удалена.
            this.exponat_tipTableAdapter.Fill(this.tiunov_BDDataSet.Exponat_tip);
            GetTips();
        }

        private void TbtnInsert_Click(object sender, EventArgs e)
        {
            if (Tip.Text == "")
            {
                MessageBox.Show("Заполните все значения");
                return;
            }
            string query = "Insert into Exponat_tip (Tip) values (@Tip)";
            cmd = new OleDbCommand(query, con);
            cmd.Parameters.AddWithValue("@Tip", Tip.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GetTips();
        }

        private void TbtnUpdate_Click(object sender, EventArgs e)
        {
            string query = "Update Exponat_tip Set Tip=@Tip Where Etip=@Etip";
            cmd = new OleDbCommand(query, con);
            cmd.Parameters.AddWithValue("@Tip", Tip.Text);
            cmd.Parameters.AddWithValue("@Etip", Convert.ToInt32(Etip.Text));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GetTips();
        }

        private void TbtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверенны, что хотите удалить запись?", "Удалить запись", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "Delete From Exponat_tip Where Etip=@Etip";
                cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@Etip", dataGridView1.CurrentRow.Cells[0].Value);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                GetTips();
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

        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Etip.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Tip.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
        }
    }
}
