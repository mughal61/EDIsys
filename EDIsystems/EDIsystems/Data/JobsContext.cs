using EDIsystems.Models.Jobs;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace EDIsystems.Data
{
    public class JobsContext: DbContext
    {
        public JobsContext()
            :base("DefaultConnection")
        {
        }

        public DbSet<App> Apps { get; set; }
        public DbSet<Job> Jobs { get; set; }
    }
}