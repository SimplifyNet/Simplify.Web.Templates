using MyProject.Api.ViewModels;
using Simplify.DI;
using Simplify.Web.Json.ModelBinding.Binders;

namespace MyProject.Api.Setup
{
	public static class IocRegistrations
	{
		public static void Register()
		{
			// Simplify.DI.DIContainer.Current IOC container registrations starting point

			DIContainer.Current.Register<JsonModelBinder>(LifetimeType.Singleton);

			DIContainer.Current.Register<SampleModelFactory>();
		}
	}
}