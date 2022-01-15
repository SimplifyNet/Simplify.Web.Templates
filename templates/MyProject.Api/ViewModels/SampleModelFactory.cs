namespace MyProject.Api.ViewModels;

public class SampleModelFactory
{
	public SampleModel Create(string message) =>
		new()
		{
			Message = message
		};
}
