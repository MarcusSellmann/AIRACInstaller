using System;

using Serilog;

using AIRACInstaller.Utils;

namespace AIRACInstaller.Core {
    public sealed class MainController {
        #region Singleton initialization
        private static readonly Lazy<MainController> _instance = new(() => new MainController());
        public static MainController Instance => _instance.Value;
        #endregion

        #region properties
        public Config Config { get; set; }
        #endregion

        private MainController() {
            Log.Logger = new LoggerConfiguration().MinimumLevel.Information().WriteTo.Console().CreateLogger();

            ConfigHandler configHandler = new ConfigHandler();
            Config = new Config("");
        }
    }
}
