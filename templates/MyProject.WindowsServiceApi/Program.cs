using System;
using MyProject.WindowsServiceApi.Setup;
using Simplify.DI;
using Simplify.WindowsServices;
using Simplify.WindowsServices.Jobs;

namespace MyProject.WindowsServiceApi
{
	internal class Program
	{
		private static void Main(string[] args)
		{
#if DEBUG
			System.Diagnostics.Debugger.Launch();
#endif

			InitializeContainer();

			using var handler = new BasicServiceHandler<WebApplicationStartup>(startupArgs: args);

			if (!handler.Start(args))
				RunAsConsoleApplication(args);
		}

		private static void RunAsConsoleApplication(string[] args)
		{
			using var scope = DIContainer.Current.BeginLifetimeScope();

			scope.Resolver.Resolve<WebApplicationStartup>().Run(new JobArgs("Development", args));

			Console.ReadLine();
		}

		private static void InitializeContainer() =>
			DIContainer.Current
				.RegisterAll()
				.Verify();
	}
}