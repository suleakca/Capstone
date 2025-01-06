namespace Proje0963
{
    partial class Form1
    {
        /// <summary>
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer üretilen kod

        /// <summary>
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.StartButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.EasyRadioButton = new System.Windows.Forms.RadioButton();
            this.MediumRadioButton = new System.Windows.Forms.RadioButton();
            this.HardRadioButton = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.externalRadioButton = new System.Windows.Forms.RadioButton();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.StopButton = new System.Windows.Forms.Button();
            this.btnSolution = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.lblSubmit = new System.Windows.Forms.Label();
            this.btnSaveScore = new System.Windows.Forms.Button();
            this.scoreListBox = new System.Windows.Forms.ListBox();
            this.btnHint = new System.Windows.Forms.Button();
            this.solveBtn = new System.Windows.Forms.Button();
            this.hntLabel = new System.Windows.Forms.Label();
            this.errorLbl = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.goToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kakuroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toSolveAnExtrernalGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.developerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ecemAltınelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpLbl = new System.Windows.Forms.Label();
            this.labelSudokuBaslık = new System.Windows.Forms.Label();
            this.gameNoLbl = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // StartButton
            // 
            this.StartButton.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.StartButton.ForeColor = System.Drawing.Color.DimGray;
            this.StartButton.Location = new System.Drawing.Point(712, 455);
            this.StartButton.Name = "StartButton";
            this.StartButton.Size = new System.Drawing.Size(200, 50);
            this.StartButton.TabIndex = 0;
            this.StartButton.Text = "START";
            this.StartButton.UseVisualStyleBackColor = false;
            this.StartButton.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(709, 227);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 17);
            this.label1.TabIndex = 1;
            this.label1.Text = "Time";
            // 
            // EasyRadioButton
            // 
            this.EasyRadioButton.AutoSize = true;
            this.EasyRadioButton.Location = new System.Drawing.Point(28, 30);
            this.EasyRadioButton.Name = "EasyRadioButton";
            this.EasyRadioButton.Size = new System.Drawing.Size(60, 21);
            this.EasyRadioButton.TabIndex = 2;
            this.EasyRadioButton.TabStop = true;
            this.EasyRadioButton.Text = "Easy";
            this.EasyRadioButton.UseVisualStyleBackColor = true;
            // 
            // MediumRadioButton
            // 
            this.MediumRadioButton.AutoSize = true;
            this.MediumRadioButton.Location = new System.Drawing.Point(28, 57);
            this.MediumRadioButton.Name = "MediumRadioButton";
            this.MediumRadioButton.Size = new System.Drawing.Size(78, 21);
            this.MediumRadioButton.TabIndex = 3;
            this.MediumRadioButton.TabStop = true;
            this.MediumRadioButton.Text = "Medium";
            this.MediumRadioButton.UseVisualStyleBackColor = true;
            // 
            // HardRadioButton
            // 
            this.HardRadioButton.AutoSize = true;
            this.HardRadioButton.Location = new System.Drawing.Point(28, 84);
            this.HardRadioButton.Name = "HardRadioButton";
            this.HardRadioButton.Size = new System.Drawing.Size(60, 21);
            this.HardRadioButton.TabIndex = 4;
            this.HardRadioButton.TabStop = true;
            this.HardRadioButton.Text = "Hard";
            this.HardRadioButton.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.groupBox1.Controls.Add(this.externalRadioButton);
            this.groupBox1.Controls.Add(this.EasyRadioButton);
            this.groupBox1.Controls.Add(this.HardRadioButton);
            this.groupBox1.Controls.Add(this.MediumRadioButton);
            this.groupBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.groupBox1.Location = new System.Drawing.Point(712, 273);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 150);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Difficulty Level";
            // 
            // externalRadioButton
            // 
            this.externalRadioButton.AutoSize = true;
            this.externalRadioButton.Location = new System.Drawing.Point(28, 110);
            this.externalRadioButton.Name = "externalRadioButton";
            this.externalRadioButton.Size = new System.Drawing.Size(122, 21);
            this.externalRadioButton.TabIndex = 5;
            this.externalRadioButton.TabStop = true;
            this.externalRadioButton.Text = "External Game";
            this.externalRadioButton.UseVisualStyleBackColor = true;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // StopButton
            // 
            this.StopButton.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.StopButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.StopButton.Location = new System.Drawing.Point(882, 217);
            this.StopButton.Name = "StopButton";
            this.StopButton.Size = new System.Drawing.Size(30, 27);
            this.StopButton.TabIndex = 6;
            this.StopButton.Text = "||";
            this.StopButton.UseVisualStyleBackColor = false;
            this.StopButton.Click += new System.EventHandler(this.StopButton_Click);
            // 
            // btnSolution
            // 
            this.btnSolution.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnSolution.ForeColor = System.Drawing.Color.DimGray;
            this.btnSolution.Location = new System.Drawing.Point(992, 511);
            this.btnSolution.Name = "btnSolution";
            this.btnSolution.Size = new System.Drawing.Size(200, 50);
            this.btnSolution.TabIndex = 7;
            this.btnSolution.Text = "SOLUTION";
            this.btnSolution.UseVisualStyleBackColor = false;
            this.btnSolution.Click += new System.EventHandler(this.btnSolution_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnSubmit.ForeColor = System.Drawing.Color.DimGray;
            this.btnSubmit.Location = new System.Drawing.Point(712, 511);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(200, 50);
            this.btnSubmit.TabIndex = 8;
            this.btnSubmit.Text = "SUBMIT";
            this.btnSubmit.UseVisualStyleBackColor = false;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // lblSubmit
            // 
            this.lblSubmit.AutoSize = true;
            this.lblSubmit.BackColor = System.Drawing.Color.Transparent;
            this.lblSubmit.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubmit.ForeColor = System.Drawing.Color.DarkRed;
            this.lblSubmit.Location = new System.Drawing.Point(709, 656);
            this.lblSubmit.Name = "lblSubmit";
            this.lblSubmit.Size = new System.Drawing.Size(0, 19);
            this.lblSubmit.TabIndex = 9;
            // 
            // btnSaveScore
            // 
            this.btnSaveScore.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnSaveScore.ForeColor = System.Drawing.Color.DimGray;
            this.btnSaveScore.Location = new System.Drawing.Point(712, 567);
            this.btnSaveScore.Name = "btnSaveScore";
            this.btnSaveScore.Size = new System.Drawing.Size(200, 50);
            this.btnSaveScore.TabIndex = 10;
            this.btnSaveScore.Text = "Save Score";
            this.btnSaveScore.UseVisualStyleBackColor = false;
            this.btnSaveScore.Click += new System.EventHandler(this.btnSaveScore_Click);
            // 
            // scoreListBox
            // 
            this.scoreListBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.scoreListBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.scoreListBox.FormattingEnabled = true;
            this.scoreListBox.ItemHeight = 16;
            this.scoreListBox.Location = new System.Drawing.Point(992, 275);
            this.scoreListBox.Name = "scoreListBox";
            this.scoreListBox.Size = new System.Drawing.Size(223, 148);
            this.scoreListBox.TabIndex = 11;
            // 
            // btnHint
            // 
            this.btnHint.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.btnHint.ForeColor = System.Drawing.Color.DimGray;
            this.btnHint.Location = new System.Drawing.Point(992, 455);
            this.btnHint.Name = "btnHint";
            this.btnHint.Size = new System.Drawing.Size(200, 50);
            this.btnHint.TabIndex = 12;
            this.btnHint.Text = "HINT";
            this.btnHint.UseVisualStyleBackColor = false;
            this.btnHint.Click += new System.EventHandler(this.btnHint_Click);
            // 
            // solveBtn
            // 
            this.solveBtn.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.solveBtn.ForeColor = System.Drawing.Color.DimGray;
            this.solveBtn.Location = new System.Drawing.Point(992, 567);
            this.solveBtn.Name = "solveBtn";
            this.solveBtn.Size = new System.Drawing.Size(200, 50);
            this.solveBtn.TabIndex = 13;
            this.solveBtn.Text = "SOLVE";
            this.solveBtn.UseVisualStyleBackColor = false;
            this.solveBtn.Click += new System.EventHandler(this.solveBtn_Click);
            // 
            // hntLabel
            // 
            this.hntLabel.AutoSize = true;
            this.hntLabel.BackColor = System.Drawing.Color.Transparent;
            this.hntLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hntLabel.ForeColor = System.Drawing.Color.DarkRed;
            this.hntLabel.Location = new System.Drawing.Point(709, 694);
            this.hntLabel.Name = "hntLabel";
            this.hntLabel.Size = new System.Drawing.Size(0, 20);
            this.hntLabel.TabIndex = 14;
            // 
            // errorLbl
            // 
            this.errorLbl.AutoSize = true;
            this.errorLbl.Location = new System.Drawing.Point(817, 13);
            this.errorLbl.Name = "errorLbl";
            this.errorLbl.Size = new System.Drawing.Size(0, 17);
            this.errorLbl.TabIndex = 15;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.goToToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.developerToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1838, 28);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // goToToolStripMenuItem
            // 
            this.goToToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.dashboardToolStripMenuItem,
            this.kakuroToolStripMenuItem});
            this.goToToolStripMenuItem.Name = "goToToolStripMenuItem";
            this.goToToolStripMenuItem.Size = new System.Drawing.Size(60, 24);
            this.goToToolStripMenuItem.Text = "Go To";
            // 
            // dashboardToolStripMenuItem
            // 
            this.dashboardToolStripMenuItem.Name = "dashboardToolStripMenuItem";
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // kakuroToolStripMenuItem
            // 
            this.kakuroToolStripMenuItem.Name = "kakuroToolStripMenuItem";
            this.kakuroToolStripMenuItem.Size = new System.Drawing.Size(157, 26);
            this.kakuroToolStripMenuItem.Text = "Kakuro";
            this.kakuroToolStripMenuItem.Click += new System.EventHandler(this.kakuroToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toSolveAnExtrernalGameToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(53, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // toSolveAnExtrernalGameToolStripMenuItem
            // 
            this.toSolveAnExtrernalGameToolStripMenuItem.Name = "toSolveAnExtrernalGameToolStripMenuItem";
            this.toSolveAnExtrernalGameToolStripMenuItem.Size = new System.Drawing.Size(263, 26);
            this.toSolveAnExtrernalGameToolStripMenuItem.Text = "To solve an Extrernal Game";
            this.toSolveAnExtrernalGameToolStripMenuItem.Click += new System.EventHandler(this.toSolveAnExtrernalGameToolStripMenuItem_Click);
            // 
            // developerToolStripMenuItem
            // 
            this.developerToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ecemAltınelToolStripMenuItem});
            this.developerToolStripMenuItem.Name = "developerToolStripMenuItem";
            this.developerToolStripMenuItem.Size = new System.Drawing.Size(96, 24);
            this.developerToolStripMenuItem.Text = "Developers";
            // 
            // ecemAltınelToolStripMenuItem
            // 
            this.ecemAltınelToolStripMenuItem.Name = "ecemAltınelToolStripMenuItem";
            this.ecemAltınelToolStripMenuItem.Size = new System.Drawing.Size(167, 26);
            this.ecemAltınelToolStripMenuItem.Text = "Ecem Altınel";
            // 
            // helpLbl
            // 
            this.helpLbl.AutoSize = true;
            this.helpLbl.BackColor = System.Drawing.Color.Transparent;
            this.helpLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.helpLbl.ForeColor = System.Drawing.Color.DarkBlue;
            this.helpLbl.Location = new System.Drawing.Point(32, 771);
            this.helpLbl.Name = "helpLbl";
            this.helpLbl.Size = new System.Drawing.Size(44, 20);
            this.helpLbl.TabIndex = 17;
            this.helpLbl.Text = "Help";
            // 
            // labelSudokuBaslık
            // 
            this.labelSudokuBaslık.AutoSize = true;
            this.labelSudokuBaslık.BackColor = System.Drawing.Color.Transparent;
            this.labelSudokuBaslık.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelSudokuBaslık.ForeColor = System.Drawing.Color.Salmon;
            this.labelSudokuBaslık.Location = new System.Drawing.Point(46, 69);
            this.labelSudokuBaslık.Name = "labelSudokuBaslık";
            this.labelSudokuBaslık.Size = new System.Drawing.Size(286, 69);
            this.labelSudokuBaslık.TabIndex = 18;
            this.labelSudokuBaslık.Text = "SUDOKU";
            // 
            // gameNoLbl
            // 
            this.gameNoLbl.AutoSize = true;
            this.gameNoLbl.BackColor = System.Drawing.Color.Transparent;
            this.gameNoLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.gameNoLbl.ForeColor = System.Drawing.Color.DimGray;
            this.gameNoLbl.Location = new System.Drawing.Point(481, 219);
            this.gameNoLbl.Name = "gameNoLbl";
            this.gameNoLbl.Size = new System.Drawing.Size(75, 20);
            this.gameNoLbl.TabIndex = 19;
            this.gameNoLbl.Text = "GameNo";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MintCream;
            this.BackgroundImage = global::Proje0963.Properties.Resources.pexels_photo;
            this.ClientSize = new System.Drawing.Size(1838, 845);
            this.Controls.Add(this.gameNoLbl);
            this.Controls.Add(this.labelSudokuBaslık);
            this.Controls.Add(this.helpLbl);
            this.Controls.Add(this.errorLbl);
            this.Controls.Add(this.hntLabel);
            this.Controls.Add(this.solveBtn);
            this.Controls.Add(this.btnHint);
            this.Controls.Add(this.scoreListBox);
            this.Controls.Add(this.btnSaveScore);
            this.Controls.Add(this.lblSubmit);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnSolution);
            this.Controls.Add(this.StopButton);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StartButton);
            this.Controls.Add(this.menuStrip1);
            this.ForeColor = System.Drawing.Color.Crimson;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sudoku";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button StartButton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton EasyRadioButton;
        private System.Windows.Forms.RadioButton MediumRadioButton;
        private System.Windows.Forms.RadioButton HardRadioButton;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button StopButton;
        private System.Windows.Forms.Button btnSolution;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.Label lblSubmit;
        private System.Windows.Forms.Button btnSaveScore;
        private System.Windows.Forms.ListBox scoreListBox;
        private System.Windows.Forms.Button btnHint;
        private System.Windows.Forms.Button solveBtn;
        private System.Windows.Forms.Label hntLabel;
        private System.Windows.Forms.RadioButton externalRadioButton;
        private System.Windows.Forms.Label errorLbl;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem goToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kakuroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem developerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ecemAltınelToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toSolveAnExtrernalGameToolStripMenuItem;
        private System.Windows.Forms.Label helpLbl;
        private System.Windows.Forms.Label labelSudokuBaslık;
        private System.Windows.Forms.Label gameNoLbl;
    }
}

