
using Kpo4381_nmv.Lib;
using Kpo4381_nmv.Utility;

namespace Kpo4381_nmv.Lib
{
    public static class AppGlobalSetting
    {
        private static string _logPath;
        private static string _dataFileName;
        public static string logPath { get { return _logPath; } }
        public static string dataFileName { get { return _dataFileName; } }

        public static void Initialize()
        {
            AppConfigUtility conf = new AppConfigUtility();
            _logPath = conf.AppSettings("logPath");
            _dataFileName = conf.AppSettings("dataFileName");
        }
    }
}