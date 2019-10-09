using System;
using Topshelf;

namespace WindowsServicesFoundation
{
    /// <summary>
    /// 参考
    /// https://www.cnblogs.com/lwqlun/p/11625789.html
    /// https://topshelf.readthedocs.io/en/latest/
    /// </summary>
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
