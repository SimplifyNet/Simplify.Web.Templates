using Microsoft.Extensions.Configuration;
using MyProject.WindowsServiceApi.Settings;
using Simplify.DI;
using Simplify.Web.Bootstrapper;
using Simplify.Web.Json;

namespace MyProject.WindowsServiceApi.Setup
{
	public class IocRegistrations
	{
		public static void Register()
		{
			DIContainer.Current.RegisterSimplifyWeb()
				.RegisterJsonModelBinder();

			DIContainer.Current.Register(r => new StatusServiceSettings(r.Resolve<IConfiguration>()), LifetimeType.Singleton);
			DIContainer.Current.Register<WebApplicationStartup>(LifetimeType.Singleton);
		}
	}
}