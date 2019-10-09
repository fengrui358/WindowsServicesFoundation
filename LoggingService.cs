using System;
using System.Collections.Generic;
using System.Text;
using NLog;
using Topshelf;

namespace WindowsServicesFoundation
{
    public class LoggingService : ServiceControl
    {
        private static readonly ILogger Logger = LogManager.GetCurrentClassLogger();

        public bool Start(HostControl hostControl)
        {
            try
            {
                Console.WriteLine(nameof(Start));
                Logger.Info(nameof(Start));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Logger.Error(e);
                return false;
            }

            return true;
        }

        public bool Stop(HostControl hostControl)
        {
            try
            {
                Console.WriteLine(nameof(Stop));
                Logger.Info(nameof(Stop));
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                Logger.Error(e);
                return false;
            }

            return true;
        }
    }
}
