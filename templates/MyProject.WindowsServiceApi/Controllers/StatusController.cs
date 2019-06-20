using Simplify.Web;
using Simplify.Web.Attributes;
using Simplify.Web.Responses;

namespace MyProject.WindowsServiceApi.Controllers
{
	[Get("status")]
	public class StatusController : Controller
	{
		public override ControllerResponse Invoke()
		{
			return new Ajax("Service is running!");
		}
	}
}