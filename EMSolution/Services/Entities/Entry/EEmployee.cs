using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Entities.Entry
{
    public class EEmployee
    {
        [MaxLength(100)]
        public string FullName { get; set; }
        [MaxLength(2)]
        public string Age { get; set; }
        [MaxLength(50)]
        public string Position { get; set; }
    }
}
