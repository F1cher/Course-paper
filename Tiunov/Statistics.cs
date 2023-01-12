using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tiunov
{
    public partial class Statistics : Form
    {    
        public Statistics()
        {
            InitializeComponent();
        }

        private void Statistics_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tiunovDataSet1.StatRest". При необходимости она может быть перемещена или удалена.
            this.statRestTableAdapter.Fill(this.tiunovDataSet1.StatRest);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tiunovDataSet.StatExp". При необходимости она может быть перемещена или удалена.
            this.statExpTableAdapter.Fill(this.tiunovDataSet.StatExp);

        }

        private void exportToWord_Click(object sender, EventArgs e)
        {

        }
    }
}
