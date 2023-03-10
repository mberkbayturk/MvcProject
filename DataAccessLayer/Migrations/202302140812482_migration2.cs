namespace DataAccessLayer.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migration2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "CategoryDescription", c => c.String(maxLength: 200));
            DropColumn("dbo.Categories", "CategoryDesription");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Categories", "CategoryDesription", c => c.String(maxLength: 200));
            DropColumn("dbo.Categories", "CategoryDescription");
        }
    }
}
