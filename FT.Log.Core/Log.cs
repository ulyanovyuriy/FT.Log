using System;

namespace FT.Log.Core
{
    public static class Log
    {
        private static ILogSource Source { get; }

        public static ILogWriter Writer { get; }

        public static void Init(Func<LogBuilder, LogBuilder> init)
        {
            var builder = new LogBuilder();
            builder = init?.Invoke(builder);
        }

        public static void Write(ILogMessage message) =>
            Writer?.Write(Source, message);
    }
}
