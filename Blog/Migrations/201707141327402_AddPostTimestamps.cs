namespace Blog.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPostTimestamps : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Posts", "Created", c => c.DateTime(nullable: false));
            AddColumn("dbo.Posts", "LastChanged", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Posts", "LastChanged");
            DropColumn("dbo.Posts", "Created");
        }
    }
}
