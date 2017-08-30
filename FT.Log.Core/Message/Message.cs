using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FT.Log.Core.Message
{
    public sealed class Message : ILogMessage
    {
        public static Func<object, string> Convert;

        public object Body { get; set; }

        public DateTime DateTime { get; set; }

        string ILogMessage.Message =>
            Convert?.Invoke(Body) ?? Body?.ToString();

        public string GetRaw() => ToString();

        public override string ToString()
        {
            return new
            {
                DateTime = DateTime,
                Text = GetRaw(),
            }.ToString();
        }
    }
}
