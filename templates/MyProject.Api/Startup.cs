using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using MyProject.Api.Setup;
using Simplify.DI;
using Simplify.Web.Json.ModelBinding.Binders;
using Simplify.Web.ModelBinding;
using Simplify.Web.Owin;

namespace MyProject.Api
{
	public class Startup
	{
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			IocRegistrations.Register();

			if (env.IsDevelopment())
				app.UseDeveloperExceptionPage();

			// Enabling Simplify.Web JSON requests handling
			HttpModelHandler.RegisterModelBinder<JsonModelBinder>();

			app.UseSimplifyWeb();

			// IOC container dependencies graph verification
			DIContainer.Current.Verify();
		}
	}
}