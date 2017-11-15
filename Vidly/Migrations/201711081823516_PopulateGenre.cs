namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateGenre : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Genres (Name) Values ('Comedy')");
            Sql("INSERT INTO Genres (Name) Values ('Drama')");
            Sql("INSERT INTO Genres (Name) Values ('Romance')");
            Sql("INSERT INTO Genres (Name) Values ('Action')");
            Sql("INSERT INTO Genres (Name) Values ('Fantasy')");
            Sql("INSERT INTO Genres (Name) Values ('Sci-Fi')");


        }
        
        public override void Down()
        {
        }
    }
}
