namespace CISESPORT
{
    partial class ApplicationForm
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
            menuStrip1 = new MenuStrip();
            playerToolStripMenuItem = new ToolStripMenuItem();
            allPlayerToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            teamToolStripMenuItem = new ToolStripMenuItem();
            allTeamToolStripMenuItem1 = new ToolStripMenuItem();
            closeToolStripMenuItem1 = new ToolStripMenuItem();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Items.AddRange(new ToolStripItem[] { playerToolStripMenuItem, teamToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 0;
            menuStrip1.Text = "menuStrip1";
            // 
            // playerToolStripMenuItem
            // 
            playerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { allPlayerToolStripMenuItem, closeToolStripMenuItem });
            playerToolStripMenuItem.Name = "playerToolStripMenuItem";
            playerToolStripMenuItem.Size = new Size(51, 20);
            playerToolStripMenuItem.Text = "Player";
            // 
            // allPlayerToolStripMenuItem
            // 
            allPlayerToolStripMenuItem.Name = "allPlayerToolStripMenuItem";
            allPlayerToolStripMenuItem.Size = new Size(180, 22);
            allPlayerToolStripMenuItem.Text = "All Player";
            allPlayerToolStripMenuItem.Click += allPlayerToolStripMenuItem_Click;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(180, 22);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // teamToolStripMenuItem
            // 
            teamToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { allTeamToolStripMenuItem1, closeToolStripMenuItem1 });
            teamToolStripMenuItem.Name = "teamToolStripMenuItem";
            teamToolStripMenuItem.Size = new Size(47, 20);
            teamToolStripMenuItem.Text = "Team";
            // 
            // allTeamToolStripMenuItem1
            // 
            allTeamToolStripMenuItem1.Name = "allTeamToolStripMenuItem1";
            allTeamToolStripMenuItem1.Size = new Size(180, 22);
            allTeamToolStripMenuItem1.Text = "All Team";
            allTeamToolStripMenuItem1.Click += allTeamToolStripMenuItem1_Click;
            // 
            // closeToolStripMenuItem1
            // 
            closeToolStripMenuItem1.Name = "closeToolStripMenuItem1";
            closeToolStripMenuItem1.Size = new Size(180, 22);
            closeToolStripMenuItem1.Text = "Close";
            closeToolStripMenuItem1.Click += closeToolStripMenuItem1_Click;
            // 
            // ApplicationForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(menuStrip1);
            IsMdiContainer = true;
            MainMenuStrip = menuStrip1;
            Name = "ApplicationForm";
            Text = "ApplicationForm";
            Load += ApplicationForm_Load;
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem playerToolStripMenuItem;
        private ToolStripMenuItem allPlayerToolStripMenuItem;
        private ToolStripMenuItem teamToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem allTeamToolStripMenuItem1;
        private ToolStripMenuItem closeToolStripMenuItem1;
    }
}