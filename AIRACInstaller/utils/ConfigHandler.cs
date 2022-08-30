using System.IO;

using Serilog;
using Newtonsoft.Json;

namespace AIRACInstaller.Utils {
	public class ConfigHandler {
		private static readonly string DEFAULT_CONFIG_PATH = "./";
		
		public ConfigHandler() {
			var cwd = Directory.GetCurrentDirectory();
			var test = Path.Combine(cwd, DEFAULT_CONFIG_PATH).ToString();

			Log.Information("Try to read configuration file from: {file}", test);
		}
	}
}