namespace QLNS.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Addavatarpropertytoemployeeentity : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Employee", "Avatar", c => c.String(unicode: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Employee", "Avatar");
        }
    }
}
