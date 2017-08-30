using System;

namespace FT.Log.Core
{
    public interface ILogMessage
    {
        string Message { get; }

        DateTime DateTime { get; }

        string GetRaw();
    }
}
