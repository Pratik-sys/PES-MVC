using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace PESMVC.Auth.Controllers
{
    public class TestController : ApiController
    {
        [Authorize(Roles = "Admin")]
        [HttpGet]
        public IHttpActionResult getResult()
        {
            return Ok("Hello");
        }
    }
}
