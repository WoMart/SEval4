using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Hosting;
using Microsoft.Extensions.Logging;
using SEval4.Data;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace SEval4
{
    public class Program
    {
        public static void Main(string[] args)
        {
//#if DEBUG
//            ClearDatabase();
//#endif
            CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                });

        private static void ClearDatabase()
        {
            if (File.Exists("Private/SurveyDb.db"))
            {
                File.Delete("Private/SurveyDb.db");
            }
        }
    }
}
