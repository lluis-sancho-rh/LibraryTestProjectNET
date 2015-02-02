namespace Library.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class add_author_id_to_books : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Books", "Author_AuthorID", "dbo.Authors");
            DropIndex("dbo.Books", new[] { "Author_AuthorID" });
            RenameColumn(table: "dbo.Books", name: "Author_AuthorID", newName: "AuthorID");
            AlterColumn("dbo.Books", "AuthorID", c => c.Int(nullable: false));
            CreateIndex("dbo.Books", "AuthorID");
            AddForeignKey("dbo.Books", "AuthorID", "dbo.Authors", "AuthorID", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Books", "AuthorID", "dbo.Authors");
            DropIndex("dbo.Books", new[] { "AuthorID" });
            AlterColumn("dbo.Books", "AuthorID", c => c.Int());
            RenameColumn(table: "dbo.Books", name: "AuthorID", newName: "Author_AuthorID");
            CreateIndex("dbo.Books", "Author_AuthorID");
            AddForeignKey("dbo.Books", "Author_AuthorID", "dbo.Authors", "AuthorID");
        }
    }
}
