using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edutainment.Models
{
    public class Story
    {
        public Story()
        {
            this.OptionSetPerStories = new List<OptionSetPerStory>();
        }
        public int Id
        {
            get; set;
        }
        public string ShortDescription
        {
            get; set;
        }
        public string DescriptiveText
        {
            get;set;
        }
        public virtual ICollection<OptionSetPerStory> OptionSetPerStories { get; set; }


    }

}
