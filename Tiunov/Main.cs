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
    public partial class Main : Form
    {
        DataSet ds;
        SqlDataAdapter da;
        SqlCommand cmd;
        SqlConnection con;
        public Main(string text)
        {
            InitializeComponent();
            string access = text;
            textBox1.Text = access;
        }
        void GetCon()
        {
            con = new SqlConnection(@"Data Source=FICHER;Initial Catalog=Tiunov;Integrated Security=True");
        }
        void GetPom()
        {
            GetCon();
            da = new SqlDataAdapter("SELECT * FROM Pomeshenya", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Pomeshenya");
            dataGridView1.DataSource = ds.Tables["Pomeshenya"];
            con.Close();
        }
        void GetSotr()
        {
            da = new SqlDataAdapter("SELECT * FROM Sotrudniki", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Sotrudniki");
            dataGridView2.DataSource = ds.Tables["Sotrudniki"];
            con.Close();
        }
        void GetExp()
        {
            da = new SqlDataAdapter("SELECT * FROM Exponat", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Exponat");
            dataGridView3.DataSource = ds.Tables["Exponat"];
            con.Close();
        }
        void GetRest()
        {
            da = new SqlDataAdapter("SELECT * FROM Restavracia", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Restavracia");
            dataGridView4.DataSource = ds.Tables["Restavracia"];
            con.Close();
        }
        public void ClearTextBoxes(TabPage tabPageName)
        {
            foreach (Control control in tabPageName.Controls)
            {
                if (control is TextBox)
                {
                    control.Text = string.Empty;
                }

                if (control is ComboBox)
                {
                    (control as ComboBox).SelectedValue = -1;
                }

                if (control is MaskedTextBox)
                {
                    control.Text = string.Empty;
                }
            }
        }
        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tiunovDataSet.Accesses". При необходимости она может быть перемещена или удалена.
            this.accessesTableAdapter.Fill(this.tiunovDataSet.Accesses);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tiunovDataSet.Sotrudniki". При необходимости она может быть перемещена или удалена.
            this.sotrudnikiTableAdapter.Fill(this.tiunovDataSet.Sotrudniki);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tiunovDataSet.Restavracia". При необходимости она может быть перемещена или удалена.
            this.restavraciaTableAdapter.Fill(this.tiunovDataSet.Restavracia);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tiunovDataSet.Restoration_status". При необходимости она может быть перемещена или удалена.
            this.restoration_statusTableAdapter.Fill(this.tiunovDataSet.Restoration_status);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tiunovDataSet.Pomeshenya". При необходимости она может быть перемещена или удалена.
            this.pomeshenyaTableAdapter.Fill(this.tiunovDataSet.Pomeshenya);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tiunovDataSet.Exponat_tip". При необходимости она может быть перемещена или удалена.
            this.exponat_tipTableAdapter.Fill(this.tiunovDataSet.Exponat_tip);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tiunovDataSet.Kvalifikacya". При необходимости она может быть перемещена или удалена.
            this.kvalifikacyaTableAdapter.Fill(this.tiunovDataSet.Kvalifikacya);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tiunovDataSet.Exponat". При необходимости она может быть перемещена или удалена.
            this.exponatTableAdapter.Fill(this.tiunovDataSet.Exponat);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tiunovDataSet.Grafiki". При необходимости она может быть перемещена или удалена.
            this.grafikiTableAdapter.Fill(this.tiunovDataSet.Grafiki);
            GetPom();
            GetSotr();
            GetExp();
            GetRest();
            if (textBox1.Text =="2")
            {
                //Помещения
                PbtnInsert.Visible = false;
                PbtnUpdate.Visible = false;
                PbtnDelete.Visible = false;
                PbtnClear.Visible = false;
                Pnam.Enabled = false;
                Padres.Enabled = false;
                Pnaz.Enabled = false;
                Ptreb.Enabled = false;
                //Сотрудники
                label13.Visible = false;
                label14.Visible = false;
                SbtnInsert.Visible = false;
                SbtnUpdate.Visible = false;
                SbtnDelete.Visible = false;
                SbtnClear.Visible = false;
                Sbtncbupd.Visible = false;
                Sfam.Enabled = false;
                Snam.Enabled = false;
                Sotch.Enabled = false;
                Stel.Enabled = false;
                Skval.Enabled = false;
                Sgraf.Enabled = false;
                Login.Visible = false;
                Pass.Visible = false;
                cb_saccess.Enabled = false;
                AddKval.Visible = false;
                AddGraf.Visible = false;
                //Экспонаты
                EbtnInsert.Visible = false;
                EbtnUpdate.Visible = false;
                EbtnDelete.Visible = false;
                EbtnClear.Visible = false;
                Ebtncbupd.Visible = false;
                Enam.Enabled = false;
                Cb_etip.Enabled = false;
                Ecena.Enabled = false;
                Cb_pnum.Enabled = false;
                AddTips.Visible = false;
                //Реставрация
                RbtnInsert.Visible = false;
                RbtnDelete.Visible = false;
                RbtnClear.Visible = false;
                Rbtncbupd.Visible = false;
                cb_enum.Enabled = false;
                AddStatus.Visible = false;
            }
        }

        private void PbtnInsert_Click(object sender, EventArgs e)
        {
            if (Pnam.Text == "" || Padres.Text == "" || Pnaz.Text == "" || Ptreb.Text == "")
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            string query = "Insert into Pomeshenya (Pnam, Padres, Pnaz, Ptreb) values (@Pnam,@Padres,@Pnaz,@Ptreb)";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Pnam", Pnam.Text);
            cmd.Parameters.AddWithValue("@Padres", Padres.Text);
            cmd.Parameters.AddWithValue("@Pnaz", Pnaz.Text);
            cmd.Parameters.AddWithValue("@Ptreb", Ptreb.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GetPom();
        }
        private void PbtnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите редактировать запись?", "Редактировать запись", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "Update Pomeshenya Set Pnam=@Pnam,Padres=@Padres,Pnaz=@Pnaz,Ptreb=@Ptreb Where Pnum=@Pnum";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Pnam", Pnam.Text);
                cmd.Parameters.AddWithValue("@Padres", Padres.Text);
                cmd.Parameters.AddWithValue("@Pnaz", Pnaz.Text);
                cmd.Parameters.AddWithValue("@Ptreb", Ptreb.Text);
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
        private void PbtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить запись?", "Удалить запись", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {

                string query = "Delete From Pomeshenya Where Pnum=@Pnum";
                cmd = new SqlCommand(query, con);
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
        private void PbtnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(tabPage1);  
        }
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Pnam.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
            Padres.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
            Pnaz.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();
            Ptreb.Text = dataGridView1.CurrentRow.Cells[4].Value.ToString();
        }

        private void статистикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statistics Statistics = new Statistics();
            Statistics.Show();
        }
        private void выходToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите выйти из программы?", "Выйти из программы", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Close();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void сменитьПользователяToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите сменить пользователя?", "Сменить пользователя", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Authorization Authorization = new Authorization();
                Authorization.Show();
                this.Hide();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Курсовой проект МДК 4:\nИнформационная система музейного комплекса\nАвтор: Тиунов Максим, студент группы ИП-41");
        }
        private void SbtnInsert_Click(object sender, EventArgs e)
        {
            if (Sfam.Text == "" || Snam.Text == "" || Sotch.Text == "" || Stel.MaskCompleted == false || Skval.SelectedIndex == -1 || Sgraf.SelectedIndex == -1 || Login.Text == "" || Pass.Text == "" || cb_saccess.SelectedIndex == -1)
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            for (int i = 0; i < dataGridView2.RowCount - 1; i++)
                if (dataGridView2.Rows[i].Cells[4].Value.ToString() == Stel.Text)//------------- проверка найдено ли такое же значение в колонки с primary key 
            {
                MessageBox.Show("Сотрудник с таким номером телефона уже существует");
                return;
            }
            string query = "Insert into Sotrudniki (Sfam,Snam, Sotch, Stel, Skval, Sgraf, Login, Pass, Saccess) values (@Sfam,@Snam,@Sotch,@Stel,@Skval,@Sgraf,@Login,@Pass, @Saccess)";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Sfam", Sfam.Text);
            cmd.Parameters.AddWithValue("@Snam", Snam.Text);
            cmd.Parameters.AddWithValue("@Sotch", Sotch.Text);
            cmd.Parameters.AddWithValue("@Stel", Stel.Text);
            cmd.Parameters.AddWithValue("@Skval", Skval.SelectedValue);
            cmd.Parameters.AddWithValue("@Sgraf", Sgraf.SelectedValue);
            cmd.Parameters.AddWithValue("@Login", Login.Text);
            cmd.Parameters.AddWithValue("@Pass", Pass.Text);
            cmd.Parameters.AddWithValue("@Saccess", cb_saccess.SelectedValue);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GetSotr();
        }
        private void SbtnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите редактировать запись?", "Редактировать запись", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "Update Sotrudniki Set Sfam=@Sfam,Snam=@Snam,Sotch=@Sotch,Stel=@Stel,Skval=@Skval,Sgraf=@Sgraf,Login=@Login,Pass=@Pass,Saccess=@Saccess Where Snum=@Snum";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Snum", dataGridView2.CurrentRow.Cells[0].Value);
                cmd.Parameters.AddWithValue("@Sfam", Sfam.Text);
                cmd.Parameters.AddWithValue("@Snam", Snam.Text);
                cmd.Parameters.AddWithValue("@Sotch", Sotch.Text);
                cmd.Parameters.AddWithValue("@Stel", Stel.Text);
                cmd.Parameters.AddWithValue("@Skval", Skval.SelectedValue);
                cmd.Parameters.AddWithValue("@Sgraf", Sgraf.SelectedValue);
                cmd.Parameters.AddWithValue("@Login", Login.Text);
                cmd.Parameters.AddWithValue("@Pass", Pass.Text);
                cmd.Parameters.AddWithValue("@Saccess", cb_saccess.SelectedValue);
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
        private void SbtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить запись?", "Удалить запись", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "Delete From Sotrudniki Where Snum=@Snum";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Snum", dataGridView2.CurrentRow.Cells[0].Value);
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
                GetSotr();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
        private void SbtnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(tabPage2);
        }
        private void dataGridView2_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Sfam.Text = dataGridView2.CurrentRow.Cells[1].Value.ToString();
            Snam.Text = dataGridView2.CurrentRow.Cells[2].Value.ToString();
            Sotch.Text = dataGridView2.CurrentRow.Cells[3].Value.ToString();
            Stel.Text = dataGridView2.CurrentRow.Cells[4].Value.ToString();
            Skval.SelectedValue = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            Sgraf.SelectedValue = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            Login.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
            Pass.Text = dataGridView2.CurrentRow.Cells[8].Value.ToString();
            cb_saccess.SelectedValue = dataGridView2.CurrentRow.Cells[9].Value.ToString();
        }
        private void EbtnInsert_Click(object sender, EventArgs e)
        {
            if (Enam.Text == "" || Cb_etip.SelectedIndex == -1 || Ecena.Text == "" || Cb_pnum.SelectedIndex == -1)
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            string query = "Insert into Exponat (Enam, Etip, Ecena, Pnum) values (@Enam,@Etip,@Ecena,@Pnum)";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Enam", Enam.Text);
            cmd.Parameters.AddWithValue("@Etip", Cb_etip.SelectedValue);
            cmd.Parameters.AddWithValue("@Ecena", Ecena.Text);
            cmd.Parameters.AddWithValue("@Pnum", Cb_pnum.SelectedValue);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GetExp();
        }

        private void EbtnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите редактировать запись?", "Редактировать запись", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "Update Exponat Set Enam=@Enam,Etip=@Etip,Ecena=@Ecena, Pnum=@Pnum Where Enum=@Enum";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Enam", Enam.Text);
                cmd.Parameters.AddWithValue("@Etip", Cb_etip.SelectedValue);
                cmd.Parameters.AddWithValue("@Ecena", Ecena.Text);
                cmd.Parameters.AddWithValue("@Pnum", Cb_pnum.SelectedValue);
                cmd.Parameters.AddWithValue("@Enum", Convert.ToInt32(dataGridView3.CurrentRow.Cells[0].Value));
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

        private void EbtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить запись?", "Удалить запись", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "Delete From Exponat Where Enum=@Enum";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Enum", dataGridView3.CurrentRow.Cells[0].Value);
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
                GetExp();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
        private void EbtnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(tabPage3);
        }
        private void dataGridView3_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            Enam.Text = dataGridView3.CurrentRow.Cells[1].Value.ToString();
            Cb_etip.SelectedValue = dataGridView3.CurrentRow.Cells[2].Value.ToString();
            Ecena.Text = dataGridView3.CurrentRow.Cells[3].Value.ToString();
            Cb_pnum.SelectedValue = dataGridView3.CurrentRow.Cells[4].Value.ToString();
        }

        private void AddGraf_Click(object sender, EventArgs e)
        {
            Charts Charts = new Charts();
            Charts.Show();
        }

        private void AddKval_Click(object sender, EventArgs e)
        {
            Qualifications Qualifications = new Qualifications();
            Qualifications.Show();
        }

        private void RbtnInsert_Click(object sender, EventArgs e)
        {
            if (cb_enum.SelectedIndex == -1 || cb_rstatus.SelectedIndex == -1)
            {
                MessageBox.Show("Заполните все поля");
                return;
            }
            string query = "Insert into Restavracia (Enum, Rstatus) values (@Enum,@Rstatus)";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Enum", cb_enum.SelectedValue);
            cmd.Parameters.AddWithValue("@Rstatus", cb_rstatus.SelectedValue);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GetRest();
        }

        private void RbtnUpdate_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите редактировать запись?", "Редактировать запись", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "Update Restavracia Set Enum=@Enum,Rstatus=@Rstatus Where Rnum=@Rnum";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Enum", cb_enum.SelectedValue);
                cmd.Parameters.AddWithValue("@Rstatus", cb_rstatus.SelectedValue);
                cmd.Parameters.AddWithValue("@Rnum", dataGridView4.CurrentRow.Cells[0].Value);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                GetRest();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }

        private void RbtnDelete_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите удалить запись?", "Удалить запись", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "Delete From Restavracia Where Rnum=@Rnum";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Rnum", dataGridView4.CurrentRow.Cells[0].Value);
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
                GetRest();
            }
            else if (dialogResult == DialogResult.No)
            {
                return;
            }
        }
        private void RbtnClear_Click(object sender, EventArgs e)
        {
            ClearTextBoxes(tabPage4);
        }
        private void dataGridView4_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            cb_enum.SelectedValue = dataGridView4.CurrentRow.Cells[1].Value.ToString();
            cb_rstatus.SelectedValue = dataGridView4.CurrentRow.Cells[2].Value.ToString();
        }

        private void AddTips_Click(object sender, EventArgs e)
        {
            Tips_Exp Tips_Exp = new Tips_Exp();
            Tips_Exp.Show();
        }

        private void AddStatus_Click(object sender, EventArgs e)
        {
            Restoration_status Restoration_status = new Restoration_status();
            Restoration_status.Show();
        }

        private void Stel_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void Sbtncbupd_Click(object sender, EventArgs e)
        {
            this.grafikiTableAdapter.Fill(this.tiunovDataSet.Grafiki);
            this.kvalifikacyaTableAdapter.Fill(this.tiunovDataSet.Kvalifikacya);
        }
        private void Ebtncbupd_Click(object sender, EventArgs e)
        {
            this.exponat_tipTableAdapter.Fill(this.tiunovDataSet.Exponat_tip);
            this.pomeshenyaTableAdapter.Fill(this.tiunovDataSet.Pomeshenya);
        }
        private void Rbtncbupd_Click(object sender, EventArgs e)
        {
            this.restoration_statusTableAdapter.Fill(this.tiunovDataSet.Restoration_status);
            this.exponatTableAdapter.Fill(this.tiunovDataSet.Exponat);
        }

        private void Ecena_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (Char.IsDigit(e.KeyChar)) return;
            else
                e.Handled = true;
        }

        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
