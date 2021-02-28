using MyProject.Api.ViewModels;
using Simplify.DI;
using Simplify.Web.Bootstrapper;
using Simplify.Web.Json;

namespace MyProject.Api.Setup
{
	public static class IocRegistrations
	{
		public static IDIContainerProvider RegisterAll(this IDIContainerProvider provider)
		{
			// Simplify.DI.DIContainer.Current IOC container registrations starting point

			provider.RegisterSimplifyWeb()
				.RegisterJsonModelBinder()

			.Register<SampleModelFactory>();

			return provider;
		}
	}
}