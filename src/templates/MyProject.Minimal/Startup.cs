using Simplify.Web;

var app = WebApplication.CreateBuilder(args)
	.Build();

app.UseSimplifyWeb(true);

await app.RunAsync();