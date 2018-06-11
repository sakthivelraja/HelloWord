using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HelloWordApp.Models
{
    /// <summary>
    /// Model class to use in case of writing the web API response to a database using entity framework or other ORM tools
    /// </summary>
    class HelloWorldDto
    {
        public string message { get; set; }
    }
}
