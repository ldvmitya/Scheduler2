namespace Scheduler2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddScheduleMigration2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Schedules", "ScheduleDate", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Schedules", "ScheduleDate", c => c.DateTime(nullable: false));
        }
    }
}
