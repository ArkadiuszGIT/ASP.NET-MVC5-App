namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class PopulateMovies : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded,ReleaseDate,NumberInStock) VALUES ('A Love So Beautiful',3,2017-11-03, 2017-12-12,3)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded,ReleaseDate,NumberInStock) VALUES ('Hangover',5,2016-05-04, 2009-11-06,5)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded,ReleaseDate,NumberInStock) VALUES ('Die Hard',1,2017-11-03, 2017-12-12,4)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded,ReleaseDate,NumberInStock) VALUES ('The Terminator',2,2017-11-03, 2017-12-12,2)");
            Sql("INSERT INTO Movies (Name, GenreId, DateAdded,ReleaseDate,NumberInStock) VALUES ('Toy Story',5,2017-11-03, 2017-12-12,1)");
        }
        
        public override void Down()
        {
        }
    }
}
