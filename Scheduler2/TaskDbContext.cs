using System.Data.Entity;
using Scheduler2.Models;

namespace MvcTasksApplication
{
    public class TaskDbContext : DbContext
    {
        public TaskDbContext()
        {
            Database.Connection.ConnectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=|DataDirectory|\MvcTasksApplication.ScheduleDbContext.mdf;Integrated Security=True;Connect Timeout=30";
        }

        public DbSet<Schedule> Schedules { get; set; }
    }
}