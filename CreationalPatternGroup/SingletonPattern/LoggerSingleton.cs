using System;

namespace DesignPatternsCSharp.SingletonPattern
{
    public class LoggerSingleton
    {
        private static LoggerSingleton Instance;
        private static readonly object padlock = new object();
        private string Text;
        private int LineNumber;
        private LoggerSingleton()
        {
            Text = "";
            LineNumber = 0;
        }

        public static LoggerSingleton getInstance()
        {
            // creating thread safe instance
            if (Instance == null)
            {
                lock (padlock)
                {
                    if (Instance == null)
                    {
                        Instance = new LoggerSingleton();
                    }
                }

            }
            return Instance;
        }

        public void Write(string text)
        {
            lock (Text)
            {
                Text += $"{LineNumber}. {text}\n";
                LineNumber++;
            }
        }

        public void Log()
        {
            Console.WriteLine(Text);
        }
    }
}