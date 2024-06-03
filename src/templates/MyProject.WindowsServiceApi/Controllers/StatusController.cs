using Simplify.Web;
using Simplify.Web.Attributes;

namespace MyProject.WindowsServiceApi.Controllers;

[Get("status")]
public class StatusController : Controller2
{
	public ControllerResponse Invoke() => Content("Service is running!");
}