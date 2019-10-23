using System;
using MyProject.WindowsServiceApi.Setup;
using Simplify.DI;
using Simplify.WindowsServices;

namespace MyProject.WindowsServiceApi
{
	internal class Program
	{
		public static string[] Args { get; private set; }

		private static void Main(string[] args)
		{
#if DEBUG
			System.Diagnostics.Debugger.Launch();
#endif

			Args = args;

			InitializeContainer();

			using var handler = new BasicServiceHandler<WebApplicationStartup>();

			if (!handler.Start(args))
				RunAsConsoleApplication();
		}

		private static void RunAsConsoleApplication()
		{
			using var scope = DIContainer.Current.BeginLifetimeScope();

			scope.Resolver.Resolve<WebApplicationStartup>().Run();

			Console.ReadLine();
		}

		private static void InitializeContainer()
		{
			IocRegistrations.Register();

			// IOC container dependencies graph verification
			DIContainer.Current.Verify();
		}
	}
}