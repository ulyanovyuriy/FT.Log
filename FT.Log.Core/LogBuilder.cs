using FT.Log.Core.Source;
using System;

namespace FT.Log.Core
{
    public sealed class LogBuilder
    {
        private ILogSource _source;

        private ILogWriter _writer;

        public ILogSource Source { get => _source; set => _source = value; }

        public ILogWriter Writer { get => _writer; set => _writer = value; }

        public LogBuilder UseSource(ILogSource source)
        {
            if (Source != null) throw new Exception();
            Source = source;
            return this;
        }

        public LogBuilder UseWcfSource() =>
            UseSource(new WcfLogSource());

        public LogBuilder UseServiceSource() =>
            UseSource(new ServiceLogSource());

        public LogBuilder UseSimpleSource(string source) =>
            UseSource(new SimpleLogSource(source));

        public LogBuilder UseSwitchSource(
            Func<SwitchLogSource, SwitchLogSource> init) =>
            UseSource(
                init?.Invoke(new SwitchLogSource())
                ?? new SwitchLogSource());

        public LogBuilder UseBodyConvert(Func<Object, string> func)
        {
            Message.Message.Convert = func;
            return this;
        }

        public LogBuilder UseWriter(ILogWriter writer)
        {
            if (Writer != null) throw new Exception();
            Writer = writer;
            return this;
        }
    }
}
