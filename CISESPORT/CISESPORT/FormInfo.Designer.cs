namespace CISESPORT
{
    partial class FormInfo
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            tbSName = new TextBox();
            tbLName = new TextBox();
            tbId = new TextBox();
            tbMajor = new TextBox();
            tbGname = new TextBox();
            tbMail = new TextBox();
            tbPhone = new TextBox();
            tbAge = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(66, 39);
            label1.Name = "label1";
            label1.Size = new Size(20, 15);
            label1.TabIndex = 0;
            label1.Text = "ชื่อ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(66, 68);
            label2.Name = "label2";
            label2.Size = new Size(45, 15);
            label2.TabIndex = 1;
            label2.Text = "นามสกุล";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(66, 96);
            label3.Name = "label3";
            label3.Size = new Size(65, 15);
            label3.TabIndex = 2;
            label3.Text = "รหัสนักศึกษา";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(66, 125);
            label4.Name = "label4";
            label4.Size = new Size(30, 15);
            label4.TabIndex = 3;
            label4.Text = "สาขา";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(66, 154);
            label5.Name = "label5";
            label5.Size = new Size(47, 15);
            label5.TabIndex = 4;
            label5.Text = "ชื่อในเกม";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(66, 183);
            label6.Name = "label6";
            label6.Size = new Size(23, 15);
            label6.TabIndex = 5;
            label6.Text = "เมล";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(66, 212);
            label7.Name = "label7";
            label7.Size = new Size(67, 15);
            label7.TabIndex = 6;
            label7.Text = "เบอร์โทรศัพท์";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(66, 242);
            label8.Name = "label8";
            label8.Size = new Size(24, 15);
            label8.TabIndex = 7;
            label8.Text = "อายุ";
            // 
            // tbSName
            // 
            tbSName.Location = new Point(145, 36);
            tbSName.Name = "tbSName";
            tbSName.Size = new Size(100, 23);
            tbSName.TabIndex = 0;
            // 
            // tbLName
            // 
            tbLName.Location = new Point(145, 65);
            tbLName.Name = "tbLName";
            tbLName.Size = new Size(100, 23);
            tbLName.TabIndex = 1;
            // 
            // tbId
            // 
            tbId.Location = new Point(145, 93);
            tbId.Name = "tbId";
            tbId.Size = new Size(100, 23);
            tbId.TabIndex = 2;
            // 
            // tbMajor
            // 
            tbMajor.Location = new Point(145, 122);
            tbMajor.Name = "tbMajor";
            tbMajor.Size = new Size(100, 23);
            tbMajor.TabIndex = 3;
            // 
            // tbGname
            // 
            tbGname.Location = new Point(145, 151);
            tbGname.Name = "tbGname";
            tbGname.Size = new Size(100, 23);
            tbGname.TabIndex = 4;
            // 
            // tbMail
            // 
            tbMail.Location = new Point(145, 180);
            tbMail.Name = "tbMail";
            tbMail.Size = new Size(100, 23);
            tbMail.TabIndex = 5;
            // 
            // tbPhone
            // 
            tbPhone.Location = new Point(145, 209);
            tbPhone.Name = "tbPhone";
            tbPhone.Size = new Size(100, 23);
            tbPhone.TabIndex = 6;
            // 
            // tbAge
            // 
            tbAge.Location = new Point(145, 239);
            tbAge.Name = "tbAge";
            tbAge.Size = new Size(100, 23);
            tbAge.TabIndex = 7;
            // 
            // button1
            // 
            button1.Location = new Point(145, 268);
            button1.Name = "button1";
            button1.Size = new Size(100, 23);
            button1.TabIndex = 8;
            button1.Text = "บันทึก";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click_1;
            // 
            // FormInfo
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(325, 330);
            Controls.Add(button1);
            Controls.Add(tbAge);
            Controls.Add(tbPhone);
            Controls.Add(tbMail);
            Controls.Add(tbGname);
            Controls.Add(tbMajor);
            Controls.Add(tbId);
            Controls.Add(tbLName);
            Controls.Add(tbSName);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FormInfo";
            Text = "ข้อมูลนักกีฬา";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox tbSName;
        private TextBox tbLName;
        private TextBox tbId;
        private TextBox tbMajor;
        private TextBox tbGname;
        private TextBox tbMail;
        private TextBox tbPhone;
        private TextBox tbAge;
        private Button button1;
    }
}