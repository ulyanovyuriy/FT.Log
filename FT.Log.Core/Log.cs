using System;

namespace FT.Log.Core
{
    public static class Log
    {
        private static ILogSource Source { get; set; }

        private static ILogWriter Writer { get; set; }

        public static void Init(Func<LogBuilder, LogBuilder> init)
        {
            var builder = new LogBuilder();
            builder = init?.Invoke(builder);
            Source = builder.Source;
            Writer = builder.Writer;
        }

        public static void Write(ILogMessage message) =>
            Writer?.Write(Source, message);
    }
}
