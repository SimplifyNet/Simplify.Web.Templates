using MyProject.SchedulerApi.Setup;
using Simplify.DI;
using Simplify.Scheduler;

namespace MyProject.SchedulerApi
{
	internal class Program
	{
		private static void Main(string[] args)
		{
			InitializeContainer();

			using var handler = new BasicScheduler<WebApplicationStartup>(startupArgs: args);

			handler.Start(args);
		}

		private static void InitializeContainer() =>
			DIContainer.Current.RegisterAll()
				.Verify();
	}
}