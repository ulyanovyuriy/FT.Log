using System;

namespace FT.Log.Core
{
    public interface ILogMessage
    {
        string Body { get; }

        DateTime DateTime { get; }

        LogLevel Level { get; }

        string GetRaw();
    }
}
