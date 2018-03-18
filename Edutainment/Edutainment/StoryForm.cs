using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Edutainment.Models;

namespace Edutainment
{
    public partial class StoryForm : Form
    {
        EdutainmentContext db = new EdutainmentContext();
        int order = 1;
        int moduleId = 0;
        int storyId = -1;
        string userName = string.Empty;
        public StoryForm(int moduleId, string userName)
        {
            InitializeComponent();
            this.moduleId = moduleId;
            this.userName = userName;
        }
        public StoryForm()
        {
            InitializeComponent();
        }

        private void StoryForm_Load(object sender, EventArgs e)
        {
            try
            {
                var module = (from m in db.storiesPerModule.ToList() where m.Id == moduleId select m).FirstOrDefault();
                var storiesLoad = (from s in db.storiesLoad.ToList() where s.StoryId == module.StoryId select s).FirstOrDefault();

                var story = db.stories.Find(module.StoryId);
                int playerId = GetPlayerId(userName);
                if (db.playerStatuses.Where(ps => ps.ModuleId == moduleId && ps.PlayerId == playerId).ToList().Count > 0)
                {
                    var playerStatus = db.playerStatuses.Where(ps => ps.ModuleId == moduleId && ps.PlayerId == playerId).ToList().FirstOrDefault();
                    story = db.stories.Find(playerStatus.StoryId);
                    storyId = story.Id;
                    order = playerStatus.GameState;
                }
                LoadOptionPerStory(story, order);
                CheckStoryPerModule(moduleId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            try
            {
                int optionId = 0;
                order++;

                foreach (RadioButton rb in pnlOptionSet.Controls)
                {
                    if (rb.Checked)
                    {
                        string value = rb.Name.Substring(rb.Name.IndexOf("_") + 1);
                        optionId = Convert.ToInt32(value);
                        break;
                    }
                }

                pnlOptionSet.Controls.Clear();
                var storyLoad = db.storiesLoad.Where(sl => sl.OptionSetId == optionId).FirstOrDefault();

                if (storyLoad != null)
                {
                    var story = db.stories.Find(storyLoad.StoryId);
                    LoadOptionPerStory(story, order);
                    CheckStoryPerModule(moduleId);
                    this.storyId = story.Id;
                }
                else
                {
                    MessageBox.Show("There are no stories under this option. Please, fill stories first.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void LoadOptionPerStory(Story story, int groupOrder)
        {
            lblShortDescription.Text = story.ShortDescription;
            lblDescriptiveText.Text = story.DescriptiveText;
            var options = db.optionSetPerStories.Where(o => o.StoryId == story.Id).Include(op => op.OptionSet).ToList();
            int i = 1;
            GroupBox gb = new GroupBox();
            gb.Name = "GroupOption";
            gb.Location = new Point(40, 105);
            int y = 25;

            foreach (OptionSetPerStory ops in options)
            {
                RadioButton rb = new RadioButton();
                rb.Name = "Option_" + ops.OptionSetId.ToString();
                rb.Location = new Point(40, y);
                rb.Text = ops.OptionSet.OptionText;
                rb.Width = 200;
                pnlOptionSet.Controls.Add(rb);
                i++;
                y += 25;
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            try
            {
                SavePlayerStatus(order);
                MessageBox.Show("Successfully saved your game state");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private int GetPlayerId(string userName)
        {
            return db.players.Where(p => p.UserName == userName).ToList().FirstOrDefault().Id;
        }

        private void CheckStoryPerModule(int moduleId)
        {
            var module = db.modules.Find(moduleId);
            if (module.NumberOfStories == order)
            {
                btnNext.Visible = false;
                btnEnd.Visible = true;
            }
            else
            {
                btnNext.Visible = true;
                btnEnd.Visible = false;
            }
        }

        private void btnEnd_Click(object sender, EventArgs e)
        {
            try
            {
                SavePlayerStatus(10);
                MessageBox.Show("The game has finshed.");
                StartGame f = new StartGame();
                f.Show();
                this.Close();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void SavePlayerStatus(int order)
        {
            var playerId = db.players.Where(p => p.UserName == userName).FirstOrDefault().Id;
            PlayerStatus playerStatus = null;
            bool isUpdate = false;
            if (db.playerStatuses.Where(ps => ps.ModuleId == moduleId && ps.PlayerId == playerId).ToList().Count > 0)
            {
                playerStatus = db.playerStatuses.Where(ps => ps.ModuleId == moduleId && ps.PlayerId == playerId).FirstOrDefault();
                isUpdate = true;
            }
            else
            {
                playerStatus = new PlayerStatus();
            }

            playerStatus.StoryId = storyId;
            playerStatus.GameState = order;
            playerStatus.PlayerId = playerId;
            playerStatus.ModuleId = moduleId;
            if (isUpdate)
            {
                var entry = db.Entry(playerStatus);
                db.playerStatuses.Attach(playerStatus);
                entry.State = System.Data.Entity.EntityState.Modified;
            }
            else
                db.playerStatuses.Add(playerStatus);
            db.SaveChangesAsync();

           
        }
    }
}
