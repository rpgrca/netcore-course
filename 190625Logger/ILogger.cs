using System;

namespace Logger {
    public interface ILogger {
        void LogError(string message);
        void LogInfo(string message);
    }
}
