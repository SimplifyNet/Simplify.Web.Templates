using MyProject.Api.ViewModels;
using Simplify.Web;
using Simplify.Web.Attributes;
using Simplify.Web.Json.Responses;

namespace MyProject.Api.Controllers.Api.v1;

[Get("/api/v1/sampleOut")]
public class SampleOutController : Controller
{
	private readonly SampleModelFactory _modelFactory;

	public SampleOutController(SampleModelFactory modelFactory)
	{
		_modelFactory = modelFactory;
	}

	public override ControllerResponse Invoke()
	{
		try
		{
			return new Json(_modelFactory.Create("Hello from Simplify.Web API example application"));
		}
		catch (Exception e)
		{
			return StatusCode(500, e.Message);
		}
	}
}
