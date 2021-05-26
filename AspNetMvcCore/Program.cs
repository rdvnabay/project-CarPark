using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Serilog;

namespace AspNetMvcCore
{
    public class Program
    {
        public static void Main(string[] args)
        {
           Log.Logger = new LoggerConfiguration()
          .WriteTo.Console()
          //.WriteTo.File("log.txt")
          .WriteTo.Seq("http://localhost:5341/")
          .MinimumLevel.Information()
          .Enrich.WithMachineName()
          .Enrich.WithProperty("ApplicationName", "CarPark.MvcCoreWebUI")
          .CreateLogger();
           CreateHostBuilder(args).Build().Run();
        }

        public static IHostBuilder CreateHostBuilder(string[] args) =>
            Host.CreateDefaultBuilder(args)
                .ConfigureWebHostDefaults(webBuilder =>
                {
                    webBuilder.UseStartup<Startup>();
                })
                .UseSerilog();
    }
}
