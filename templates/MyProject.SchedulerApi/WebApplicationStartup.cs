using MyProject.SchedulerApi.Settings;
using Simplify.Scheduler.Jobs;
using Simplify.Web;
using Simplify.Web.Json.Model.Binding;
using Simplify.Web.Model;

namespace MyProject.SchedulerApi;

public class WebApplicationStartup
{
	private readonly WebApplicationStartupSettings _settings;

	public WebApplicationStartup(WebApplicationStartupSettings settings) => _settings = settings;

	public void Run(IJobArgs args)
	{
		var builder = WebApplication.CreateBuilder((string[])args.StartupArgs!);

		builder.WebHost.UseUrls($"http://{_settings.BindHostName}:{_settings.WorkingPort}");

		var app = builder.Build();

		if (app.Environment.IsDevelopment())
			app.UseDeveloperExceptionPage();

		// Enabling Simplify.Web JSON requests handling
		HttpModelHandler.RegisterModelBinder<JsonModelBinder>();

		app.UseSimplifyWebWithoutRegistrations();

		app.Run();
	}
}
