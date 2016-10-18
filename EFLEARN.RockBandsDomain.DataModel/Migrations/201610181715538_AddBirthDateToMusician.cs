namespace EFLEARN.RockBandsDomain.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddBirthDateToMusician : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Mucisians", "BirthDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Mucisians", "BirthDate");
        }
    }
}
