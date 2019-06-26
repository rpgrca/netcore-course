using System;

namespace Logger {
    public abstract class BaseLogger : ILogger {
        public abstract void LogError(string message);
        public abstract void LogInfo(string message);
    }
}
