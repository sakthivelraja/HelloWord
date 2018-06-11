using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using HelloWordApp.Services;
using HelloWordApp.Repositories;

namespace HelloWordApp
{
    class Program
    {
        /// <summary>
        /// Entry point into the console app
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Getting data from the web API, Please wait..........");
            //To give sufficient time for web API to get hosted in local IIS
            Thread.Sleep(2000);
            IHelloWorldRepository repo = new HelloWorldRepository();
            IHelloWorldService service = new HelloWorldService(repo);
            HelloWorldApp app = new HelloWorldApp(service);

            app.start();

            Console.ReadKey();
        }
    }
}
