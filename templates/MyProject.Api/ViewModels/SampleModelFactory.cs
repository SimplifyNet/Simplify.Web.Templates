namespace MyProject.Api.ViewModels
{
	public class SampleModelFactory
	{
		public SampleModel Create(string message)
		{
			return new SampleModel
			{
				Message = message
			};
		}
	}
}