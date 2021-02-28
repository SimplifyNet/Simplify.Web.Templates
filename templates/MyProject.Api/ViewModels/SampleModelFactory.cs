namespace MyProject.Api.ViewModels
{
	public class SampleModelFactory
	{
		public SampleModel Create(string message) =>
			new SampleModel
			{
				Message = message
			};
	}
}