using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.ServiceProcess;
using System.Text;
using System.Threading.Tasks;
using log4net;

namespace MyService
{
	public partial class Service1 : ServiceBase
	{
		private static readonly ILog _log = LogManager.GetLogger(typeof(Service1));

		public Service1()
		{
			log4net.Config.XmlConfigurator.Configure(); 
			InitializeComponent();
		}

		protected override void OnStart(string[] args)
		{
			_log.Info("Starting the service");
		}

		protected override void OnStop()
		{
			_log.Info("Stopping the service");
		}
	}
}
