using MyProject.SchedulerApi.Settings;
using Simplify.Scheduler.Jobs;
using Simplify.Web;

namespace MyProject.SchedulerApi;

public class WebApplicationStartup(WebApplicationStartupSettings settings)
{
	public async Task Run(IJobArgs args)
	{
		var builder = WebApplication.CreateBuilder((string[])args.StartupArgs!);

		builder.WebHost.UseUrls($"http://{settings.BindHostName}:{settings.WorkingPort}");

		var app = builder.Build();

		if (app.Environment.IsDevelopment())
			app.UseDeveloperExceptionPage();

		app.UseSimplifyWeb();

		await app.RunAsync();
	}
}