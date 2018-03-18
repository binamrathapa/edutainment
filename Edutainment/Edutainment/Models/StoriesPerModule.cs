using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Edutainment.Models
{
    public class StoriesPerModule
    {
        public int Id
        {
            get; set;
        }
        public int StoryId
        {
            get; set;
        }
        public int ModuleId
        {
            get; set;
        }
    }
}
