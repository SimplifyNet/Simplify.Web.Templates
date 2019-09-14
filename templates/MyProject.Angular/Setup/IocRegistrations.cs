using Simplify.Web.Bootstrapper;

namespace MyProject.Angular.Setup
{
	public static class IocRegistrations
	{
		public static void Register()
		{
			// Simplify.DI.DIContainer.Current IOC container registrations starting point

			// Manual Simplify.Web internal types registrations
			BootstrapperFactory.CreateBootstrapper().Register();
		}
	}
}