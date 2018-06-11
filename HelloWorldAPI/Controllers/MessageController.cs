using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace HelloWorldAPI.Controllers
{
    /// <summary>
    /// This controller uses attribute routing
    /// </summary>
    [RoutePrefix("api/v1/message")]
    public class MessageController : ApiController
    {
        /// <summary>
        /// This method returns a Hello World message
        /// </summary>
        /// <returns></returns>
        // GET api/v1/message/helloWorld
        [Route("helloWorld")]
        public string Get()
        {
            return "Hello World";
        }

    }
}
