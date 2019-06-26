using System;

namespace Logger {
    public class ConsoleLogger : BaseLogger {
        internal ConsoleLogger() {

        }

        public override void LogError(string message) {
            Console.WriteLine("ConsoleLogger.LogError(" + message + ")");
        }

        public override void LogInfo(string message) {
            Console.WriteLine("ConsoleLogger.LogInfo(" + message + ")");
        }
    }
}
