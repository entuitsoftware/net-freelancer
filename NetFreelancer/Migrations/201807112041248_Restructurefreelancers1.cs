namespace NetFreelancer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Restructurefreelancers1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Freelancers", "UserId", c => c.String(maxLength: 128));
            CreateIndex("dbo.Freelancers", "UserId");
            AddForeignKey("dbo.Freelancers", "UserId", "dbo.AspNetUsers", "Id");
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Freelancers", "UserId", "dbo.AspNetUsers");
            DropIndex("dbo.Freelancers", new[] { "UserId" });
            AlterColumn("dbo.Freelancers", "UserId", c => c.String());
        }
    }
}
