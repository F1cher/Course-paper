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
    public partial class Tips_Exp : Form
    {
        public Tips_Exp()
        {
            InitializeComponent();
        }

        private void Tips_Exp_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "tiunovDataSet.Exponat_tip". При необходимости она может быть перемещена или удалена.
            this.exponat_tipTableAdapter.Fill(this.tiunovDataSet.Exponat_tip);

        }
    }
}
