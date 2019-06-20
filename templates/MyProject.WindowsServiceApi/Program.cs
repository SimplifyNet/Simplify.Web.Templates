using System;
using MyProject.WindowsServiceApi.Setup;
using Simplify.DI;
using Simplify.DI.Provider.SimpleInjector;
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

			if (new BasicServiceHandler<WebApplicationStartup>().Start(args))
				return;

			using (var scope = DIContainer.Current.BeginLifetimeScope())
				scope.Resolver.Resolve<WebApplicationStartup>().Run();

			Console.ReadLine();
		}

		private static void InitializeContainer()
		{
			DIContainer.Current = new SimpleInjectorDIProvider();

			IocRegistrations.Register();

			// IOC container dependencies graph verification
			((SimpleInjectorDIProvider)DIContainer.Current).Container.Verify();
		}
	}
}