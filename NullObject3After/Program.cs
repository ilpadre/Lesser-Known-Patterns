using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullObjectBefore
{
    public class Program
    {
        static void Main(string[] args)
        {
            var loggingService = LoggingServiceFactory();
            loggingService.LogAMessage("Do something.");
            loggingService.LogAMessage("Do something else.");

            Console.ReadLine();
        }

        static LoggingService LoggingServiceFactory()
        {
            var loggingDevice = ConfigurationManager.AppSettings["LoggingDevice"];
            switch (loggingDevice)
            {
                case "console":
                    return new LoggingService(new ConsoleLog());
                    break;
                case "file":
                    return new LoggingService(new FileLog("MyFile"));
                    break;
                default:
                    return new LoggingService();
                    break;
            }

        }
    }

    public class LoggingService
    {
        private Log log;

        public LoggingService() :
            this(Log.NULL)
        {
        }
        public LoggingService(Log log)
        {
            this.log = log;
            // other initialization
        }
        public void LogAMessage(string request)
        {
            log.write("Request " + request + " received");

            // ...

            log.write("Request " + request + " handled");
        }
    }

    public abstract class Log
    {
        public static readonly Log NULL = new NullLog();
        public abstract void write(String messageToLog);

        private class NullLog : Log
        {
            public override void write(String messageToLog)
            {
            }
        }
    }

    public class ConsoleLog : Log
    {
        public override void write(String messageToLog)
        {
            System.Console.WriteLine(messageToLog);
        }
    }

    public class FileLog : Log
    {
        private StreamWriter sw;

        public FileLog(String logFileName)
        {
            try
            {
                sw = new StreamWriter(logFileName, true);
            }
            catch (IOException caught)
            {
                throw new Exception("Failed to open log file: " + caught);
            }
        }
        public override void write(String messageToLog)
        {
            try
            {
                sw.Write("[" + DateTime.Today.ToLongDateString() + "] " + messageToLog + "\n");
                sw.Flush();
            }
            catch (IOException caught)
            {
                throw new Exception("Failed to write to log: " + caught);
            }
        }
    }


}
