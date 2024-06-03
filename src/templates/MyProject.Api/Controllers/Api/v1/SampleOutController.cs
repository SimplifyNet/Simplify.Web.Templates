using MyProject.Api.ViewModels;
using Simplify.Web;
using Simplify.Web.Attributes;

namespace MyProject.Api.Controllers.Api.v1;

[Get("/api/v1/sampleOut")]
public class SampleOutController(SampleModelFactory modelFactory) : Controller2
{
	public ControllerResponse Invoke()
	{
		try
		{
			return Json(modelFactory.Create("Hello from Simplify.Web API example application"));
		}
		catch (Exception e)
		{
			return StatusCode(500, e.Message);
		}
	}
}