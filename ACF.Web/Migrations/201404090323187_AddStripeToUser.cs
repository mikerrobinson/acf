namespace ACF.Web.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddStripeToUser : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.AspNetUsers", "StripeCustomerId", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.AspNetUsers", "StripeCustomerId");
        }
    }
}
