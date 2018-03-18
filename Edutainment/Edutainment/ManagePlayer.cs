using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Edutainment.Models;

namespace Edutainment
{
    public partial class ManagePlayer : Form
    {
        EdutainmentContext db = new EdutainmentContext();
        public ManagePlayer()
        {
            InitializeComponent();
        }

        private void btnAddPlayer_Click(object sender, EventArgs e)
        {
            pnlAddPlayer.Visible = true;
            dataGridView1.Visible = false;
            btnAddPlayer.Visible = false;

        }

        private void ManagePlayer_Load(object sender, EventArgs e)
        {
            LoadPlayers();
        }

        private void LoadPlayers()
        {
            var players = db.players.ToList();
            dataGridView1.DataSource = players;
            pnlAddPlayer.Visible = false;
            dataGridView1.Visible = true;
            btnAddPlayer.Visible = true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                string userName = txtUserName.Text.Trim();
                if (CheckUserName(userName))
                {
                    MessageBox.Show(userName+" is already exists. Please enter differen username");
                }
                else
                {
                    Player player = new Player();
                    player.UserName = userName;
                    player.Name = txtName.Text.Trim();
                    player.Address = txtAddress.Text.Trim();
                    db.players.Add(player);
                    db.SaveChanges();
                    LoadPlayers();
                }

            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private bool CheckUserName(string userName)
        {
            if (db.players.Where(p => p.UserName == userName).ToList().Count > 0)
                return true;
            else
                return false;

        }
    }
}
