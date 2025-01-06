namespace Proje0963
{
    partial class Kakuro
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.goToToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.dashboardToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.kakuroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toSolveAnExtrernalGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.developerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ecemAltınelToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.menuStrip1.Size = new System.Drawing.Size(980, 28);
            this.menuStrip1.TabIndex = 17;
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
            this.dashboardToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.dashboardToolStripMenuItem.Text = "Dashboard";
            this.dashboardToolStripMenuItem.Click += new System.EventHandler(this.dashboardToolStripMenuItem_Click);
            // 
            // kakuroToolStripMenuItem
            // 
            this.kakuroToolStripMenuItem.Name = "kakuroToolStripMenuItem";
            this.kakuroToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.kakuroToolStripMenuItem.Text = "Sudoku";
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
            this.ecemAltınelToolStripMenuItem.Size = new System.Drawing.Size(216, 26);
            this.ecemAltınelToolStripMenuItem.Text = "Ecem Altınel";
            // 
            // Kakuro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Proje0963.Properties.Resources.pexels_photo;
            this.ClientSize = new System.Drawing.Size(980, 517);
            this.Controls.Add(this.menuStrip1);
            this.Name = "Kakuro";
            this.Text = "Kakuro";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem goToToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dashboardToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem kakuroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toSolveAnExtrernalGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem developerToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ecemAltınelToolStripMenuItem;
    }
}