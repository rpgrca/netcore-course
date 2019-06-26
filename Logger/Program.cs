using System;
using Logger;

namespace Logger
{
    class Program
    {
        static void Main(string[] args)
        {
            ILogger logger = null;

            foreach (LoggerType loggerType in Enum.GetValues(typeof(LoggerType))) {
                logger = LoggerFactory.Create(loggerType);
                logger.LogInfo("Este es un mensaje de informacion");
                logger.LogError("Este es un mensaje de error");
            }
        }
    }
}
