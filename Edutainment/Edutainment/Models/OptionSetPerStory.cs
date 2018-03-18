using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edutainment.Models
{
    public class OptionSetPerStory
    {
        public int Id
        {
            get;set;
        }
        public int OptionSetId
        {
            get;set;
        }
        public int StoryId
        {
            get;
            set;
        }
        
        public virtual Story Story { get; set; }
        public virtual OptionSet OptionSet { get; set; }
    }
}
