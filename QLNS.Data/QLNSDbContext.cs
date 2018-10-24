using QLNS.Model.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QLNS.Data
{
    public class QLNSDbContext : DbContext
    {
        public QLNSDbContext() : base("QLNSConnection")
        {
            this.Configuration.LazyLoadingEnabled = false;
        }
        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<WorkingProcess> WorkingProcesses { get; set; }
        public static QLNSDbContext Create()
        {
            return new QLNSDbContext();
        }
    }

}
