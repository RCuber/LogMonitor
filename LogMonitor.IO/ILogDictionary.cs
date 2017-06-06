using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogMonitor.IO
{
    interface ILogDictionary
    {
        Dictionary<string, string> GetDictionary();
    }
}
