using System;

namespace FT.Log.Core
{
    public sealed class Message : ILogMessage
    {
        public static Func<object, string> Convert;

        public object Body { get; set; }

        string ILogMessage.Body =>
            Convert?.Invoke(Body) ?? Body?.ToString();

        public DateTime DateTime { get; set; }

        public LogLevel Level { get; set; }

        public string GetRaw() => $"{Level}({DateTime}): {((ILogMessage)this).Body}";

        public override string ToString() => GetRaw();
    }
}
