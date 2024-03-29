﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;

namespace Coldairarrow.Web
{
    public class Program
    {
        public static void Main(string[] args)
        {
            CreateWebHostBuilder(args).Build().Run();
        }

        public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
            WebHost.CreateDefaultBuilder(args)
                .UseUrls("http://*:5888")
                .UseStartup<Startup>();
    }
}
