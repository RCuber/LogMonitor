using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogMonitor.IO
{
    public class LogReader
    {
        private readonly FileStream _logFileStream;
        private readonly StreamReader _logReader;
        
        public LogReader(string fileName, long startPosition = 0)
        {
                _logFileStream = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite);
                _logReader = new StreamReader(_logFileStream);
                _logFileStream.Position = startPosition;
        }

        public long CurrentOffset
        {
            get { return _logFileStream.Position; }
        }

        public string GetAddedLines()
        {
            return _logReader.ReadToEnd();
        }

        public static string GetLatestFile(string path)
        {
            var directory = new DirectoryInfo(path);

            var latestFile = directory.GetFiles()
                         .OrderByDescending(f => f.LastWriteTime)
                         .First();
            return latestFile.FullName;
        }
    }
}
