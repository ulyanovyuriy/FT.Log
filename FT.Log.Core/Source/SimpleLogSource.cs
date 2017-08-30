using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FT.Log.Core.Source
{
    public class SimpleLogSource : ILogSource
    {
        public SimpleLogSource(string source)
        {
            Source = source;
        }

        public string Source { get; }

        public string GetSource() => Source;
    }
}
