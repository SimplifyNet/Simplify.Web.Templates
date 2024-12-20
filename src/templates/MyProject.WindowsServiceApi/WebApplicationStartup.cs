﻿using Microsoft.AspNetCore;
using Microsoft.AspNetCore.Hosting;
using MyProject.WindowsServiceApi.Settings;
using Simplify.WindowsServices.Jobs;

namespace MyProject.WindowsServiceApi;

public class WebApplicationStartup(WebApplicationStartupSettings settings)
{
	private readonly WebApplicationStartupSettings _settings = settings;

	public void Run(IJobArgs args) =>
		WebHost.CreateDefaultBuilder(((string[])args.StartupArgs)!)
			.UseKestrel(options => { options.Limits.MinRequestBodyDataRate = null; })
			.UseStartup<Startup>()
			.UseUrls($"http://{_settings.BindHostName}:{_settings.WorkingPort}")
			.Build()
			.Start();
}
