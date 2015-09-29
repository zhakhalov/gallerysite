namespace Gallery.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImageAndTag : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Images",
                c => new
                    {
                        ImageId = c.Int(nullable: false, identity: true),
                        ImagePath = c.String(nullable: false),
                        ImageUrl = c.String(nullable: false),
                        Title = c.String(nullable: false, maxLength: 64),
                        Description = c.String(maxLength: 1024),
                    })
                .PrimaryKey(t => t.ImageId);
            
            CreateTable(
                "dbo.Tags",
                c => new
                    {
                        TagId = c.Int(nullable: false, identity: true),
                        Title = c.String(nullable: false, maxLength: 32),
                        Image_ImageId = c.Int(),
                    })
                .PrimaryKey(t => t.TagId)
                .ForeignKey("dbo.Images", t => t.Image_ImageId)
                .Index(t => t.Image_ImageId);
            
            AlterColumn("dbo.Categories", "Title", c => c.String(nullable: false, maxLength: 255));
            AlterColumn("dbo.Users", "FirstName", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "LastName", c => c.String(nullable: false));
            AlterColumn("dbo.Users", "Roles", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Tags", "Image_ImageId", "dbo.Images");
            DropIndex("dbo.Tags", new[] { "Image_ImageId" });
            AlterColumn("dbo.Users", "Roles", c => c.String());
            AlterColumn("dbo.Users", "LastName", c => c.String());
            AlterColumn("dbo.Users", "FirstName", c => c.String());
            AlterColumn("dbo.Categories", "Title", c => c.String(nullable: false));
            DropTable("dbo.Tags");
            DropTable("dbo.Images");
        }
    }
}
