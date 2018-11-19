namespace QLNS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RefixAuditableabstractclass : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Department", "MetaKeyword");
            DropColumn("dbo.Department", "MetaDescription");
            DropColumn("dbo.Employee", "MetaKeyword");
            DropColumn("dbo.Employee", "MetaDescription");
            DropColumn("dbo.Position", "MetaKeyword");
            DropColumn("dbo.Position", "MetaDescription");
            DropColumn("dbo.WorkingProcess", "MetaKeyword");
            DropColumn("dbo.WorkingProcess", "MetaDescription");
        }
        
        public override void Down()
        {
            AddColumn("dbo.WorkingProcess", "MetaDescription", c => c.String());
            AddColumn("dbo.WorkingProcess", "MetaKeyword", c => c.String());
            AddColumn("dbo.Position", "MetaDescription", c => c.String());
            AddColumn("dbo.Position", "MetaKeyword", c => c.String());
            AddColumn("dbo.Employee", "MetaDescription", c => c.String());
            AddColumn("dbo.Employee", "MetaKeyword", c => c.String());
            AddColumn("dbo.Department", "MetaDescription", c => c.String());
            AddColumn("dbo.Department", "MetaKeyword", c => c.String());
        }
    }
}
