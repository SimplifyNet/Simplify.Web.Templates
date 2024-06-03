using MyProject.Api.ViewModels;
using Simplify.DI;
using Simplify.Web;

namespace MyProject.Api.Setup;

public static class IocRegistrations
{
	public static IDIContainerProvider RegisterAll(this IDIContainerProvider provider)
	{
		// Simplify.DI.DIContainer.Current IOC container registrations starting point

		provider.RegisterSimplifyWeb()

		.Register<SampleModelFactory>();

		return provider;
	}
}