using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Server.Kestrel.Core;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using MyProject.Api.Setup;
using Simplify.DI;
using Simplify.Web;
using Simplify.Web.Json.ModelBinding.Binders;
using Simplify.Web.Model;

namespace MyProject.Api
{
	public class Startup
	{
		public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
		{
			if (env.IsDevelopment())
				app.UseDeveloperExceptionPage();

			// Enabling Simplify.Web JSON requests handling
			HttpModelHandler.RegisterModelBinder<JsonModelBinder>();

			app.UseSimplifyWebWithoutRegistrations();
		}

		public void ConfigureServices(IServiceCollection services)
		{
			InitializeContainer();

			services.Configure<KestrelServerOptions>(options => { options.AllowSynchronousIO = true; });
			services.Configure<IISServerOptions>(options => { options.AllowSynchronousIO = true; });
		}

		private static void InitializeContainer()
		{
			IocRegistrations.Register();

			// IOC container dependencies graph verification
			DIContainer.Current.Verify();
		}
	}
}