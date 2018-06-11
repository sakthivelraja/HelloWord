using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using HelloWordApp.Services;
using HelloWordApp.Repositories;
using System.ComponentModel;
using Ninject.Modules;
using Ninject;

namespace HelloWordApp
{
    class HelloWorldApp
    {
        IHelloWorldService _service = null;

        /// <summary>
        /// Constructor with dependency injection
        /// </summary>
        /// <param name="service"></param>
        public HelloWorldApp(IHelloWorldService service)
        {
            _service = service;
        }

        /// <summary>
        /// Entry point into the core functionality of this application
        /// </summary>
        public void start()
        {
            DisplayMessage();
        }

        /// <summary>
        /// Method to write the information from API to different destinations
        /// </summary>
        public void DisplayMessage()
        {
            switch (ConfigurationManager.AppSettings.Get("outputType"))
            {
                case "console":
                    Console.WriteLine(_service.GetMessage(ConfigurationManager.AppSettings.Get("HelloWorldApiUrl")).Result);
                    break;

                case "database":
                    _service.InsertMessageIntoDatabase(ConfigurationManager.ConnectionStrings["DBConnectionString"].ConnectionString);
                    break;

                default:
                    Console.WriteLine("The write method specified is not supported by this application");
                    break;
            }
        }
    }
}
