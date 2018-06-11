using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWordApp.Repositories
{
    interface IHelloWorldRepository
    {
        Task<string> GetMessageFromApi(string urlPath);

        void InsertMessageIntoDatabase(string connectionString);
    }
}
