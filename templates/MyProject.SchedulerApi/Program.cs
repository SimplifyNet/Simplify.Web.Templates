using MyProject.SchedulerApi;
using MyProject.SchedulerApi.Setup;
using Simplify.DI;
using Simplify.Scheduler;
using Simplify.Web;
using Simplify.Web.Json.Model.Binding;
using Simplify.Web.Model;

DIContainer.Current
	.RegisterAll()
	.Verify();

using var handler = new BasicScheduler<WebApplicationStartup>(startupArgs: args);

handler.Start(args);
