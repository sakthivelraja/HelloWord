using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HelloWordApp.Repositories;

namespace HelloWordApp.Services
{
    class HelloWorldService : IHelloWorldService
    {
       IHelloWorldRepository _repo;
        
        /// <summary>
        /// Constructor with dependency injection
        /// </summary>
        /// <param name="repo"></param>
       public HelloWorldService(IHelloWorldRepository repo)
        {
            _repo = repo;
        }


        /// <summary>
        /// This method calls the repository to get the required data for display purposes
        /// </summary>
        /// <param name="urlPath"></param>
        /// <returns></returns>
        public Task<string> GetMessage(string urlPath)
        {
            return _repo.GetMessageFromApi( urlPath);
            //return "Hello World";
        }

        /// <summary>
        /// This method calls the repository to get the required data and to insert it into a database
        /// </summary>
        /// <param name="connectionString"></param>
        public void InsertMessageIntoDatabase(string connectionString)
        {
             _repo.InsertMessageIntoDatabase(connectionString);
        }

    }
}
