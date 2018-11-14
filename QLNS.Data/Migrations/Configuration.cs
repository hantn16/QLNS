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
            using (var db = new MyQLNSDbContext())
            {
                Department dp = new Department() { Name = "Bộ phận văn phòng", Alias = "bo-phan-van-phong" };
                db.Departments.Add(dp);
                db.SaveChanges();
            }
            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
