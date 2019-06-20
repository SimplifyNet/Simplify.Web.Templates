using MyProject.Api.ViewModels;
using Simplify.DI;

namespace MyProject.Api.Setup
{
	public static class IocRegistrations
	{
		public static void Register()
		{
			// Simplify.DI.DIContainer.Current IOC container registrations starting point

			DIContainer.Current.Register<SampleModelFactory>();
		}
	}
}