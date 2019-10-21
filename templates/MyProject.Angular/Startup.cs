using System;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.Extensions.DependencyInjection;
using MyProject.Angular.Setup;
using Simplify.DI;
using Simplify.DI.Provider.Microsoft.Extensions.DependencyInjection;
using Simplify.Web;

namespace MyProject.Angular
{
	public class Startup
	{
		public IServiceProvider ConfigureServices(IServiceCollection services)
		{
			var provider = new MicrosoftDependencyInjectionDIProvider { Services = services };
			DIContainer.Current = provider;

			// Your registrations here (both via services or DIContainer.Current.Register)

			// In production, the Angular files will be served from this directory
			services.AddSpaStaticFiles(configuration =>
			{
				configuration.RootPath = "ClientApp/dist";
			});

			IocRegistrations.Register();

			return provider.ServiceProvider;
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			if (env.IsDevelopment())
				app.UseDeveloperExceptionPage();

			app.UseSpaStaticFiles();

			app.UseSimplifyWebNonTerminalWithoutRegistrations();

			app.UseSpa(spa =>
			{
				spa.Options.SourcePath = "ClientApp";

				if (env.IsDevelopment())
					spa.UseAngularCliServer("start");
			});
		}
	}
}