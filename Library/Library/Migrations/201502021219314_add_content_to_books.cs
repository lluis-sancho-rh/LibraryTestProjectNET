namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_content_to_books : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Books", "Author_AuthorID", "dbo.Authors");
            DropIndex("dbo.Books", new[] { "Author_AuthorID" });
            RenameColumn(table: "dbo.Books", name: "Author_AuthorID", newName: "AuthorID");
            AddColumn("dbo.Books", "Content", c => c.String());            
            AddForeignKey("dbo.Books", "AuthorID", "dbo.Authors", "AuthorID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "AuthorID", "dbo.Authors");
            DropColumn("dbo.Books", "Content");
            RenameColumn(table: "dbo.Books", name: "AuthorID", newName: "Author_AuthorID");
            CreateIndex("dbo.Books", "Author_AuthorID");
            AddForeignKey("dbo.Books", "Author_AuthorID", "dbo.Authors", "AuthorID");
        }
    }
}
