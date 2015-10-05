namespace Gallery.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class categoryimage : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Categories", "Slug", c => c.String());
            AddColumn("dbo.Categories", "ImagePath", c => c.String());
            AddColumn("dbo.Categories", "ImageUrl", c => c.String());
            AlterColumn("dbo.Images", "ImagePath", c => c.String());
            AlterColumn("dbo.Images", "ImageUrl", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Images", "ImageUrl", c => c.String(nullable: false));
            AlterColumn("dbo.Images", "ImagePath", c => c.String(nullable: false));
            DropColumn("dbo.Categories", "ImageUrl");
            DropColumn("dbo.Categories", "ImagePath");
            DropColumn("dbo.Categories", "Slug");
        }
    }
}
