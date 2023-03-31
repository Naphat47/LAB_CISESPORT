using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Net.Mime.MediaTypeNames;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using System.Xml.Linq;
using CISESPORT.Info;

namespace CISESPORT
{
    public partial class FormAllPlayer : Form
    {
        List<Player> listPlayer = new List<Player>();
        Player selectedPlayer;

        public FormAllPlayer()
        {
            InitializeComponent();
        }
        public Player GetselectedPlayer() { return selectedPlayer; }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dataGridView1.Rows[e.RowIndex];
                this.selectedPlayer = (Player)row.DataBoundItem;

                this.tbSName.Text = selectedPlayer.SName;
                this.tbLName.Text = selectedPlayer.LName;
                this.tbId.Text = selectedPlayer.Id;
                this.tbMajor.Text = selectedPlayer.Major;

            }
            string iSName = tbSName.Text, iLName = "", iId = tbId.Text, iMajor = tbMajor.Text, iGname = "", iMail = "", iPhone = "", age = "0";
            int iage = Int32.Parse(age);
            selectedPlayer = new Player(iSName, iLName, iId, iMajor, iGname, iMail, iPhone, iage);
        }

        private void newPlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FormInfo formInfo = new FormInfo();
            formInfo.ShowDialog();

            if (formInfo.DialogResult == DialogResult.OK)
            {
                Player newPlayer = formInfo.GetPlayer();
                listPlayer.Add(newPlayer);
                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = listPlayer;
                formInfo.Close();
            }
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
                        if (line.Length >= 8) // Check that there are enough fields
                        {
                            Player players = new Player(
                                line[0],
                                line[1],
                                line[2],
                                line[3],
                                line[4],
                                line[5],
                                line[6],
                                Int32.Parse(line[7])
                            );
                            listPlayer.Add(players);
                        }
                    }

                }
                this.dataGridView1.DataSource = null;
                this.dataGridView1.DataSource = listPlayer;
            }
        }

        private void saveFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFile = new SaveFileDialog();
            saveFile.Filter = "CSV|*.csv|TEXT|*.txt";
            saveFile.ShowDialog();
            if (saveFile.FileName != "")
            {
                using (StreamWriter writer = new StreamWriter(saveFile.FileName))
                {
                    foreach (Player item in listPlayer)
                    {
                        writer.WriteLine(String.Format("{0},{1},{2},{3},{4},{5},{6},{7}",
                            item.SName,
                            item.LName,
                            item.Id,
                            item.Major,
                            item.Gname,
                            item.Mail,
                            item.Phone,
                            item.Age
                            ));
                    }
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void closeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
