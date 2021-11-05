using DataAccess.Model.Configuration;
using DataAccess.Model.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Model.Context
{
    public class EMDbContext : DbContext
    {
        public EMDbContext(DbContextOptions options) : base(options)
        {
        }

        public DbSet<Employee> Employees{ get; set; }
        public DbSet<Entities.Task> Tasks { get; set; }
        public DbSet<TaskByEmployee> TaskByEmployees { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //Model Contraints
            base.OnModelCreating(builder);
            ModelConfig(builder);

            //ManytoManyRelationship
            builder.Entity<TaskByEmployee>()
            .HasKey(t => new { t.EmployeeID, t.TaskID });

            builder.Entity<TaskByEmployee>()
                .HasOne(pt => pt.Employee)
                .WithMany(p => p.TaskByEmployees)
                .HasForeignKey(pt => pt.EmployeeID);

            builder.Entity<TaskByEmployee>()
                .HasOne(pt => pt.Task)
                .WithMany(t => t.TaskByEmployees)
                .HasForeignKey(pt => pt.TaskID);

        }

        private void ModelConfig(ModelBuilder modelBuilder)
        {
        new EmployeeConfiguration(modelBuilder.Entity<Employee>());
        new TaskConfiguration(modelBuilder.Entity<Entities.Task>());
        }

        }
    }
