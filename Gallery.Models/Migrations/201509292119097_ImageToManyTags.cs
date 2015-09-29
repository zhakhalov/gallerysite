namespace Gallery.Models.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class ImageToManyTags : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Tags", "Image_ImageId", "dbo.Images");
            DropIndex("dbo.Tags", new[] { "Image_ImageId" });
            CreateTable(
                "dbo.TagImages",
                c => new
                    {
                        Tag_TagId = c.Int(nullable: false),
                        Image_ImageId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Tag_TagId, t.Image_ImageId })
                .ForeignKey("dbo.Tags", t => t.Tag_TagId, cascadeDelete: true)
                .ForeignKey("dbo.Images", t => t.Image_ImageId, cascadeDelete: true)
                .Index(t => t.Tag_TagId)
                .Index(t => t.Image_ImageId);
            
            DropColumn("dbo.Tags", "Image_ImageId");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Tags", "Image_ImageId", c => c.Int());
            DropForeignKey("dbo.TagImages", "Image_ImageId", "dbo.Images");
            DropForeignKey("dbo.TagImages", "Tag_TagId", "dbo.Tags");
            DropIndex("dbo.TagImages", new[] { "Image_ImageId" });
            DropIndex("dbo.TagImages", new[] { "Tag_TagId" });
            DropTable("dbo.TagImages");
            CreateIndex("dbo.Tags", "Image_ImageId");
            AddForeignKey("dbo.Tags", "Image_ImageId", "dbo.Images", "ImageId");
        }
    }
}
