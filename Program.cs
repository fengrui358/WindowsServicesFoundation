using System;
using Topshelf;

namespace WindowsServicesFoundation
{
    class Program
    {
        static void Main(string[] args)
        {
            HostFactory.Run(s =>
                {
                    s.Service<LoggingService>();
                    s.EnableServiceRecovery(r => r.RestartService(TimeSpan.FromSeconds(10)));
                    s.SetServiceName("TestService");
                    s.StartAutomatically();
                }
            );
        }
    }
}
