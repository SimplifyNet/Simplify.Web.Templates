using MyProject.Api.Setup;
using Simplify.DI;
using Simplify.Web;
using Simplify.Web.Json.Model.Binding;
using Simplify.Web.Model;

var builder = WebApplication.CreateBuilder(args);

DIContainer.Current
	.RegisterAll()
	.Verify();

var app = builder.Build();

if (app.Environment.IsDevelopment())
	app.UseDeveloperExceptionPage();

// Enabling Simplify.Web JSON requests handling
HttpModelHandler.RegisterModelBinder<JsonModelBinder>();

app.UseSimplifyWebWithoutRegistrations();

app.Run();
