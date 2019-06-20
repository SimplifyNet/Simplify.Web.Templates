using Simplify.Web.Bootstrapper;

namespace MyProject.WindowsServiceApi.Setup
{
	public class SimplifyWebRegistrations
	{
		public static void Register()
		{
			BootstrapperFactory.CreateBootstrapper().Register();
		}
	}
}