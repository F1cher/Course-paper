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
    public partial class Main : Form
    {
        OleDbConnection con;
        OleDbDataAdapter da;
        OleDbCommand cmd;
        DataSet ds;
        public Main()
        {
            InitializeComponent();
        }
        void GetPom()
        {
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Program Files\projects\Tiunov\Tiunov_BD.mdb");
            da = new OleDbDataAdapter("SELECT * FROM Pomeshenya", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Pomeshenya");
            dataGridView1.DataSource = ds.Tables["Pomeshenya"];
            con.Close();
        }

        void GetSotr()
        {
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Program Files\projects\Tiunov\Tiunov_BD.mdb");
            da = new OleDbDataAdapter("SELECT * FROM Sotrudniki", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Sotrudniki");
            dataGridView2.DataSource = ds.Tables["Sotrudniki"];
            con.Close();
        }

        void GetExp()
        {
            con = new OleDbConnection(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=E:\Program Files\projects\Tiunov\Tiunov_BD.mdb");
            da = new OleDbDataAdapter("SELECT * FROM Exponat", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Exponat");
            dataGridView3.DataSource = ds.Tables["Exponat"];
            con.Close();
        }
        public void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;
            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else
                        func(control.Controls);
                foreach (Control control in controls)
                    if (control is ComboBox)
                        (control as ComboBox).SelectedValue = -1;
                    else
                        func(control.Controls);
            };

            func(Controls);
        }
        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tiunov_BDDataSet.Grafiki". При необходимости она может быть перемещена или удалена.
            this.grafikiTableAdapter.Fill(this.tiunov_BDDataSet.Grafiki);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tiunov_BDDataSet.Kvalifikacya". При необходимости она может быть перемещена или удалена.
            this.kvalifikacyaTableAdapter.Fill(this.tiunov_BDDataSet.Kvalifikacya);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tiunov_BDDataSet.Exponat". При необходимости она может быть перемещена или удалена.
            this.exponatTableAdapter.Fill(this.tiunov_BDDataSet.Exponat);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tiunov_BDDataSet.Sotrudniki". При необходимости она может быть перемещена или удалена.
            this.sotrudnikiTableAdapter.Fill(this.tiunov_BDDataSet.Sotrudniki);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tiunov_BDDataSet.Pomeshenya". При необходимости она может быть перемещена или удалена.
            this.pomeshenyaTableAdapter.Fill(this.tiunov_BDDataSet.Pomeshenya);
            Pnum.Visible = false;
            Snum.Visible = false;
            Enum.Visible = false;
            GetPom();
        }
        private void btnInsert_Click(object sender, EventArgs e)
        {
            string query = "Insert into Pomeshenya (Padres,Pnaz, Ptreb) values (@Padres,@Pnaz,@Ptreb)";
            cmd = new OleDbCommand(query, con);
            cmd.Parameters.AddWithValue("@Padres", Padres.Text);
            cmd.Parameters.AddWithValue("@Pnaz", Pnaz.Text);
            cmd.Parameters.AddWithValue("@Ptreb", Ptreb.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GetPom();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверенны, что хотите удалить запись?", "Удалить запись", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "Delete From Pomeshenya Where Pnum=@Pnum";
                cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@Pnum", dataGridView1.CurrentRow.Cells[0].Value);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                GetPom();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            string query = "Update Pomeshenya Set Padres=@Padres,Pnaz=@Pnaz,Ptreb=@Ptreb Where Pnum=@Pnum";
            cmd = new OleDbCommand(query, con);
            cmd.Parameters.AddWithValue("@Padres", Padres.Text);
            cmd.Parameters.AddWithValue("@Pnaz", Pnaz.Text);
            cmd.Parameters.AddWithValue("@Ptreb", Ptreb.Text);
            cmd.Parameters.AddWithValue("@Pnum", Convert.ToInt32(Pnum.Text));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GetPom();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void сменитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Authorization frm1 = new Authorization();
            frm1.Show();
            this.Hide();
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Курсовой проект МДК 4:\nИнформационная система музейного комплекса\nАвтор: Тиунов Максим, студент группы ИП-41");
        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Pnum.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
            Padres.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Pnaz.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Ptreb.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
        }

        private void SbtnInsert_Click(object sender, EventArgs e)
        {
            string query = "Insert into Sotrudniki (Sfam,Snam, Sotch, Skval, Sgraf, Login, Pass) values (@Sfam,@Snam,@Sotch,@Skval,@Sgraf,@Login,@Pass)";
            cmd = new OleDbCommand(query, con);
            cmd.Parameters.AddWithValue("@Sfam", Sfam.Text);
            cmd.Parameters.AddWithValue("@Snam", Snam.Text);
            cmd.Parameters.AddWithValue("@Sotch", Sotch.Text);
            cmd.Parameters.AddWithValue("@Skval", Skval.SelectedValue);
            cmd.Parameters.AddWithValue("@Sgraf", Sgraf.SelectedValue);
            cmd.Parameters.AddWithValue("@Login", Login.Text);
            cmd.Parameters.AddWithValue("@Pass", Pass.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GetSotr();
        }

        private void SbtnUpdate_Click(object sender, EventArgs e)
        {
            string query = "Update Sotrudniki Set Sfam=@Sfam,Snam=@Snam,Sotch=@Sotch,Skval=@Skval,Sgraf=@Sgraf, Login=@Login,Pass=@Pass Where Snum=@Snum";
            cmd = new OleDbCommand(query, con);
            cmd.Parameters.AddWithValue("@Sfam", Sfam.Text);
            cmd.Parameters.AddWithValue("@Snam", Snam.Text);
            cmd.Parameters.AddWithValue("@Sotch", Sotch.Text);
            cmd.Parameters.AddWithValue("@Skval", Skval.SelectedValue);
            cmd.Parameters.AddWithValue("@Sgraf", Sgraf.SelectedValue);
            cmd.Parameters.AddWithValue("@Login", Login.Text);
            cmd.Parameters.AddWithValue("@Pass", Pass.Text);
            cmd.Parameters.AddWithValue("@Snum", Convert.ToInt32(Snum.Text));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GetSotr();
        }

        private void SbtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверенны, что хотите удалить запись?", "Удалить запись", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "Delete From Sotrudniki Where Snum=@Snum";
                cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@Snum", dataGridView2.CurrentRow.Cells[0].Value);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                GetSotr();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Snum.Text = dataGridView2.CurrentRow.Cells[0].Value.ToString();
            Sfam.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            Snam.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            Sotch.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            Skval.SelectedValue = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            Sgraf.SelectedValue = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            Login.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            Pass.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
        }

        private void EbtnInsert_Click(object sender, EventArgs e)
        {
            string query = "Insert into Exponat (Enam,Etip) values (@Enam,@Etip)";
            cmd = new OleDbCommand(query, con);
            cmd.Parameters.AddWithValue("@Enam", Enam.Text);
            cmd.Parameters.AddWithValue("@Etip", Etip.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GetExp();
        }

        private void EbtnUpdate_Click(object sender, EventArgs e)
        {
            string query = "Update Exponat Set Enam=@Enam,Etip=@Etip Where Enum=@Enum";
            cmd = new OleDbCommand(query, con);
            cmd.Parameters.AddWithValue("@Enam", Enam.Text);
            cmd.Parameters.AddWithValue("@Etip", Etip.Text);
            cmd.Parameters.AddWithValue("@Enum", Convert.ToInt32(Enum.Text));
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GetExp();
        }

        private void EbtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверенны, что хотите удалить запись?", "Удалить запись", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "Delete From Exponat Where Enum=@Enum";
                cmd = new OleDbCommand(query, con);
                cmd.Parameters.AddWithValue("@Enum", dataGridView3.CurrentRow.Cells[0].Value);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                GetExp();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void dataGridView3_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Enum.Text = dataGridView3.CurrentRow.Cells[0].Value.ToString();
            Enam.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            Etip.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void SbtnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }

        private void EbtnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
        }
    }
}
