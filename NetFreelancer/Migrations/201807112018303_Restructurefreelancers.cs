namespace NetFreelancer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Restructurefreelancers : DbMigration
    {
        public override void Up()
        {
            RenameTable(name: "dbo.AspNetUsers", newName: "Freelancers");
            DropIndex("dbo.Freelancers", "UserNameIndex");
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        FirstName = c.String(),
                        LastName = c.String(),
                        UserType = c.Int(nullable: false),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            AddColumn("dbo.Freelancers", "UserId", c => c.String());
            AlterColumn("dbo.Freelancers", "Email", c => c.String());
            DropColumn("dbo.Freelancers", "FirstName");
            DropColumn("dbo.Freelancers", "LastName");
            DropColumn("dbo.Freelancers", "UserType");
            DropColumn("dbo.Freelancers", "EmailConfirmed");
            DropColumn("dbo.Freelancers", "PasswordHash");
            DropColumn("dbo.Freelancers", "SecurityStamp");
            DropColumn("dbo.Freelancers", "PhoneNumberConfirmed");
            DropColumn("dbo.Freelancers", "TwoFactorEnabled");
            DropColumn("dbo.Freelancers", "LockoutEndDateUtc");
            DropColumn("dbo.Freelancers", "LockoutEnabled");
            DropColumn("dbo.Freelancers", "AccessFailedCount");
            DropColumn("dbo.Freelancers", "UserName");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Freelancers", "UserName", c => c.String(nullable: false, maxLength: 256));
            AddColumn("dbo.Freelancers", "AccessFailedCount", c => c.Int(nullable: false));
            AddColumn("dbo.Freelancers", "LockoutEnabled", c => c.Boolean(nullable: false));
            AddColumn("dbo.Freelancers", "LockoutEndDateUtc", c => c.DateTime());
            AddColumn("dbo.Freelancers", "TwoFactorEnabled", c => c.Boolean(nullable: false));
            AddColumn("dbo.Freelancers", "PhoneNumberConfirmed", c => c.Boolean(nullable: false));
            AddColumn("dbo.Freelancers", "SecurityStamp", c => c.String());
            AddColumn("dbo.Freelancers", "PasswordHash", c => c.String());
            AddColumn("dbo.Freelancers", "EmailConfirmed", c => c.Boolean(nullable: false));
            AddColumn("dbo.Freelancers", "UserType", c => c.Int(nullable: false));
            AddColumn("dbo.Freelancers", "LastName", c => c.String());
            AddColumn("dbo.Freelancers", "FirstName", c => c.String());
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            AlterColumn("dbo.Freelancers", "Email", c => c.String(maxLength: 256));
            DropColumn("dbo.Freelancers", "UserId");
            DropTable("dbo.AspNetUsers");
            CreateIndex("dbo.Freelancers", "UserName", unique: true, name: "UserNameIndex");
            RenameTable(name: "dbo.Freelancers", newName: "AspNetUsers");
        }
    }
}
