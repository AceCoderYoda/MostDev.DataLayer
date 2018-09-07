namespace MostDev.DataLayer.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class instanceofusers : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        Id = c.Guid(nullable: false),
                        UserName = c.String(unicode: false),
                        FirstName = c.String(unicode: false),
                        Interjection = c.String(unicode: false),
                        LastName = c.String(unicode: false),
                        Email = c.String(unicode: false),
                        Password = c.String(unicode: false),
                        Active = c.Boolean(nullable: false),
                        LockedOut = c.Boolean(nullable: false),
                        LastAccessed = c.Long(nullable: false),
                        LastUser = c.Guid(nullable: false),
                        CreateUser = c.Guid(nullable: false),
                        LastDate = c.Long(nullable: false),
                        CreatedDate = c.Long(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Users");
        }
    }
}
