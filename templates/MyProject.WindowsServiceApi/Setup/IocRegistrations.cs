﻿using Microsoft.Extensions.Configuration;
using MyProject.WindowsServiceApi.Settings;
using Simplify.DI;
using Simplify.Web.Bootstrapper;
using Simplify.Web.Json;

namespace MyProject.WindowsServiceApi.Setup
{
	public static class IocRegistrations
	{
		public static IDIContainerProvider RegisterAll(this IDIContainerProvider provider)
		{
			provider.RegisterSimplifyWeb()
				.RegisterJsonModelBinder()

			.Register(r => new StatusServiceSettings(r.Resolve<IConfiguration>()), LifetimeType.Singleton)
			.Register<WebApplicationStartup>(LifetimeType.Singleton);

			return provider;
		}
	}
}