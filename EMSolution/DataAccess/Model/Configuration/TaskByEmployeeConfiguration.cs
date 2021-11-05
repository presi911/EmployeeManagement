using DataAccess.Model.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model.Configuration
{
    class TaskByEmployeeConfiguration
    {
		public TaskByEmployeeConfiguration(EntityTypeBuilder<TaskByEmployee> entityBuilder)
		{
            //entityBuilder
            //    .HasOne(pt => pt.Employee)
            //    .WithMany(p => p.TaskByEmployees)
            //    .HasForeignKey(pt => pt.EmployeeID);

            //entityBuilder
            //    .HasOne(pt => pt.Task)
            //    .WithMany(t => t.TaskByEmployees)
            //    .HasForeignKey(pt => pt.TaskID);
        }
	}
}
