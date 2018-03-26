using CDModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CDBAL;
using System.Web.Http.Filters;

namespace CdApi.Controllers
{          
    public class AccountAPIController : ApiController
    {
        [HttpPost]
        [Route("api/Account/RegisterUser")]
        public string RegisterUser(RegisterBindingModel obj)
        {
            BALAccount accountObj = new BALAccount();
            return accountObj.RegisterUser(obj);    

        }

        [HttpPost]
        [Route("api/Account/LoginUser")]
        public IHttpActionResult LoginUser(LoginBindingModel obj)
        {
            string username = "abc";
            BALAccount accountObj = new BALAccount();

            if (accountObj.LoginUser(obj) == "login successful")

                return Content(HttpStatusCode.OK,username);

            else return NotFound();

        }
    }
}
