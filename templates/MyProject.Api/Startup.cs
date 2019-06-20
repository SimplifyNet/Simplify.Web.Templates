using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using MyProject.Api.Setup;
using Simplify.DI;
using Simplify.DI.Provider.SimpleInjector;
using Simplify.Web.Json.ModelBinding.Binders;
using Simplify.Web.ModelBinding;
using Simplify.Web.Owin;

namespace MyProject.Api
{
	public class Startup
	{
		public void Configure(IApplicationBuilder app, IHostingEnvironment env)
		{
			InitializeContainer();

			if (env.IsDevelopment())
				app.UseDeveloperExceptionPage();

			// Enabling Simplify.Web JSON requests handling
			HttpModelHandler.RegisterModelBinder<JsonModelBinder>();

			app.UseSimplifyWeb();

			VerifyContainer();
		}

		private static void InitializeContainer()
		{
			DIContainer.Current = new SimpleInjectorDIProvider();

			IocRegistrations.Register();
		}

		private static void VerifyContainer()
		{
			// IOC container dependencies graph verification
			((SimpleInjectorDIProvider)DIContainer.Current).Container.Verify();
		}
	}
}