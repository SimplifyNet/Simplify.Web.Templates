using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.SpaServices.AngularCli;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyProject.Angular.Setup;
using Simplify.DI;
using Simplify.DI.Provider.Microsoft.Extensions.DependencyInjection;
using Simplify.Web;

namespace MyProject.Angular
{
	public class Startup
	{
		public void ConfigureServices(IServiceCollection services)
		{
			DIContainer.Current = new MicrosoftDependencyInjectionDIProvider { Services = services };

			DIContainer.Current.RegisterAll();

			// In production, the Angular files will be served from this directory
			services.AddSpaStaticFiles(configuration =>
			{
				configuration.RootPath = "ClientApp/dist";
			});
		}

		// This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
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