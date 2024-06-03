using MyProject.Api.Setup;
using Simplify.DI;
using Simplify.Web;

var builder = WebApplication.CreateBuilder(args);

DIContainer.Current
	.RegisterAll()
	.Verify();

var app = builder.Build();

if (app.Environment.IsDevelopment())
	app.UseDeveloperExceptionPage();

app.UseSimplifyWeb();

await app.RunAsync();