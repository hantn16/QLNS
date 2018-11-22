namespace QLNS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RenameIAuditableInterfaceProperties : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.Employee", new[] { "LeaderId" });
            AddColumn("dbo.Department", "CreatedAt", c => c.DateTime(nullable: false));
            AddColumn("dbo.Department", "ModifiedAt", c => c.DateTime());
            AddColumn("dbo.Employee", "CreatedAt", c => c.DateTime(nullable: false));
            AddColumn("dbo.Employee", "ModifiedAt", c => c.DateTime());
            AddColumn("dbo.Position", "CreatedAt", c => c.DateTime(nullable: false));
            AddColumn("dbo.Position", "ModifiedAt", c => c.DateTime());
            AddColumn("dbo.WorkingProcess", "CreatedAt", c => c.DateTime(nullable: false));
            AddColumn("dbo.WorkingProcess", "ModifiedAt", c => c.DateTime());
            AlterColumn("dbo.Employee", "LeaderId", c => c.Long());
            CreateIndex("dbo.Employee", "LeaderId");
            DropColumn("dbo.Department", "CreatedDate");
            DropColumn("dbo.Department", "ModifiedDate");
            DropColumn("dbo.Employee", "CreatedDate");
            DropColumn("dbo.Employee", "ModifiedDate");
            DropColumn("dbo.Position", "CreatedDate");
            DropColumn("dbo.Position", "ModifiedDate");
            DropColumn("dbo.WorkingProcess", "CreatedDate");
            DropColumn("dbo.WorkingProcess", "ModifiedDate");
        }
        
        public override void Down()
        {
            AddColumn("dbo.WorkingProcess", "ModifiedDate", c => c.DateTime());
            AddColumn("dbo.WorkingProcess", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Position", "ModifiedDate", c => c.DateTime());
            AddColumn("dbo.Position", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Employee", "ModifiedDate", c => c.DateTime());
            AddColumn("dbo.Employee", "CreatedDate", c => c.DateTime(nullable: false));
            AddColumn("dbo.Department", "ModifiedDate", c => c.DateTime());
            AddColumn("dbo.Department", "CreatedDate", c => c.DateTime(nullable: false));
            DropIndex("dbo.Employee", new[] { "LeaderId" });
            AlterColumn("dbo.Employee", "LeaderId", c => c.Long(nullable: false));
            DropColumn("dbo.WorkingProcess", "ModifiedAt");
            DropColumn("dbo.WorkingProcess", "CreatedAt");
            DropColumn("dbo.Position", "ModifiedAt");
            DropColumn("dbo.Position", "CreatedAt");
            DropColumn("dbo.Employee", "ModifiedAt");
            DropColumn("dbo.Employee", "CreatedAt");
            DropColumn("dbo.Department", "ModifiedAt");
            DropColumn("dbo.Department", "CreatedAt");
            CreateIndex("dbo.Employee", "LeaderId");
        }
    }
}
