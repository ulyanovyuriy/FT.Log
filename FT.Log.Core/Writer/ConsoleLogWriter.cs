using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FT.Log.Core.Writer
{
    public class ConsoleLogWriter : ILogWriter
    {
        public void Write(ILogSource source, ILogMessage message)
        {
            Console.WriteLine($"{source?.GetSource()}: {message?.GetRaw()}");
        }
    }
}
