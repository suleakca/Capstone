using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proje0963
{
    public partial class Kakuro : Form
    {
        public Kakuro()
        {
            InitializeComponent();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
            this.Hide();
        }

        private void kakuroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form1 sudoku = new Form1();
            sudoku.ShowDialog();
            this.Hide();
        }
    }
}
