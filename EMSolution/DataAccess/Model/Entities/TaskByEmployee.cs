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
        public int TaskID { get; set; }

        public virtual Employee Employee { get; set; }
        public virtual Task Task { get; set; }

    }
}
