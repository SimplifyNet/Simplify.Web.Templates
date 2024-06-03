using Simplify.Web;
using Simplify.Web.Attributes;

namespace MyProject.SchedulerApi.Controllers;

[Get("status")]
public class StatusController : Controller2
{
	public ControllerResponse Invoke() => Content("Service is running!");
}