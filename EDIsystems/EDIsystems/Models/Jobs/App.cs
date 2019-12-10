using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace EDIsystems.Models.Jobs
{
    public class App
    {
        [Key]
        public int AppId { get; set; }
        [MaxLength(50)]
        public string AppName { get; set; }

        public List<Job> Jobs { get; set; }
    }
}