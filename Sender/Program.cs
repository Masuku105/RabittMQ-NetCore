using Microsoft.Extensions.DependencyInjection;
using Sender.Interfaces;
using System;

namespace Sender
{
    class Program
    {
        static void Main(string[] args)
        {
            var container = StartUp.ConfigurServices();
            var sender = container.GetRequiredService<IMessageHandler>();
            sender.Send();
            Console.WriteLine(" Press [enter] to exit.");
            Console.ReadLine();
        }
    }
}
