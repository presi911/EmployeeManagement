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
        }

        private void ModelConfig(ModelBuilder modelBuilder)
        {
        new EmployeeConfiguration(modelBuilder.Entity<Employee>());
        new TaskConfiguration(modelBuilder.Entity<Entities.Task>());
        }

        }
    }
