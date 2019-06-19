using Simplify.Web;
using Simplify.Web.Attributes;

namespace MyProject.Minimal.Controllers
{
	[Get("/")]
	public class DefaultController : Controller
	{
		public override ControllerResponse Invoke()
		{
			return Ajax("Hello from Simplify.Web minimal application!");
		}
	}
}