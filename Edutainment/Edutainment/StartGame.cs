using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Edutainment
{
    public partial class StartGame : Form
    {
        EdutainmentContext db = new EdutainmentContext();
        public StartGame()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            comboBox1.ValueMember = "Id";
            comboBox1.DisplayMember = "Title";
            var modules = db.modules.ToList();
            comboBox1.DataSource = modules;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(txtUserName.Text.Trim()) && CheckPlayer(txtUserName.Text.Trim()))
            {
                string userName = txtUserName.Text.Trim();
                //CheckPlayer(playerName);
                var moduleId = Convert.ToInt32(comboBox1.SelectedValue);
                if (CheckPlayerStatus(moduleId, userName))
                {
                    MessageBox.Show("You have already played this module game. Please select different module");
                }
                else
                {
                    this.Hide();
                    StoryForm frm = new StoryForm(moduleId, userName);
                    frm.Show();
                }
            }
            else if(!CheckPlayer(txtUserName.Text.Trim()))
            {
                MessageBox.Show(txtUserName.Text.Trim() +" does not exist.");
            }
            else
            {
                MessageBox.Show("Please, enter player name");
            }
        }

        private bool CheckPlayer(string userName)
        {
            if (db.players.Where(p => p.UserName == userName).ToList().Count > 0)
                return true;
            else
                return false;
            
        }

        private int GetPlayerId(string userName)
        {
            return db.players.Where(p => p.UserName == userName).ToList().FirstOrDefault().Id;
        }

        private bool CheckPlayerStatus(int moduleId,string userName)
        {
            int playerId = GetPlayerId(userName);

            if ( db.playerStatuses.Where(ps => ps.ModuleId == moduleId && ps.PlayerId == playerId && ps.GameState == 10).ToList().Count>0)
            {
                return true;
            }
            return false;

        }

        private void managePlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ManagePlayer mp = new ManagePlayer();
            mp.Show();
        }

        private void manageStoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Story can be download from Fun2Learn site. But now it is in progress");
        }

        private void manageModuleToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Under developing");
        }
    }
}
