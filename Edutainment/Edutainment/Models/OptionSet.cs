using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edutainment.Models
{
    public class OptionSet
    {
        public OptionSet()
        {
            this.OptionSetPerStories = new List<OptionSetPerStory>();
        }
        public int Id
        {
            get;set;
        }        
        public string OptionText
        {
            get;set;
        }
        public virtual ICollection<OptionSetPerStory> OptionSetPerStories { get; set; }
    }
}
