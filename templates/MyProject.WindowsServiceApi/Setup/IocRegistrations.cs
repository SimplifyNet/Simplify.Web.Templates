using Microsoft.Extensions.Configuration;
using MyProject.WindowsServiceApi.Settings;
using Simplify.DI;

namespace MyProject.WindowsServiceApi.Setup
{
	public class IocRegistrations
	{
		public static void Register()
		{
			SimplifyWebRegistrations.Register();

			DIContainer.Current.Register(r => new StatusServiceSettings(r.Resolve<IConfiguration>()), LifetimeType.Singleton);
			DIContainer.Current.Register<WebApplicationStartup>(LifetimeType.Singleton);
		}
	}
}