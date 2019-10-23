using MyProject.Api.ViewModels;
using Simplify.DI;
using Simplify.Web.Bootstrapper;
using Simplify.Web.Json;

namespace MyProject.Api.Setup
{
	public static class IocRegistrations
	{
		public static void Register()
		{
			// Simplify.DI.DIContainer.Current IOC container registrations starting point

			DIContainer.Current.RegisterSimplifyWeb()
				.RegisterJsonModelBinder();

			DIContainer.Current.Register<SampleModelFactory>();
		}
	}
}