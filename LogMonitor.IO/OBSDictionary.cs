using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogMonitor.IO
{
    public class OBSDictionary //: ILogDictionary
    {
        public static Dictionary<string, string> GetDictionary()
        {
            //Phrase, Custom Message
            var dictionary = new Dictionary<string, string> {
                { "Recording Start", "Recording Start" },
                { "Recording Stop", "Recording Start" },
                { "Replay Buffer Start", "Replay Buffer Start"},
                { "Replay Buffer Stop", "Replay Buffer Stop"},
                { "Streaming Start", "Streaming Start" },
                { "Streaming Stop" , "Streaming Stop" }
            };

            return dictionary;
        }
    }
}
