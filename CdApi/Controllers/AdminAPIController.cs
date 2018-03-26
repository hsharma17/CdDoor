using CDModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using CDBAL;

namespace CdApi.Controllers
{
    public class AdminAPIController : ApiController
    {

        [HttpPost]
        [Route("api/Admin/RegisterProperty")]
        public string RegisterProperty(submitNewProperty obj)
        {
            BALAdmin objAdmin = new BALAdmin();
           return objAdmin.RegisterProperty(obj);
            


        }
    }
}
