using System;

namespace Logger {
    public enum LoggerType {
        Console = 0,
        Database = 1,
        Window = 2
    }
    public static class LoggerFactory {
        public static ILogger Create(LoggerType loggerType) {
            ILogger logger = null;

            switch (loggerType) {
                case LoggerType.Console:
                    logger = new ConsoleLogger();
                    break;

                case LoggerType.Database:
                    logger = new DatabaseLogger();
                    break;

                case LoggerType.Window:
                    logger = new WindowLogger();
                    break;
            }

            return logger;
        }
    }
}