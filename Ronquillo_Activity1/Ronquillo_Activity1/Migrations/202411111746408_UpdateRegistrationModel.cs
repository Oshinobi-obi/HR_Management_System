namespace Ronquillo_Activity1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateRegistrationModel : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Registrations", "Username", c => c.String(nullable: false));
            AlterColumn("dbo.Registrations", "Password", c => c.String(nullable: false));
            AlterColumn("dbo.Registrations", "ConfirmPassword", c => c.String(nullable: false));
            AlterColumn("dbo.Registrations", "Country", c => c.String(nullable: false));
            AlterColumn("dbo.Registrations", "City", c => c.String(nullable: false));
            AlterColumn("dbo.Registrations", "Address", c => c.String(nullable: false));
            AlterColumn("dbo.Registrations", "Mobile", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Registrations", "Mobile", c => c.String());
            AlterColumn("dbo.Registrations", "Address", c => c.String());
            AlterColumn("dbo.Registrations", "City", c => c.String());
            AlterColumn("dbo.Registrations", "Country", c => c.String());
            AlterColumn("dbo.Registrations", "ConfirmPassword", c => c.String());
            AlterColumn("dbo.Registrations", "Password", c => c.String());
            AlterColumn("dbo.Registrations", "Username", c => c.String());
        }
    }
}
