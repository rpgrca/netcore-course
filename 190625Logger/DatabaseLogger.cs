using System;

namespace Logger {
    public class DatabaseLogger : BaseLogger {
        internal DatabaseLogger()  : base() {
        }

        public override void LogError(string message) {
            Console.WriteLine("DatabaseLogger.LogError(" + message + ")");
        }

        public override void LogInfo(string message) {
            Console.WriteLine("DatabaseLogger.LogInfo(" + message + ")");
        }
    }
}
