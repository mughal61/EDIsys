using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EDIsystems.Models.Jobs
{
    public class Job
    {
        [Key]
        public int JobId { get; set; }
        public TimeSpan? Time { get; set; }
        public string Day { get; set; }
        public DateTime JobDate { get; set; }
        public string Success { get; set; }
        public int? Files_DwUp { get; set; }
        public int? Files_Sorted { get; set; }

        public int AppId { get; set; }
        public App App { get; set; }
    }
}