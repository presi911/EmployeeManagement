using DataAccess.Model.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model.Configuration
{
    public class TaskConfiguration
    {
        public TaskConfiguration(EntityTypeBuilder<Entities.Task> entityBuilder)
        {
            entityBuilder.HasKey("TaskID");
            entityBuilder.HasIndex(t => t.TaskID);
            entityBuilder.Property(t => t.Title).IsRequired().HasMaxLength(100);
            entityBuilder.Property(t => t.Description).IsRequired().HasMaxLength(300);
            entityBuilder.Property(t => t.Priority).IsRequired().HasMaxLength(10);
        }
    }
}
