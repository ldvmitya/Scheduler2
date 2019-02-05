using System;
using System.ComponentModel.DataAnnotations;

namespace Scheduler2.Models
{
    public class Schedule
    {
        public int Id { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime ScheduleDate { get; set; }
        public string Description { get; set; }
    }
}