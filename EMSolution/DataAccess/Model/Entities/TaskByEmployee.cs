using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model.Entities
{
    public class TaskByEmployee
    {

        public int Task_Employee_ID { get; set; }
        public int EmployeeID { get; set; }
        public Employee Employee { get; set; }
        public int TaskID { get; set; }
        public Task Task { get; set; }

        //public Employee IdEmployeeNavigation { get; set; }
        //public virtual Task IdTaskNavigation { get; set; }

    }
}
