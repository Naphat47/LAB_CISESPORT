using System.Windows.Forms;
using System.Xml.Linq;
using CISESPORT.Info;

namespace CISESPORT
{
    public partial class FormInfo : Form
    {
        private Player _newPlayer;
        public FormInfo()
        {
            InitializeComponent();
        }
        private void button1_Click_1(object sender, EventArgs e)
        {
            string name = tbSName.Text;
            string lastname = tbLName.Text;
            string id = tbId.Text;
            string major = tbMajor.Text;
            string gname = tbGname.Text;
            string mail = tbMail.Text;
            string phone = tbPhone.Text;
            int iage = 0;
            try
            {
                string age = tbAge.Text;
                iage = Int32.Parse(age);
            }
            catch (FormatException ex)
            {
                //Do something if have some exception
                MessageBox.Show("ERROR");
                return;
            }
            _newPlayer = new Player(name, lastname, id, major, gname, mail, phone, iage);

            this.DialogResult = DialogResult.OK;
        }

        public Player GetPlayer() { return _newPlayer; }
    
    }
}