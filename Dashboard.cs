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
    public partial class Dashboard : Form
    {
        public Dashboard()
        {
            InitializeComponent();
        }

        private void pictureBoxSudoku_Click(object sender, EventArgs e)
        {
            Form1 sudoku = new Form1();
            this.Hide();
            sudoku.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Kakuro kakuro = new Kakuro();
            this.Hide();
            kakuro.ShowDialog();
        }
    }
}
