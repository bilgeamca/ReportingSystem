using System;

namespace EntityLayer
{
    public class FinishedProductReport
    {
        public int Id { get; set; }
        public DateTime ReportDateTime { get; set; } = DateTime.UtcNow;
        public string Code { get; set; }
        public string Name { get; set; }
        public decimal RequestedKg { get; set; }
        public decimal ProvidedKg { get; set; }
        public decimal ErrorKg { get; set; }
        public TimeSpan Duration { get; set; }
    }
}