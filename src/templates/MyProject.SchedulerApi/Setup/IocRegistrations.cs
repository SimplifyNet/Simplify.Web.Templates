using MyProject.SchedulerApi.Settings;
using Simplify.DI;
using Simplify.Web;
using Simplify.Web.Json;

namespace MyProject.SchedulerApi.Setup;

public static class IocRegistrations
{
	public static IDIContainerProvider RegisterAll(this IDIContainerProvider provider)
	{
		provider.RegisterSimplifyWeb()
			.RegisterJsonModelBinder()

		.Register(r => new WebApplicationStartupSettings(r.Resolve<IConfiguration>()), LifetimeType.Singleton)
		.Register<WebApplicationStartup>(LifetimeType.Singleton);

		return provider;
	}
}
