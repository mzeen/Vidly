namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("Insert into Movies(Name, ReleasedDate, DateAdded, Stock, GenreId) Values ('Trolling', 1-01-2017, 2-01-2017, 80, 1)");
            Sql("Insert into Movies(Name, ReleasedDate, DateAdded, Stock, GenreId) Values('Spectre', 1-01-2017, 2-01-2017, 70, 2)");
            Sql("Insert into Movies(Name, ReleasedDate, DateAdded, Stock, GenreId) Values ('The End Of The Beginning', 1-01-2017, 2-01-2017, 50, 3)");
            Sql("Insert into Movies(Name, ReleasedDate, DateAdded, Stock, GenreId) Values('Dead Party', 1-01-2017, 2-01-2017, 350, 4)");
            Sql("Insert into Movies(Name, ReleasedDate, DateAdded, Stock, GenreId) Values('Mile to You', 1-01-2017, 2-01-2017, 350, 5)");
            Sql("Insert into Movies(Name, ReleasedDate, DateAdded, Stock, GenreId) Values('Nighter', 1-01-2017, 2-01-2017, 350, 6)");
        }
        
        public override void Down()
        {
        }
    }
}
