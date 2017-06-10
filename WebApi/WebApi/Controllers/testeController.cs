using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebApi.Controllers
{
    [RoutePrefix("api")]
    public class testeController : ApiController
    {
        [HttpGet]
        public string teste(){
            return "sdsd";
        }
    }
}
