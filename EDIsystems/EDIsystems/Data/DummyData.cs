using EDIsystems.Models.Jobs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EDIsystems.Data
{
    public class DummyData
    {
        public static List<App> getApps()
        {
            List<App> apps = new List<App>() {
                new App(){
                    AppName="Metro Hospital"
                },
                new App(){
                    AppName="Capital Risk"
                },
                new App(){
                    AppName="Disney"
                },
                new App(){
                    AppName="ET"
                }
            };
            return apps;
        }

        public static List<Job> getJobs(JobsContext context)
        {
            List<Job> jobs = new List<Job>() {
                new Job(){
                    Day = "Monday",
                    Time = TimeSpan.FromHours(8.5),
                    Success = "Success",
                    JobDate = Convert.ToDateTime("12/09/2019 06:01:00 PM"),
                    Files_DwUp = 60,
                    Files_Sorted = 60,
                    AppId = context.Apps.Find(2).AppId
                },
                 new Job(){
                    Day = "Friday",
                    Time = TimeSpan.FromHours(6.5),
                    Success = "Success",
                    JobDate = Convert.ToDateTime("12/06/2019 02:05:00 AM"),
                    Files_DwUp = 20,
                    Files_Sorted = 20,
                    AppId = context.Apps.Find(1).AppId
                },
                  new Job(){
                    Day = "Monday",
                    Time = TimeSpan.FromHours(5),
                    Success = "Failed",
                    JobDate = Convert.ToDateTime("12/02/2019 10:05:00 AM"),
                    Files_DwUp = 0,
                    Files_Sorted = 0,
                    AppId = context.Apps.Find(2).AppId
                },
                   new Job(){
                    Day = "Wednesday",
                    Time = TimeSpan.FromHours(6.5),
                    Success = "Success",
                    JobDate = Convert.ToDateTime("12/04/2019 08:05:00 AM"),
                    Files_DwUp = 200,
                    Files_Sorted = 300,
                    AppId = context.Apps.Find(1).AppId
                }
                   ,
                   new Job(){
                    Day = "Tuesday",
                    Time = TimeSpan.FromHours(6.5),
                    Success = "Success",
                    JobDate = Convert.ToDateTime("12/10/2019 05:45:00 AM"),
                    Files_DwUp = 15,
                    Files_Sorted = 15,
                    AppId = context.Apps.Find(4).AppId
                }
                   ,
                   new Job(){
                    Day = "Friday",
                    Time = TimeSpan.FromHours(6.5),
                    Success = "Failed",
                    JobDate = Convert.ToDateTime("11/29/2019 08:05:00 AM"),
                    Files_DwUp = 750,
                    Files_Sorted = 750,
                    AppId = context.Apps.Find(2).AppId
                },
                   new Job(){
                    Day = "Satuday",
                    Time = TimeSpan.FromHours(6.5),
                    Success = "Success",
                    JobDate = Convert.ToDateTime("12/07/2019 02:15:00 PM"),
                    Files_DwUp = 650,
                    Files_Sorted = 250,
                    AppId = context.Apps.Find(2).AppId
                },
                   new Job(){
                    Day = "Thursday",
                    Time = TimeSpan.FromHours(6.5),
                    Success = "Failed",
                    JobDate = Convert.ToDateTime("12/05/2019 08:00:00 AM"),
                    Files_DwUp = 0,
                    Files_Sorted = 10,
                    AppId = context.Apps.Find(3).AppId
                }
            };

            return jobs;
        }


    }
}