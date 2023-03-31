using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CISESPORT.Info;

namespace CISESPORT
{
    public partial class FormTeamInfo : Form
    {
        private Team _newTeams;
        public FormTeamInfo()
        {
            InitializeComponent();
        }
        private void button6_Click(object sender, EventArgs e)
        {
            string team = tbST1.Text;
            string name1 = tbGT1.Text;
            string gname1 = tbST2.Text;
            string name2 = tbGT2.Text;
            string gname2 = tbGT2.Text;
            string name3 = tbST3.Text;
            string gname3 = tbGT3.Text;
            string name4 = tbST4.Text;
            string gname4 = tbGT4.Text;
            string name5 = tbST5.Text;
            string gname5 = tbGT5.Text;

            _newTeams = new Team(team, name1, gname1, name2, gname2, name3, gname3, name4, gname4, name5, gname5);
            this.DialogResult = DialogResult.OK;

        }
        public Team GetTeam() { return _newTeams; }
        private void button1_Click(object sender, EventArgs e)
        {
            FormAllPlayer formAllPlayer = new FormAllPlayer();
            formAllPlayer.ShowDialog();
            if (formAllPlayer.DialogResult == DialogResult.OK)
            {
                Player PlayerInfo = formAllPlayer.GetselectedPlayer();
                this.tbST1.Text = PlayerInfo.SName;
                this.tbGT1.Text = PlayerInfo.Gname;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            FormAllPlayer formAllPlayer = new FormAllPlayer();
            formAllPlayer.ShowDialog();
            if (formAllPlayer.DialogResult == DialogResult.OK)
            {
                Player PlayerInfo = formAllPlayer.GetselectedPlayer();
                this.tbST2.Text = PlayerInfo.SName;
                this.tbGT2.Text = PlayerInfo.Gname;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            FormAllPlayer formAllPlayer = new FormAllPlayer();
            formAllPlayer.ShowDialog();
            if (formAllPlayer.DialogResult == DialogResult.OK)
            {
                Player PlayerInfo = formAllPlayer.GetselectedPlayer();
                this.tbST3.Text = PlayerInfo.SName;
                this.tbGT3.Text = PlayerInfo.Gname;
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            FormAllPlayer formAllPlayer = new FormAllPlayer();
            formAllPlayer.ShowDialog();
            if (formAllPlayer.DialogResult == DialogResult.OK)
            {
                Player PlayerInfo = formAllPlayer.GetselectedPlayer();
                this.tbST4.Text = PlayerInfo.SName;
                this.tbGT4.Text = PlayerInfo.Gname;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            FormAllPlayer formAllPlayer = new FormAllPlayer();
            formAllPlayer.ShowDialog();
            if (formAllPlayer.DialogResult == DialogResult.OK)
            {
                Player PlayerInfo = formAllPlayer.GetselectedPlayer();
                this.tbST5.Text = PlayerInfo.SName;
                this.tbGT5.Text = PlayerInfo.Gname;
            }
        }
    }
}

