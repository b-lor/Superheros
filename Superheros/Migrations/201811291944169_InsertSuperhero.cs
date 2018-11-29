namespace Superheros.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InsertSuperhero : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Heroes (Id, Name, AlterEgo, AbilityOne, AbilityTwo, Catchphrase) VALUES (2, Bill, Bucks, Ice, Fire, Rich)");
        }
        
        public override void Down()
        {
        }
    }
}
