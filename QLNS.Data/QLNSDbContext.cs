namespace QLNS.Data
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;
    using QLNS.Model.Models;

    public partial class QLNSDbContext : DbContext
    {
        public QLNSDbContext()
            : base("name=QLNSDbContext")
        {
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<WorkingProcess> WorkingProcesses { get; set; }

        public static QLNSDbContext Create()
        {
            return new QLNSDbContext();
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }
    }
}
