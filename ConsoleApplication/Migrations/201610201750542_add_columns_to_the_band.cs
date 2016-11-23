namespace ConsoleApplication.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_columns_to_the_band : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bands", "IsActive", c => c.Boolean(nullable: false));
            AddColumn("dbo.Bands", "CreatedOn", c => c.DateTime(nullable: false));
            AddColumn("dbo.Bands", "ModifiedOn", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bands", "ModifiedOn");
            DropColumn("dbo.Bands", "CreatedOn");
            DropColumn("dbo.Bands", "IsActive");
        }
    }
}
