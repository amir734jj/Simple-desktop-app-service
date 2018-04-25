using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using Simple_desktop_service;

namespace Simple_desktop_service
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        static void Main()
        {
#if DEBUG
            var debugService = new SimpleService();
            debugService.OnDebug();
            System.Threading.Thread.Sleep(System.Threading.Timeout.Infinite);
#else
            var servicesToRun = new ServiceBase[]
            {
                new SimpleService()
            };
            ServiceBase.Run(servicesToRun);
#endif
        }
    }
}
