using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CISESPORT.Info;

namespace CISESPORT
{
    public partial class FormAllTeam : Form
    {
        private List<Team> TeamList = new List<Team>();
        Team SelectedTeam;
        public FormAllTeam()
        {
            InitializeComponent();
        }

        private void FormAllTeam_Load(object sender, EventArgs e)
        {

        }

        private void openFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "CSV|*.csv|TEXT|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                using (StreamReader reader = new StreamReader(openFileDialog.FileName))
                {
                    while (!reader.EndOfStream)
                    {
                        string[] line = reader.ReadLine().Split(',');
                        if (line.Length >= 11)
                        {
                            Team teams = new Team(
                                line[0],
                                line[1],
                                line[2],
                                line[3],
                                line[4],
                                line[5],
                                line[6],
                                line[7],
                                line[8],
                                line[9],
                                line[10]
                            );
                            TeamList.Add(teams);
                        }
                    }
                }
                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = TeamList;
            }
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "CSV|*.csv|TEXT|*.txt";
            saveFileDialog.ShowDialog();
            if (saveFileDialog.FileName != "")
            {
                using (StreamWriter writer = new StreamWriter(saveFileDialog.FileName))
                {
                    foreach (Team item in TeamList)
                    {
                        writer.WriteLine(String.Format("{0},{1},{2},{3},{4},{5},{6},{7},{8},{9},{10}",
                            item._Team,
                            item.Name1,
                            item.GameName1,
                            item.Name2,
                            item.GameName2,
                            item.Name3,
                            item.GameName3,
                            item.Name4,
                            item.GameName4,
                            item.Name5,
                            item.GameName5
                            ));
                    }
                }
            }
        }

        private void newTeamToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormTeamInfo formTeamInfo = new FormTeamInfo();
            formTeamInfo.ShowDialog();

            if (formTeamInfo.DialogResult == DialogResult.OK)
            {
                Team newTeam = formTeamInfo.GetTeam();
                TeamList.Add(newTeam);
                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = TeamList;
                formTeamInfo.Close();
            }
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
