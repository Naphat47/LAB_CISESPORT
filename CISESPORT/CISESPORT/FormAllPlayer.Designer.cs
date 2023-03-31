namespace CISESPORT
{
    partial class FormAllPlayer
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
            dataGridView1 = new DataGridView();
            menuStrip2 = new MenuStrip();
            fileToolStripMenuItem = new ToolStripMenuItem();
            openFileToolStripMenuItem = new ToolStripMenuItem();
            saveFileToolStripMenuItem = new ToolStripMenuItem();
            closeToolStripMenuItem = new ToolStripMenuItem();
            playerToolStripMenuItem = new ToolStripMenuItem();
            newPlayerToolStripMenuItem = new ToolStripMenuItem();
            tbMajor = new TextBox();
            tbId = new TextBox();
            tbLName = new TextBox();
            tbSName = new TextBox();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            menuStrip2.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(0, 27);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.ReadOnly = true;
            dataGridView1.RowTemplate.Height = 25;
            dataGridView1.Size = new Size(443, 423);
            dataGridView1.TabIndex = 1;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick;
            // 
            // menuStrip2
            // 
            menuStrip2.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, playerToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(693, 24);
            menuStrip2.TabIndex = 2;
            menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { openFileToolStripMenuItem, saveFileToolStripMenuItem, closeToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // openFileToolStripMenuItem
            // 
            openFileToolStripMenuItem.Name = "openFileToolStripMenuItem";
            openFileToolStripMenuItem.Size = new Size(180, 22);
            openFileToolStripMenuItem.Text = "Open File";
            openFileToolStripMenuItem.Click += openFileToolStripMenuItem_Click;
            // 
            // saveFileToolStripMenuItem
            // 
            saveFileToolStripMenuItem.Name = "saveFileToolStripMenuItem";
            saveFileToolStripMenuItem.Size = new Size(180, 22);
            saveFileToolStripMenuItem.Text = "Save File";
            saveFileToolStripMenuItem.Click += saveFileToolStripMenuItem_Click;
            // 
            // closeToolStripMenuItem
            // 
            closeToolStripMenuItem.Name = "closeToolStripMenuItem";
            closeToolStripMenuItem.Size = new Size(180, 22);
            closeToolStripMenuItem.Text = "Close";
            closeToolStripMenuItem.Click += closeToolStripMenuItem_Click;
            // 
            // playerToolStripMenuItem
            // 
            playerToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { newPlayerToolStripMenuItem });
            playerToolStripMenuItem.Name = "playerToolStripMenuItem";
            playerToolStripMenuItem.Size = new Size(51, 20);
            playerToolStripMenuItem.Text = "Player";
            // 
            // newPlayerToolStripMenuItem
            // 
            newPlayerToolStripMenuItem.Name = "newPlayerToolStripMenuItem";
            newPlayerToolStripMenuItem.Size = new Size(180, 22);
            newPlayerToolStripMenuItem.Text = "New Player";
            newPlayerToolStripMenuItem.Click += newPlayerToolStripMenuItem_Click;
            // 
            // tbMajor
            // 
            tbMajor.Location = new Point(554, 135);
            tbMajor.Name = "tbMajor";
            tbMajor.Size = new Size(100, 23);
            tbMajor.TabIndex = 10;
            // 
            // tbId
            // 
            tbId.Location = new Point(554, 106);
            tbId.Name = "tbId";
            tbId.Size = new Size(100, 23);
            tbId.TabIndex = 8;
            // 
            // tbLName
            // 
            tbLName.Location = new Point(554, 78);
            tbLName.Name = "tbLName";
            tbLName.Size = new Size(100, 23);
            tbLName.TabIndex = 6;
            // 
            // tbSName
            // 
            tbSName.Location = new Point(554, 49);
            tbSName.Name = "tbSName";
            tbSName.Size = new Size(100, 23);
            tbSName.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(475, 138);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 11;
            label4.Text = "สาขา";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(475, 109);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 9;
            label3.Text = "รหัสนักศึกษา";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(475, 81);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 7;
            label2.Text = "นามสกุล";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(475, 52);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 5;
            label1.Text = "ชื่อ";
            // 
            // button1
            // 
            button1.Location = new Point(554, 164);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 12;
            button1.Text = "ยืนยัน";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // FormAllPlayer
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(693, 450);
            Controls.Add(button1);
            Controls.Add(tbMajor);
            Controls.Add(tbId);
            Controls.Add(tbLName);
            Controls.Add(tbSName);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip2);
            Name = "FormAllPlayer";
            Text = "FormAllPlayer";
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridView1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem openFileToolStripMenuItem;
        private ToolStripMenuItem saveFileToolStripMenuItem;
        private ToolStripMenuItem closeToolStripMenuItem;
        private ToolStripMenuItem playerToolStripMenuItem;
        private ToolStripMenuItem newPlayerToolStripMenuItem;
        private TextBox tbMajor;
        private TextBox tbId;
        private TextBox tbLName;
        private TextBox tbSName;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
    }
}