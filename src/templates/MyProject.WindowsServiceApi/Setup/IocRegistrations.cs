using Microsoft.Extensions.Configuration;
using MyProject.WindowsServiceApi.Settings;
using Simplify.DI;
using Simplify.Web;

namespace MyProject.WindowsServiceApi.Setup;

public static class IocRegistrations
{
	public static IDIContainerProvider RegisterAll(this IDIContainerProvider provider)
	{
		provider.RegisterSimplifyWeb()

		.Register(r => new WebApplicationStartupSettings(r.Resolve<IConfiguration>()), LifetimeType.Singleton)
		.Register<WebApplicationStartup>(LifetimeType.Singleton);

		return provider;
	}
}