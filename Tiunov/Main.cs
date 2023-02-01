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
        string Access;
        DataSet ds;
        SqlDataAdapter da;
        SqlCommand cmd;
        SqlConnection con;
        public Main(string Saccess)
        {
            InitializeComponent();
            Access = Saccess;
        }
        #region Methods
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
            da = new SqlDataAdapter("SELECT Sotrudniki.Snum, Sotrudniki.Sfam, Sotrudniki.Snam, Sotrudniki.Sotch, Sotrudniki.Stel, Kvalifikacya.Kval, Grafiki.Grafik, Sotrudniki.Login, Sotrudniki.Pass, Accesses.Access FROM Sotrudniki INNER JOIN Accesses ON Sotrudniki.Saccess = Accesses.Saccess INNER JOIN Grafiki ON Sotrudniki.Sgraf = Grafiki.Sgraf INNER JOIN Kvalifikacya ON Sotrudniki.Skval = Kvalifikacya.Skval", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Sotrudniki");
            dataGridView2.DataSource = ds.Tables["Sotrudniki"];
            con.Close();
        }
        void GetExp()
        {
            da = new SqlDataAdapter("SELECT Exponat.Enum, Exponat.Enam, Exponat_tip.Tip, Exponat.Ecena, Pomeshenya.Pnam FROM Exponat INNER JOIN Exponat_tip ON Exponat.Etip = Exponat_tip.Etip INNER JOIN Pomeshenya ON Exponat.Pnum = Pomeshenya.Pnum", con);
            ds = new DataSet();
            con.Open();
            da.Fill(ds, "Exponat");
            dataGridView3.DataSource = ds.Tables["Exponat"];
            con.Close();
        }
        void GetRest()
        {
            da = new SqlDataAdapter("SELECT Restavracia.Rnum, Exponat.Enam, Restoration_status.Status, Sotrudniki.Sfam + ' ' + Sotrudniki.Snam + ' ' + Sotrudniki.Sotch + ' (' + Kvalifikacya.Kval + ')' AS 'Сотрудник (Квалификация)', Restavracia.Rstart, Restavracia.Rfinish FROM Restavracia INNER JOIN Restoration_status ON Restavracia.Rstatus = Restoration_status.Rstatus INNER JOIN Exponat ON Restavracia.Enum = Exponat.Enum INNER JOIN Sotrudniki ON Restavracia.Snum = Sotrudniki.Snum INNER JOIN Kvalifikacya ON Sotrudniki.Skval = Kvalifikacya.Skval", con);
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
        private void статистикаToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Statistics Statistics = new Statistics();
            Statistics.ShowDialog();
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
        private void Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        #endregion
        #region Main Form and Load
        private void Main_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tiunovDataSet.rest". При необходимости она может быть перемещена или удалена.
            this.restTableAdapter.Fill(this.tiunovDataSet.rest);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tiunovDataSet.rest". При необходимости она может быть перемещена или удалена.
            this.restTableAdapter.Fill(this.tiunovDataSet.rest);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tiunovDataSet2.Sotrudniki1". При необходимости она может быть перемещена или удалена.
            this.sotrudniki1TableAdapter.Fill(this.tiunovDataSet2.Sotrudniki1);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tiunovDataSet.Pomeshenya". При необходимости она может быть перемещена или удалена.
            this.pomeshenyaTableAdapter.Fill(this.tiunovDataSet.Pomeshenya);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tiunovDataSet.Sotrudniki". При необходимости она может быть перемещена или удалена.
            this.sotrudnikiTableAdapter.Fill(this.tiunovDataSet.Sotrudniki);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tiunovDataSet.Exp". При необходимости она может быть перемещена или удалена.
            this.expTableAdapter.Fill(this.tiunovDataSet.Exp);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tiunovDataSet.Sotr". При необходимости она может быть перемещена или удалена.
            this.sotrTableAdapter.Fill(this.tiunovDataSet.Sotr);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tiunovDataSet.Accesses". При необходимости она может быть перемещена или удалена.
            this.accessesTableAdapter.Fill(this.tiunovDataSet.Accesses);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tiunovDataSet.Restoration_status". При необходимости она может быть перемещена или удалена.
            this.restoration_statusTableAdapter.Fill(this.tiunovDataSet.Restoration_status);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tiunovDataSet.Pomeshenya". При необходимости она может быть перемещена или удалена.
            this.pomeshenyaTableAdapter.Fill(this.tiunovDataSet.Pomeshenya);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tiunovDataSet.Exponat_tip". При необходимости она может быть перемещена или удалена.
            this.exponat_tipTableAdapter.Fill(this.tiunovDataSet.Exponat_tip);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tiunovDataSet.Kvalifikacya". При необходимости она может быть перемещена или удалена.
            this.kvalifikacyaTableAdapter.Fill(this.tiunovDataSet.Kvalifikacya);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tiunovDataSet.Grafiki". При необходимости она может быть перемещена или удалена.
            this.grafikiTableAdapter.Fill(this.tiunovDataSet.Grafiki);
            GetPom();
            GetSotr();
            GetExp();
            GetRest();
            #region UserCheck
            if (Access == "2")
            {
                //Помещения
                label1.Visible = false;
                label2.Visible = false;
                label3.Visible = false;
                label19.Visible = false;
                PbtnInsert.Visible = false;
                PbtnUpdate.Visible = false;
                PbtnDelete.Visible = false;
                PbtnClear.Visible = false;
                Pnam.Visible = false;
                Padres.Visible = false;
                Pnaz.Visible = false;
                Ptreb.Visible = false;
                //Сотрудники
                label4.Visible = false;
                label5.Visible = false;
                label6.Visible = false;
                label10.Visible = false;
                label11.Visible = false;
                label12.Visible = false;
                label13.Visible = false;
                label14.Visible = false;
                label15.Visible = false;
                SbtnInsert.Visible = false;
                SbtnUpdate.Visible = false;
                SbtnDelete.Visible = false;
                SbtnClear.Visible = false;
                Sbtncbupd.Visible = false;
                Sfam.Visible = false;
                Snam.Visible = false;
                Sotch.Visible = false;
                Stel.Visible = false;
                Skval.Visible = false;
                Sgraf.Visible = false;
                Login.Visible = false;
                Pass.Visible = false;
                cb_saccess.Visible = false;
                AddKval.Visible = false;
                AddGraf.Visible = false;
                dataGridView2.Columns[7].Visible = false;
                dataGridView2.Columns[8].Visible = false;
                dataGridView2.Columns[9].Visible = false;
                //Экспонаты
                label7.Visible = false;
                label8.Visible = false;
                label9.Visible = false;
                label18.Visible = false;
                EbtnInsert.Visible = false;
                EbtnUpdate.Visible = false;
                EbtnDelete.Visible = false;
                EbtnClear.Visible = false;
                Ebtncbupd.Visible = false;
                Enam.Visible = false;
                Cb_etip.Visible = false;
                Ecena.Visible = false;
                Cb_pnum.Visible = false;
                AddTips.Visible = false;
                //Реставрация
                label16.Visible = false;
                label17.Visible = false;
                label24.Visible = false;
                RbtnInsert.Visible = false;
                RbtnUpdate.Visible = false;
                RbtnDelete.Visible = false;
                RbtnClear.Visible = false;
                Rbtncbupd.Visible = false;
                cb_enum.Visible = false;
                cb_rstatus.Visible = false;
                cb_snum.Visible = false;
                AddStatus.Visible = false;
            }
        }
        #endregion
        #endregion
        #region Pomeshenya
        private void PbtnInsert_Click(object sender, EventArgs e)
        {
            if (Pnam.Text == "" || Padres.Text == "" || Pnaz.Text == "" || Ptreb.Text == "" || Popis.Text == "")
            {
                MessageBox.Show("Пожалуйста, заполните все поля!");
                return;
            }
            string query = "Insert into Pomeshenya (Pnam, Padres, Pnaz, Ptreb, Popis) values (@Pnam,@Padres,@Pnaz,@Ptreb,@Popis)";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Pnam", Pnam.Text);
            cmd.Parameters.AddWithValue("@Padres", Padres.Text);
            cmd.Parameters.AddWithValue("@Pnaz", Pnaz.Text);
            cmd.Parameters.AddWithValue("@Ptreb", Ptreb.Text);
            cmd.Parameters.AddWithValue("@Popis", Popis.Text);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GetPom();
            toolStripStatusLabel1.Text = "Запись была добавлена!";
        }
        private void PbtnUpdate_Click(object sender, EventArgs e)
        {
            if (Pnam.Text == "" || Padres.Text == "" || Pnaz.Text == "" || Ptreb.Text == "" || Popis.Text == "")
            {
                MessageBox.Show("Пожалуйста, заполните все поля!");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите редактировать запись?", "Редактировать запись", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "Update Pomeshenya Set Pnam=@Pnam,Padres=@Padres,Pnaz=@Pnaz,Ptreb=@Ptreb,Popis=@Popis Where Pnum=@Pnum";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Pnam", Pnam.Text);
                cmd.Parameters.AddWithValue("@Padres", Padres.Text);
                cmd.Parameters.AddWithValue("@Pnaz", Pnaz.Text);
                cmd.Parameters.AddWithValue("@Ptreb", Ptreb.Text);
                cmd.Parameters.AddWithValue("@Popis", Popis.Text);
                cmd.Parameters.AddWithValue("@Pnum", dataGridView1.CurrentRow.Cells[0].Value);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                GetPom();
                toolStripStatusLabel1.Text = "Запись была изменена!";
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
                toolStripStatusLabel1.Text = "Запись была удалена!";
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
            Popis.Text = dataGridView1.CurrentRow.Cells[5].Value.ToString();
        }
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"[Pnam] LIKE '%{textBox1.Text}%'";
        }
        #endregion
        #region Sotrudniki
        private void SbtnInsert_Click(object sender, EventArgs e)
        {
            if (Sfam.Text == "" || Snam.Text == "" || Sotch.Text == "" || Stel.MaskCompleted == false || Skval.SelectedIndex == -1 || Sgraf.SelectedIndex == -1 || Login.Text == "" || Pass.Text == "" || cb_saccess.SelectedIndex == -1)
            {
                MessageBox.Show("Пожалуйста, заполните все поля!");
                return;
            }
            for (int i = 0; i < dataGridView2.RowCount; i++)
            {
                if (dataGridView2.Rows[i].Cells[4].Value.ToString() == Stel.Text)
                {
                    MessageBox.Show("Сотрудник с таким номером телефона уже существует!");
                    return;
                }

                if (dataGridView2.Rows[i].Cells[7].Value.ToString() == Login.Text)
                {
                    MessageBox.Show("Сотрудник с таким логином уже существует!");
                    return;
                }
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
            toolStripStatusLabel2.Text = "Запись была добавлена!";
        }
        private void SbtnUpdate_Click(object sender, EventArgs e)
        {
            if (Sfam.Text == "" || Snam.Text == "" || Sotch.Text == "" || Stel.MaskCompleted == false || Skval.SelectedIndex == -1 || Sgraf.SelectedIndex == -1 || Login.Text == "" || Pass.Text == "" || cb_saccess.SelectedIndex == -1)
            {
                MessageBox.Show("Пожалуйста, заполните все поля!");
                return;
            }
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
                toolStripStatusLabel2.Text = "Запись была изменена!";
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
                cmd.ExecuteNonQuery();
                con.Close();
                GetSotr();
                toolStripStatusLabel2.Text = "Запись была удалена!";
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
            Skval.Text = dataGridView2.CurrentRow.Cells[5].Value.ToString();
            Sgraf.Text = dataGridView2.CurrentRow.Cells[6].Value.ToString();
            Login.Text = dataGridView2.CurrentRow.Cells[7].Value.ToString();
            Pass.Text = dataGridView2.CurrentRow.Cells[8].Value.ToString();
            cb_saccess.Text = dataGridView2.CurrentRow.Cells[9].Value.ToString();
        }
        private void Stel_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8) //Если символ, введенный с клавы - не цифра (IsDigit),
            {
                e.Handled = true;// то событие не обрабатывается. ch!=8 (8 - это Backspace)
            }
        }

        private void Sbtncbupd_Click(object sender, EventArgs e)
        {
            this.grafikiTableAdapter.Fill(this.tiunovDataSet.Grafiki);
            this.kvalifikacyaTableAdapter.Fill(this.tiunovDataSet.Kvalifikacya);
            GetSotr();
        }
        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            (dataGridView2.DataSource as DataTable).DefaultView.RowFilter = $"[Sfam] LIKE '%{textBox2.Text}%'";
        }
        private void Login_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '_' || e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                MessageBox.Show("Логин должен состоять из символов латинского алфавита");
                e.Handled = true;
            }
        }
        private void Pass_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((e.KeyChar >= 'A' && e.KeyChar <= 'Z') || (e.KeyChar >= 'a' && e.KeyChar <= 'z') || (e.KeyChar >= '0' && e.KeyChar <= '9') || e.KeyChar == '_' || e.KeyChar == (char)Keys.Back)
            {
            }
            else
            {
                MessageBox.Show("Пароль должен состоять из символов латинского алфавита");
                e.Handled = true;
            }
        }
        #endregion
        #region Exponat
        private void EbtnInsert_Click(object sender, EventArgs e)
        {
            if (Enam.Text == "" || Cb_etip.SelectedIndex == -1 || Ecena.Text == "" || Cb_pnum.SelectedIndex == -1)
            {
                MessageBox.Show("Пожалуйста, заполните все поля!");
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
            toolStripStatusLabel3.Text = "Запись была добавлена!";
        }

        private void EbtnUpdate_Click(object sender, EventArgs e)
        {
            if (Enam.Text == "" || Cb_etip.SelectedIndex == -1 || Ecena.Text == "" || Cb_pnum.SelectedIndex == -1)
            {
                MessageBox.Show("Пожалуйста, заполните все поля!");
                return;
            }
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
                toolStripStatusLabel3.Text = "Запись была изменена!";
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
                cmd.ExecuteNonQuery();
                con.Close();
                GetExp();
                toolStripStatusLabel3.Text = "Запись была удалена!";
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
            Cb_etip.Text = dataGridView3.CurrentRow.Cells[2].Value.ToString();
            Ecena.Text = dataGridView3.CurrentRow.Cells[3].Value.ToString();
            Cb_pnum.Text = dataGridView3.CurrentRow.Cells[4].Value.ToString();
        }
        private void AddGraf_Click(object sender, EventArgs e)
        {
            Charts Charts = new Charts();
            Charts.ShowDialog();
        }

        private void AddKval_Click(object sender, EventArgs e)
        {
            Qualifications Qualifications = new Qualifications();
            Qualifications.ShowDialog();
        }
        private void Ebtncbupd_Click(object sender, EventArgs e)
        {
            this.exponat_tipTableAdapter.Fill(this.tiunovDataSet.Exponat_tip);
            this.pomeshenyaTableAdapter.Fill(this.tiunovDataSet.Pomeshenya);
            GetExp();
        }
        private void Ecena_KeyPress(object sender, KeyPressEventArgs e)
        {
            char ch = e.KeyChar;
            if (!Char.IsDigit(ch) && ch != 8) //Если символ, введенный с клавы - не цифра (IsDigit),
            {
                e.Handled = true;// то событие не обрабатывается. ch!=8 (8 - это Backspace)
            }
        }
        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            (dataGridView3.DataSource as DataTable).DefaultView.RowFilter = $"[Enam] LIKE '%{textBox3.Text}%'";
        }
        #endregion
        #region Restavracia
        private void RbtnInsert_Click(object sender, EventArgs e)
        {
            if (cb_enum.SelectedIndex == -1 || cb_rstatus.SelectedIndex == -1 || cb_snum.SelectedIndex == -1)
            {
                MessageBox.Show("Пожалуйста, заполните все поля!");
                return;
            }
            for (int i = 0; i < dataGridView4.RowCount; i++)
            {
                if (dataGridView4.Rows[i].Cells[1].Value.ToString() == cb_enum.Text)
                {
                    MessageBox.Show("Запись о данном экспонате уже существует");
                    return;
                }
            }
            string query = "Insert into Restavracia (Enum, Rstatus, Snum, Rstart) values (@Enum,@Rstatus,@Snum,@Rstart)";
            cmd = new SqlCommand(query, con);
            cmd.Parameters.AddWithValue("@Enum", cb_enum.SelectedValue);
            cmd.Parameters.AddWithValue("@Rstatus", cb_rstatus.SelectedValue);
            cmd.Parameters.AddWithValue("@Snum", cb_snum.SelectedValue);
            cmd.Parameters.AddWithValue("@Rstart", DateTime.Now);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
            GetRest();
            toolStripStatusLabel4.Text = "Запись была добавлена!";
        }

        private void RbtnUpdate_Click(object sender, EventArgs e)
        {
            if (cb_enum.SelectedIndex == -1 || cb_rstatus.SelectedIndex == -1 || cb_snum.SelectedIndex == -1)
            {
                MessageBox.Show("Пожалуйста, заполните все поля!");
                return;
            }
            DialogResult dialogResult = MessageBox.Show("Вы уверены, что хотите редактировать запись?", "Редактировать запись", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                string query = "Update Restavracia Set Enum=@Enum,Rstatus=@Rstatus,Snum=@Snum,Rfinish=@Rfinish Where Rnum=@Rnum";
                cmd = new SqlCommand(query, con);
                cmd.Parameters.AddWithValue("@Enum", cb_enum.SelectedValue);
                cmd.Parameters.AddWithValue("@Rstatus", cb_rstatus.SelectedValue);
                cmd.Parameters.AddWithValue("@Snum", cb_snum.SelectedValue);
                if (cb_rstatus.SelectedIndex == 1)
                {
                    cmd.Parameters.AddWithValue("@Rfinish", DateTime.Now);
                }
                else
                {
                    cmd.Parameters.AddWithValue("@Rfinish", "");
                }
                cmd.Parameters.AddWithValue("@Rnum", dataGridView4.CurrentRow.Cells[0].Value);
                con.Open();
                cmd.ExecuteNonQuery();
                con.Close();
                GetRest();
                toolStripStatusLabel4.Text = "Запись была изменена!";
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
                cmd.ExecuteNonQuery();
                con.Close();
                GetRest();
                toolStripStatusLabel4.Text = "Запись была удалена!";
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
            cb_enum.Text = dataGridView4.CurrentRow.Cells[1].Value.ToString();
            cb_rstatus.Text = dataGridView4.CurrentRow.Cells[2].Value.ToString();
            cb_snum.Text = dataGridView4.CurrentRow.Cells[3].Value.ToString();
            Rstart.Text = dataGridView4.CurrentRow.Cells[4].Value.ToString();
            Rfinish.Text = dataGridView4.CurrentRow.Cells[5].Value.ToString();
        }

        private void AddTips_Click(object sender, EventArgs e)
        {
            Tips_Exp Tips_Exp = new Tips_Exp();
            Tips_Exp.ShowDialog();
        }

        private void AddStatus_Click(object sender, EventArgs e)
        {
            Restoration_status Restoration_status = new Restoration_status();
            Restoration_status.ShowDialog();
        }
        private void Rbtncbupd_Click(object sender, EventArgs e)
        {
            this.restoration_statusTableAdapter.Fill(this.tiunovDataSet.Restoration_status);
            this.expTableAdapter.Fill(this.tiunovDataSet.Exp);
            this.sotrudniki1TableAdapter.Fill(this.tiunovDataSet.Sotrudniki1);
            GetRest();
        }
        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            (dataGridView4.DataSource as DataTable).DefaultView.RowFilter = $"[Enam] LIKE '%{textBox4.Text}%'";
        }
        #endregion
    }
}
