namespace CollegeLolaGonzalezControl.Infraestructure.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Qualification : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Qualification",
                c => new
                    {
                        QualificactionId = c.String(nullable: false, maxLength: 100),
                        CreationDate = c.DateTime(nullable: false),
                        LastStatusDate = c.DateTime(nullable: false),
                        QualificationStatusId = c.Int(nullable: false),
                        UserId = c.String(nullable: false, maxLength: 100),
                        Message = c.String(nullable: false),
                    })
                .PrimaryKey(t => t.QualificactionId)
                .ForeignKey("dbo.QualificationStatus", t => t.QualificationStatusId)
                .ForeignKey("dbo.User", t => t.UserId)
                .Index(t => t.QualificationStatusId)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.QualificationStatus",
                c => new
                    {
                        QualificationStatusId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 50),
                    })
                .PrimaryKey(t => t.QualificationStatusId);
            
            CreateTable(
                "dbo.User",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 100),
                        FullName = c.String(nullable: false, maxLength: 100),
                        Email = c.String(nullable: false, maxLength: 20),
                        MobilePhone = c.String(maxLength: 20),
                        UserProfileId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserId)
                .ForeignKey("dbo.UserProfile", t => t.UserProfileId)
                .Index(t => t.UserProfileId);
            
            CreateTable(
                "dbo.UserProfile",
                c => new
                    {
                        UserProfileId = c.Int(nullable: false, identity: true),
                        Name = c.String(nullable: false, maxLength: 100),
                    })
                .PrimaryKey(t => t.UserProfileId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Qualification", "UserId", "dbo.User");
            DropForeignKey("dbo.User", "UserProfileId", "dbo.UserProfile");
            DropForeignKey("dbo.Qualification", "QualificationStatusId", "dbo.QualificationStatus");
            DropIndex("dbo.User", new[] { "UserProfileId" });
            DropIndex("dbo.Qualification", new[] { "UserId" });
            DropIndex("dbo.Qualification", new[] { "QualificationStatusId" });
            DropTable("dbo.UserProfile");
            DropTable("dbo.User");
            DropTable("dbo.QualificationStatus");
            DropTable("dbo.Qualification");
        }
    }
}
