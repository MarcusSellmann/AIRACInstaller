namespace AIRACInstaller.Core {
    public class Config {
        public string AIRACFilePath {
            get; set;
        }

        public Config(string airacFilePath) {
            AIRACFilePath = airacFilePath;
        }
    }
}