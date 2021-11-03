using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model.Entities
{
    public class Task
    {
        public int TaskID { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Priority { get; set; }


    }
}
