using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWordApp.Services
{
    interface IHelloWorldService
    {
        Task<string> GetMessage(string urlPath);

        void InsertMessageIntoDatabase(string connectionString);
    }
}
