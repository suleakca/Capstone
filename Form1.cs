using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gurobi;


namespace Proje0963
{
    public partial class Form1 : Form
    {
        const int cColWidth = 45;
        const int cRowHeigth = 45;
        const int cMaxCell = 9;
        const int cSidelength = cColWidth * cMaxCell + 3;
        DataGridView DGV;
        DataGridView DGV2;
        int sayi;
        int oncekiSayi = -1;
        int countTrue;
        int countFalse;
        private const string P = @"C:\Users\ecema\source\repos\Proje0963\Proje0963\SudokuTxt\";
        private const string P2 = @"C:\Users\ecema\source\repos\Proje0963\Proje0963\SolutionTxt\";

        public Form1()
        {
            InitializeComponent();
            Load += Form1_Load;
            Load += Form1_Load2;

        }


        private void button1_Click(object sender, EventArgs e)
        {
            hintcount = 0;
            countTrue = 0;
            countFalse = 0;
            saat = 0;
            dakika = 0;
            saniye = 0;
            DGV2.Visible = false;
            lblSubmit.Text = "";
            hntLabel.Text = "";
            
            Random rasgele = new Random();
            sayi = rasgele.Next(50);

            while (oncekiSayi == sayi)
                sayi = rasgele.Next(50);

            oncekiSayi = sayi;

            timer1.Enabled = true;
            gameNoLbl.Text = "Game No: " + sayi.ToString();

            StreamReader dosyaOku;


            if (HardRadioButton.Checked == true)
                dosyaOku = new StreamReader(P + "Hard\\Hard" + sayi + ".txt");
            else if (MediumRadioButton.Checked == true)
                dosyaOku = new StreamReader(P + "Medium\\Medium" + sayi + ".txt");
            else if(EasyRadioButton.Checked==true)
                dosyaOku = new StreamReader(P + "Easy\\Easy" + sayi + ".txt");
            else
                dosyaOku = new StreamReader(P + "External\\ExternalStart.txt");




            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)

                {
                    
                    int cell = Convert.ToInt32(((char)dosyaOku.Read()).ToString());
                    
                    if (cell != 0)
                    {
                        DGV.Rows[i].Cells[j].Value = cell;
                        DGV.Rows[i].Cells[j].ReadOnly = true;
                    }
                    else
                    {
                        DGV.Rows[i].Cells[j].Value = "";
                        DGV.Rows[i].Cells[j].ReadOnly = false;
                    }

                }
                dosyaOku.ReadLine();
            }


            dosyaOku.Close();

            StreamReader dosyaOku2;


            if (HardRadioButton.Checked == true)
                dosyaOku2 = new StreamReader(P2 + "Hard\\Hard" + sayi + ".txt");
            else if (MediumRadioButton.Checked == true)
                dosyaOku2 = new StreamReader(P2 + "Medium\\Medium" + sayi + ".txt");
            else if (EasyRadioButton.Checked==true)
                dosyaOku2 = new StreamReader(P2 + "Easy\\Easy" + sayi + ".txt");
            else
                dosyaOku2 = new StreamReader(@"C:\Users\ecema\source\repos\Proje0963\Proje0963\SudokuTxt\External\ExternalSolution.txt");
           



            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)

                {

                    int cell2 = Convert.ToInt32(((char)dosyaOku2.Read()).ToString());//toString demezsek 49vs oluyor
                    
                    DGV2.Rows[i].Cells[j].Value = cell2;
                    DGV2.Rows[i].Cells[j].ReadOnly = true;


                }
                dosyaOku2.ReadLine();
            }


            dosyaOku2.Close();




        }

        private void Form1_Load(object sender, EventArgs e)
        {
            DGV = new DataGridView();
            DGV.Name = "DGV";
            DGV.AllowUserToResizeColumns = false;
            DGV.AllowUserToResizeRows = false;
            DGV.AllowUserToAddRows = false;
            DGV.RowHeadersVisible = false;
            DGV.ColumnHeadersVisible = false;
            DGV.GridColor = Color.DarkGray;
            DGV.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            DGV.ScrollBars = ScrollBars.None;
            DGV.Size = new Size(cSidelength, cSidelength);
            DGV.Location = new Point(50, 200);
            DGV.Font = new System.Drawing.Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            DGV.ForeColor = Color.DimGray;
            DGV.SelectionMode = DataGridViewSelectionMode.CellSelect;
            // add 81 cells
            for (int i = 0; i < cMaxCell; i++)
            {
                DataGridViewTextBoxColumn TxCol = new DataGridViewTextBoxColumn();
                TxCol.MaxInputLength = 1;   // only one digit allowed in a cell
                DGV.Columns.Add(TxCol);
                DGV.Columns[i].Name = "Col " + (i + 1).ToString();
                DGV.Columns[i].Width = cColWidth;
                DGV.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

                DataGridViewRow row = new DataGridViewRow();
                row.Height = cRowHeigth;
                DGV.Rows.Add(row);
            }
            // mark the 9 square areas consisting of 9 cells
            DGV.Columns[2].DividerWidth = 2;
            DGV.Columns[5].DividerWidth = 2;
            DGV.Rows[2].DividerHeight = 2;
            DGV.Rows[5].DividerHeight = 2;

            Controls.Add(DGV);

        }

        private void Form1_Load2(object sender, EventArgs e)
        {
            DGV2 = new DataGridView();
            DGV2.Name = "DGV2";
            DGV2.AllowUserToResizeColumns = false;
            DGV2.AllowUserToResizeRows = false;
            DGV2.AllowUserToAddRows = false;
            DGV2.RowHeadersVisible = false;
            DGV2.ColumnHeadersVisible = false;
            DGV2.GridColor = Color.DarkGray;
            DGV2.DefaultCellStyle.BackColor = Color.WhiteSmoke;
            DGV2.ScrollBars = ScrollBars.None;
            DGV2.Size = new Size(cSidelength, cSidelength);
            DGV2.Location = new Point(980, 200);
            DGV2.Font = new System.Drawing.Font("Calibri", 16.2F, FontStyle.Bold, GraphicsUnit.Point, ((byte)(0)));
            DGV2.ForeColor = Color.DimGray;
            DGV2.SelectionMode = DataGridViewSelectionMode.CellSelect;

            // add 81 cells
            for (int i = 0; i < cMaxCell; i++)
            {
                DataGridViewTextBoxColumn TxCol = new DataGridViewTextBoxColumn();
                TxCol.MaxInputLength = 1;   // only one digit allowed in a cell
                DGV2.Columns.Add(TxCol);
                DGV2.Columns[i].Name = "Col " + (i + 1).ToString();
                DGV2.Columns[i].Width = cColWidth;
                DGV2.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
               
                DataGridViewRow row = new DataGridViewRow();
                row.Height = cRowHeigth;
                DGV2.Rows.Add(row);
            }
            // mark the 9 square areas consisting of 9 cells
            DGV2.Columns[2].DividerWidth = 2;
            DGV2.Columns[5].DividerWidth = 2;
            DGV2.Rows[2].DividerHeight = 2;
            DGV2.Rows[5].DividerHeight = 2;

            Controls.Add(DGV2);
            DGV2.Visible = false;

        }
        int saat = 0, dakika = 0, saniye = 0;

        
        private void btnSolution_Click(object sender, EventArgs e)
        {
            StreamReader dosyaOku3;


            if (externalRadioButton.Checked == true)
            {
                dosyaOku3 = new StreamReader(@"C:\Users\ecema\source\repos\Proje0963\Proje0963\SudokuTxt\External\ExternalSolution.txt");
                for (int i = 0; i < 9; i++)
                {
                    for (int j = 0; j < 9; j++)

                    {

                        int cell2 = Convert.ToInt32(((char)dosyaOku3.Read()).ToString());//toString demezsek 49vs oluyor

                        DGV2.Rows[i].Cells[j].Value = cell2;
                        DGV2.Rows[i].Cells[j].ReadOnly = true;


                    }
                    dosyaOku3.ReadLine();
                }


                dosyaOku3.Close();

                if (DGV2.Visible == false)
                    DGV2.Visible = true;
                else
                    DGV2.Visible = false;

            }
            else
            {
                if (DGV2.Visible == false)
                    DGV2.Visible = true;
                else
                    DGV2.Visible = false;
            }

 
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)

                {

                    if (DGV.Rows[i].Cells[j].Value.ToString().Equals(DGV2.Rows[i].Cells[j].Value.ToString()))
                        countTrue++;
                    else
                    {
                        countFalse++;
                        DGV.Rows[i].Cells[j].Style.BackColor = Color.Red;
                    }



                }
            }
            timer1.Enabled = false;
            lblSubmit.Text = "Game is completed at " + (saat.ToString() + " : ") + (dakika.ToString() + " : ") + saniye.ToString() + " and you have " + countFalse + " errors";
            countFalse = 0;
        }
        int countScore = 1;
        private void btnSaveScore_Click(object sender, EventArgs e)
        {
            countFalse = 0;
            scoreListBox.Items.Add("Game " + countScore + ": " + countFalse + " errors " + "in: " + (saat.ToString() + " : ") + (dakika.ToString() + " : ") + saniye.ToString());
            countScore++;
            for (int i = 0; i < 9; i++)
            {
                for (int j = 0; j < 9; j++)

                {

                        DGV.Rows[i].Cells[j].Style.BackColor = Color.WhiteSmoke;
           
                }
            }

        }
        int hintcount=0;
        private void btnHint_Click(object sender, EventArgs e)
        {
            int row, col;
            Random rndRow = new Random();
            Random rndCol = new Random();
            row = rndRow.Next(7);
            col = rndCol.Next(7);
            if (hintcount < 3)
            {
                for (int i = 0; i < 81; i++)
                {


                    if (DGV.Rows[row].Cells[col].Value.ToString() != "")
                    {
                        row = rndRow.Next(7);
                        col = rndCol.Next(7);

                    }
                    else
                    {
                        DGV.Rows[row].Cells[col].Value = DGV2.Rows[row].Cells[col].Value.ToString();
                        hintcount++;
                        return;


                    }

                }
            }
            else
                hntLabel.Text = "Enough hint for this game :)";

        }

        private void solveBtn_Click(object sender, EventArgs e)
        {
            int n = 9;
            int s = 3;
            if (externalRadioButton.Checked == true)
            {
                StreamWriter game = new StreamWriter(@"C:\Users\ecema\source\repos\Proje0963\Proje0963\SudokuTxt\External\ExternalGame");
            
                
                
                    for (int j = 0; j < 9; j++)

                    {
                        for (int k = 0; k < 9; k++) { 
                            if (DGV.Rows[j].Cells[k].Value.ToString() == "")
                            game.Write("0");
                        else
                            game.Write(DGV.Rows[j].Cells[k].Value.ToString());
                        }
                        game.WriteLine();
                    }
                
                game.Close();

            }



            try
            {
                GRBEnv env = new GRBEnv();
                GRBModel model = new GRBModel(env);

                // Create 3-D array of model variables

                GRBVar[,,] vars = new GRBVar[n, n, n];

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        for (int v = 0; v < n; v++)
                        {
                            string st = "G_" + i.ToString() + "_" + j.ToString()
                                             + "_" + v.ToString();
                            vars[i, j, v] = model.AddVar(0.0, 1.0, 0.0, GRB.BINARY, st);
                        }
                    }
                }

                // Add constraints

                GRBLinExpr expr;

                // Each cell must take one value

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        expr = 0.0;
                        for (int v = 0; v < n; v++)
                            expr.AddTerm(1.0, vars[i, j, v]);
                        string st = "V_" + i.ToString() + "_" + j.ToString();
                        model.AddConstr(expr == 1.0, st);
                    }
                }

                // Each value appears once per row

                for (int i = 0; i < n; i++)
                {
                    for (int v = 0; v < n; v++)
                    {
                        expr = 0.0;
                        for (int j = 0; j < n; j++)
                            expr.AddTerm(1.0, vars[i, j, v]);
                        string st = "R_" + i.ToString() + "_" + v.ToString();
                        model.AddConstr(expr == 1.0, st);
                    }
                }

                // Each value appears once per column

                for (int j = 0; j < n; j++)
                {
                    for (int v = 0; v < n; v++)
                    {
                        expr = 0.0;
                        for (int i = 0; i < n; i++)
                            expr.AddTerm(1.0, vars[i, j, v]);
                        string st = "C_" + j.ToString() + "_" + v.ToString();
                        model.AddConstr(expr == 1.0, st);
                    }
                }

                // Each value appears once per sub-grid

                for (int v = 0; v < n; v++)
                {
                    for (int i0 = 0; i0 < s; i0++)
                    {
                        for (int j0 = 0; j0 < s; j0++)
                        {
                            expr = 0.0;
                            for (int i1 = 0; i1 < s; i1++)
                            {
                                for (int j1 = 0; j1 < s; j1++)
                                {
                                    expr.AddTerm(1.0, vars[i0 * s + i1, j0 * s + j1, v]);
                                }
                            }
                            string st = "Sub_" + v.ToString() + "_" + i0.ToString()
                                               + "_" + j0.ToString();
                            model.AddConstr(expr == 1.0, st);
                        }
                    }
                }

                // Fix variables associated with pre-specified cells

                StreamReader sr = File.OpenText(@"C:\Users\ecema\source\repos\Proje0963\Proje0963\SudokuTxt\External\ExternalGame");

                for (int i = 0; i < n; i++)
                {
                    string input = sr.ReadLine();
                    for (int j = 0; j < n; j++)
                    {
                        int val = (int)input[j] - 48 - 1; // 0-based string olduğu için çevrilmeli

                        if (val >= 0)
                            vars[i, j, val].LB = 1.0;
                    }
                }

                // Optimize model

                model.Optimize();

                // Write model to file
                model.Write("sudoku.lp");

                double[,,] x = model.Get(GRB.DoubleAttr.X, vars);

                Console.WriteLine();
                StreamWriter doku = new StreamWriter(@"C:\Users\ecema\source\repos\Proje0963\Proje0963\SudokuTxt\External\ExternalSolution.txt");

                for (int i = 0; i < n; i++)
                {
                    for (int j = 0; j < n; j++)
                    {
                        for (int v = 0; v < n; v++)
                        {
                            if (x[i, j, v] > 0.5)
                            {
                                doku.Write(v + 1);
                            }
                        }
                    }
                    doku.WriteLine(); //yan yana yazar
                }
                doku.Close();

                // Dispose of model and env
                model.Dispose();
                env.Dispose();

            }
            catch (GRBException e1)
            {
                Console.WriteLine("Error code: " + e1.ErrorCode + ". " + e1.Message);
                errorLbl.Text = "Error code: " + e1.ErrorCode + ". " + e1.Message;
            }
            Console.ReadLine();
        }

        private void dashboardToolStripMenuItem_Click(object sender, EventArgs e)
        {

            Dashboard dashboard = new Dashboard();
            dashboard.ShowDialog();
            
        }

        private void kakuroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Kakuro kakuro = new Kakuro();
            kakuro.ShowDialog();
        }

        private void toSolveAnExtrernalGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            helpLbl.Text= " To solve an external game, first click on External Radio button and start a new game \r\n" +
                " then fill the Sudoku according to game which you want to solve and click Solve Button. \r\n " +
                "After waiting a second, click on Solution Button to see the answer. ";
        }

        private void StopButton_Click(object sender, EventArgs e)
        {
            if (timer1.Enabled == true)
            {
                timer1.Enabled = false;
                DGV.Visible = false;
            }
            else
            {
                timer1.Enabled = true;
                DGV.Visible = true;
            }
        }




        private void timer1_Tick(object sender, EventArgs e)
        {
            label1.Text = ("Time: " + (saat.ToString() + " : ") + (dakika.ToString() + " : ") + saniye.ToString());
            if ((saniye == 59))
            {
                saniye = 0;
                dakika = dakika + 1;
                if (dakika == 60)
                {
                    saniye = 0;
                    dakika = 0;
                    saat = saat + 1;
                }
            }
            saniye = saniye + 1;

        }
    }

}