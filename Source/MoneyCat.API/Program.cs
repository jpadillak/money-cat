using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Logging;

namespace MoneyCat.API
{
	public class Program
	{
		public static void Main(string[] args)
		{
			IWebHost webHost = CreateWebHostBuilder(args).ConfigureLogging((logginBuilder) =>
			{
				logginBuilder.ClearProviders();
				logginBuilder.AddDebug();
				logginBuilder.AddConsole();
			}).Build();
			webHost.Run();
		}

		public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
			WebHost.CreateDefaultBuilder(args)
				.UseStartup<Startup>();
	}
}