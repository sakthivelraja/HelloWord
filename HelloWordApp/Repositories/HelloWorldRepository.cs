using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net.Http;

namespace HelloWordApp.Repositories
{
    class HelloWorldRepository : IHelloWorldRepository
    {
        /// <summary>
        /// Constructor for this class
        /// </summary>
        public HelloWorldRepository()
        {

        }

        /// <summary>
        /// This method invokes the CallAPI method
        /// </summary>
        /// <param name="urlPath"></param>
        /// <returns></returns>
        public async Task<string> GetMessageFromApi(string urlPath)
        {

            return await CallAPI(urlPath);
           
        }

        /// <summary>
        /// This method would call the API, get the message and then inserts message into a database using the specified connection string
        /// </summary>
        /// <param name="connectionString"></param>
        public void  InsertMessageIntoDatabase(string connectionString)
        {
            // Code to Invoke CallAPI method to get the data and inserting into the Database goes here
          
        }

        /// <summary>
        /// This method calls the API and returns the method to calling method
        /// </summary>
        /// <param name="urlPath"></param>
        /// <returns></returns>
        private async Task<string> CallAPI(string urlPath)
        {
            HttpResponseMessage responseMessage;

            using (HttpClient client = new HttpClient())
            {
                responseMessage = await client.GetAsync(urlPath);
            }

            return await responseMessage.Content.ReadAsStringAsync();
        }
    }
}
