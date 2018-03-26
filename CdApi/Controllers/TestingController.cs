using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CDBAL;
using CDModels;

namespace CdApi.Controllers
{
    public class TestingController : ApiController
    {
        [HttpPost]
        [Route("RegisterUser")]
        public string RegisterUser(RegisterBindingModel obj)
        {
            BALAccount objA = new BALAccount();
            return objA.RegisterUser(obj);
        }
    }
}
