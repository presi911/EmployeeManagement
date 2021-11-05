using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Entities.Entry
{
    public class ETaskByEmployee
    {
        [Required]
        public int Task_Employee_ID { get; set; }
        [Required]
        public int EmployeeID { get; set; }
        public int TaskID { get; set; }
    }
}
