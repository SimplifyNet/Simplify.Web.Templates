using System;
using System.Diagnostics;
using System.Threading.Tasks;
using MyProject.Api.ViewModels;
using Simplify.Web;
using Simplify.Web.Attributes;

namespace MyProject.Api.Controllers.Api.v1
{
	[Post("/api/v1/sampleIn")]
	public class SampleInController : AsyncController<SampleModel>
	{
		public override async Task<ControllerResponse> Invoke()
		{
			try
			{
				await ReadModelAsync();

				Trace.WriteLine($"Object with message received: {Model.Message}");

				return NoContent();
			}
			catch (Exception e)
			{
				return StatusCode(500, e.Message);
			}
		}
	}
}