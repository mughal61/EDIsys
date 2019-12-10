namespace EDIsystems.Migrations.Jobs
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class EDIsystems_db_migrations_002 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Jobs", "JobDate", c => c.DateTime(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Jobs", "JobDate");
        }
    }
}
