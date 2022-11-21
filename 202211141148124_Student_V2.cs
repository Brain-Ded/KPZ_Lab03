namespace KPZ_Lab03CF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Student_V2 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Students", "AverageProgramming", c => c.Double());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Students", "AverageProgramming");
        }
    }
}
