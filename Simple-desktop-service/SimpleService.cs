using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;

namespace Simple_desktop_service
{
    public partial class SimpleService : ServiceBase
    {
        public SimpleService()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            Console.WriteLine("Amir");

            var startTimeSpan = TimeSpan.Zero;
            var periodTimeSpan = TimeSpan.FromSeconds(10);

            var timer = new System.Threading.Timer((e) =>
            {
                new WebClient().DownloadString("http://localhost:3000/");
            }, null, startTimeSpan, periodTimeSpan);
        }

        protected override void OnStop()
        {
        }

        public void OnDebug()
        {
            OnStart(null);
        }
    }
}
