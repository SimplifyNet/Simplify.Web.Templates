using Microsoft.Extensions.Configuration;
using System.Linq;

namespace MyProject.WindowsServiceApi.Settings
{
	public class StatusServiceSettings
	{
		public StatusServiceSettings(IConfiguration configuration, string configurationSectionName = "StatusServiceSettings")
		{
			var config = configuration.GetSection(configurationSectionName);

			if (!config.GetChildren().Any())
				return;

			var bindHostName = config["BindHostName"];

			if (!string.IsNullOrEmpty(bindHostName))
				BindHostName = bindHostName;

			var workingPort = config["WorkingPort"];

			if (string.IsNullOrEmpty(workingPort)) return;
			if (int.TryParse(workingPort, out var buffer))
				WorkingPort = buffer;
		}

		public string BindHostName { get; set; } = "*";
		public int WorkingPort { get; set; } = 8080;
	}
}