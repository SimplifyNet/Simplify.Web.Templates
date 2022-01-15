using MyProject.SchedulerApi;
using MyProject.SchedulerApi.Setup;
using Simplify.DI;
using Simplify.Scheduler;

DIContainer.Current
	.RegisterAll()
	.Verify();

using var handler = new BasicScheduler<WebApplicationStartup>(startupArgs: args);

handler.Start(args);
