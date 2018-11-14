namespace QLNS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialMigration : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Department",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Alias = c.String(nullable: false, maxLength: 50, unicode: false),
                        Status = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                        ModifiedBy = c.String(),
                        MetaKeyword = c.String(),
                        MetaDescription = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Employee",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        Name = c.String(maxLength: 50),
                        DateOfBirth = c.DateTime(nullable: false),
                        Gender = c.Boolean(nullable: false),
                        Phone = c.String(),
                        Email = c.String(),
                        IDCardNo = c.String(),
                        DateIssued = c.DateTime(nullable: false),
                        PlaceIssued = c.String(),
                        JoinDate = c.DateTime(nullable: false),
                        DepartmentId = c.Int(nullable: false),
                        LeaderId = c.Long(nullable: false),
                        PositionId = c.Int(nullable: false),
                        Status = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                        ModifiedBy = c.String(),
                        MetaKeyword = c.String(),
                        MetaDescription = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Department", t => t.DepartmentId, cascadeDelete: true)
                .ForeignKey("dbo.Employee", t => t.LeaderId)
                .ForeignKey("dbo.Position", t => t.PositionId, cascadeDelete: true)
                .Index(t => t.DepartmentId)
                .Index(t => t.LeaderId)
                .Index(t => t.PositionId);
            
            CreateTable(
                "dbo.Position",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                        Status = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                        ModifiedBy = c.String(),
                        MetaKeyword = c.String(),
                        MetaDescription = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.WorkingProcess",
                c => new
                    {
                        Id = c.Long(nullable: false, identity: true),
                        EmployeeId = c.Long(nullable: false),
                        DepartmentId = c.Int(nullable: false),
                        PositionId = c.Int(nullable: false),
                        StartDate = c.DateTime(nullable: false),
                        EndDate = c.DateTime(nullable: false),
                        Status = c.Boolean(nullable: false),
                        CreatedDate = c.DateTime(nullable: false),
                        CreatedBy = c.String(),
                        ModifiedDate = c.DateTime(),
                        ModifiedBy = c.String(),
                        MetaKeyword = c.String(),
                        MetaDescription = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Department", t => t.DepartmentId, cascadeDelete: false)
                .ForeignKey("dbo.Employee", t => t.EmployeeId, cascadeDelete: false)
                .ForeignKey("dbo.Position", t => t.PositionId, cascadeDelete: false)
                .Index(t => t.EmployeeId)
                .Index(t => t.DepartmentId)
                .Index(t => t.PositionId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.WorkingProcess", "PositionId", "dbo.Position");
            DropForeignKey("dbo.WorkingProcess", "EmployeeId", "dbo.Employee");
            DropForeignKey("dbo.WorkingProcess", "DepartmentId", "dbo.Department");
            DropForeignKey("dbo.Employee", "PositionId", "dbo.Position");
            DropForeignKey("dbo.Employee", "LeaderId", "dbo.Employee");
            DropForeignKey("dbo.Employee", "DepartmentId", "dbo.Department");
            DropIndex("dbo.WorkingProcess", new[] { "PositionId" });
            DropIndex("dbo.WorkingProcess", new[] { "DepartmentId" });
            DropIndex("dbo.WorkingProcess", new[] { "EmployeeId" });
            DropIndex("dbo.Employee", new[] { "PositionId" });
            DropIndex("dbo.Employee", new[] { "LeaderId" });
            DropIndex("dbo.Employee", new[] { "DepartmentId" });
            DropTable("dbo.WorkingProcess");
            DropTable("dbo.Position");
            DropTable("dbo.Employee");
            DropTable("dbo.Department");
        }
    }
}
