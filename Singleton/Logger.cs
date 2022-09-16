using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public class Logger
    {
        private String fileName;
        private String logText;

        private static Dictionary<string, Logger>  loggers = new Dictionary<string, Logger>();   

        private Logger(String fileName)
        {
            this.fileName = fileName;
            logText = string.Empty;
        }

        public static Logger GetInstance(string fileName) 
        {
            if (loggers.ContainsKey(fileName)) 
            {
                return loggers[fileName];
            }

            var newLogger = new Logger(fileName);

            loggers.Add(fileName, newLogger);

            return newLogger;
        }


        public void write(String message)
        {
            logText += $" {message} {DateTime.Now.ToString()}";

            Console.WriteLine("log: " + logText);
        }
    }
}
