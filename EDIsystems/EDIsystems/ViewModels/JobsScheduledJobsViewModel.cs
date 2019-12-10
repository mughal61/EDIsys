using EDIsystems.Models.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;



namespace EDIsystems.ViewModels
{
    public class JobsScheduledJobsViewModel
    {
        public List<string> daysList { get; set; }
        public List<App> appsList { get; set; }
        public List<Job> jobsList { get; set; }
        public DateTime currentDate { get; set; }
        public int weekNumber { get; set; }
    }
}