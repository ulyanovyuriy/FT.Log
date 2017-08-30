using FT.Log.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace App
{
    class Program
    {
        static void Main(string[] args)
        {
            Log.Init(builder =>
                builder
                .UseSimpleSource("Test")
                .UseConsole()
                .UseBodyConvert(body =>
                    body?.ToString())
            );

            Log.Write(new Message()
            {
                Body = "Hello",
                DateTime = DateTime.Now
            });

            Console.ReadKey();
        }
    }
}
