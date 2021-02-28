using Simplify.DI;
using Simplify.Web.Bootstrapper;

namespace MyProject.Angular.Setup
{
	public static class IocRegistrations
	{
		public static IDIContainerProvider RegisterAll(this IDIContainerProvider provider)
		{
			// Simplify.DI.DIContainer.Current IOC container registrations starting point

			// Manual Simplify.Web internal types registrations
			provider.RegisterSimplifyWeb();

			return provider;
		}
	}
}