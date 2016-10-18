namespace EFLEARN.RockBandsDomain.DataModel.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bands",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        IsAcive = c.Boolean(nullable: false),
                        GenreId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Genres", t => t.GenreId, cascadeDelete: true)
                .Index(t => t.GenreId);
            
            CreateTable(
                "dbo.Genres",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Mucisians",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        SpecializationId = c.Int(nullable: false),
                        Band_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Bands", t => t.Band_Id)
                .ForeignKey("dbo.Specializations", t => t.SpecializationId, cascadeDelete: true)
                .Index(t => t.SpecializationId)
                .Index(t => t.Band_Id);
            
            CreateTable(
                "dbo.Specializations",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Mucisians", "SpecializationId", "dbo.Specializations");
            DropForeignKey("dbo.Mucisians", "Band_Id", "dbo.Bands");
            DropForeignKey("dbo.Bands", "GenreId", "dbo.Genres");
            DropIndex("dbo.Mucisians", new[] { "Band_Id" });
            DropIndex("dbo.Mucisians", new[] { "SpecializationId" });
            DropIndex("dbo.Bands", new[] { "GenreId" });
            DropTable("dbo.Specializations");
            DropTable("dbo.Mucisians");
            DropTable("dbo.Genres");
            DropTable("dbo.Bands");
        }
    }
}
