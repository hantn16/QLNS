namespace QLNS.Data.Migrations
{
    using QLNS.Model.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<QLNS.Data.MyQLNSDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(QLNS.Data.MyQLNSDbContext context)
        {
            //  This method will be called after migrating to the latest version.
                Department dp = new Department() {
                    Name = "Bộ phận văn phòng",
                    Alias = "bo-phan-van-phong",
                    Status = true,
                    CreatedBy = "admin",
                    CreatedDate = DateTime.Now,
                    ModifiedBy = null,
                    ModifiedDate = null
                };
                Department dp2 = new Department()
                {
                    Name = "Bộ phận kỹ thuật",
                    Alias = "bo-phan-ky-thuat",
                    Status = true,
                    CreatedBy = "admin",
                    CreatedDate = DateTime.Now,
                    ModifiedBy = null,
                    ModifiedDate = null
                };
                context.Departments.Add(dp);
                context.Departments.Add(dp2);
                context.SaveChanges();
                Position pos1 = new Position()
                {
                    Name = "Trưởng ban",
                    Status = true,
                    CreatedBy = "admin",
                    CreatedDate = DateTime.Now,
                    ModifiedBy = null,
                    ModifiedDate = null
                };
                context.Positions.Add(pos1);
                context.SaveChanges();
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
