using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.Extensions.Hosting;
using Simplify.Web;
using Simplify.Web.Json.Model.Binding;
using Simplify.Web.Model;

namespace MyProject.SchedulerApi
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
	}
}