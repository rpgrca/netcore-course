using System;

namespace Logger {
    public class WindowLogger : BaseLogger {
        internal WindowLogger() {
        }

        public override void LogError(string message) {
            Console.WriteLine("WindowLogger.LogError(" + message + ")");
        }

        public override void LogInfo(string message) {
            Console.WriteLine("WindowLogger.LogInfo(" + message + ")");
        }
    }
}
