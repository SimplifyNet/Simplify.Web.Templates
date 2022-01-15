using Microsoft.Extensions.Configuration;

namespace MyProject.WindowsServiceApi.Settings;

public class WebApplicationStartupSettings
{
	public WebApplicationStartupSettings(IConfiguration configuration, string configurationSectionName = "WebApplicationStartupSettings")
	{
		var config = configuration.GetSection(configurationSectionName);

		if (!config.GetChildren().Any())
			return;

		var bindHostName = config[nameof(BindHostName)];

		if (!string.IsNullOrEmpty(bindHostName))
			BindHostName = bindHostName;

		var workingPort = config[nameof(WorkingPort)];

		if (string.IsNullOrEmpty(workingPort))
			return;

		if (int.TryParse(workingPort, out var buffer))
			WorkingPort = buffer;
	}

	public string BindHostName { get; set; } = "*";
	public int WorkingPort { get; set; } = 5000;
}
