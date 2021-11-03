using DataAccess.Model.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model.Configuration
{
    public class EmployeeConfiguration
    {
        public EmployeeConfiguration(EntityTypeBuilder<Employee> entityBuilder)
        {
            entityBuilder.HasKey("EmployeeID");
            entityBuilder.HasIndex(e => e.EmployeeID);
            entityBuilder.Property(e => e.FullName).IsRequired().HasMaxLength(100);
            entityBuilder.Property(e => e.Age).IsRequired().HasMaxLength(2);
            entityBuilder.Property(e => e.Position).IsRequired().HasMaxLength(50);

        }

    }
}
