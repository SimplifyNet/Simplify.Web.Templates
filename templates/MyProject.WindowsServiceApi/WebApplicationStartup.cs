using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using MyProject.WindowsServiceApi.Settings;

namespace MyProject.WindowsServiceApi
{
	public class WebApplicationStartup
	{
		private readonly StatusServiceSettings _settings;

		public WebApplicationStartup(StatusServiceSettings settings)
		{
			_settings = settings;
		}

		public static IWebHostBuilder CreateWebHostBuilder(string[] args) =>
			WebHost.CreateDefaultBuilder(args)
				.UseStartup<Startup>();

		public void Run()
		{
			CreateWebHostBuilder(Program.Args)
				.UseUrls($"http://{_settings.BindHostName}:{_settings.WorkingPort}")
				.Build()
				.Start();
		}
	}
}