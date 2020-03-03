using System;
using System.IO;
using DigitTranslater.Logger.Interfaces;

namespace DigitTranslater.Logger.Implements
{
    public class FileLogger : ILogger
    {
        private readonly string _filePath;

        public FileLogger(string filePath)
        {
            _filePath = filePath;
        }

        public void LogInformation(string message)
        {
            File.AppendAllText(_filePath, $"{DateTime.UtcNow.ToString("yyyyMMdd HH:mm:ss")} {message}\r\n");
        }
    }
}