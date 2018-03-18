using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration.Conventions;
using System.Data.Entity;
using Edutainment.Models;

namespace Edutainment
{
    public class EdutainmentContext:DbContext
    {
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
        public DbSet<Module> modules { get; set; }
        public DbSet<Story> stories { get; set; }
        public DbSet<OptionSet> optionSets { get; set; }
        public DbSet<StoryLoad> storiesLoad { get; set; }
        public DbSet<OptionSetPerStory> optionSetPerStories { get; set; }
        public DbSet<StoriesPerModule> storiesPerModule { get; set; }
        public DbSet<Player> players { get; set; }
        public DbSet<PlayerStatus> playerStatuses { get; set; }
    }
}
