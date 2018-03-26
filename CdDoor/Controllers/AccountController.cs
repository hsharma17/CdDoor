using CdDoor.CDUtilities;
using CDModels;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Formatting;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace YourNest.Controllers
{
    public class AccountController : Controller
    {
        //
        // GET: /Account/
         [AllowAnonymous]
        public ActionResult login()
        {
            return View();
        }
        [AllowAnonymous]
         [HttpPost]
        public async Task<ActionResult> login(LoginBindingModel obj)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5025/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //GET Method  
                HttpResponseMessage response = await client.PostAsJsonAsync("api/account/LoginUser", obj);
                if (response.IsSuccessStatusCode)
                {
                    var customerJsonString = await response.Content.ReadAsStringAsync();

        // Deserialise the data (include the Newtonsoft JSON Nuget package if you don't already have it)
                    var user = Common.JsonDeserialize<string>(customerJsonString); //JsonConvert.DeserializeObject<string>(customerJsonString);
       
                 
                    Session["UserId"] = obj.Email;
                    return RedirectToAction("index","home");
                }
                
                    
               
            }
            return View();
        }
         [AllowAnonymous]
        public ActionResult Register()
        {
            return View();
        }
        [AllowAnonymous]
        [HttpPost]
        public async Task<ActionResult> Register(RegisterBindingModel obj)
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5025/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                 
                HttpResponseMessage response = await client.PostAsJsonAsync("api/account/RegisterUser", obj);
                if (response.IsSuccessStatusCode)
                {
                    
                }

            }
            return View();

        }

        public ActionResult changepassword()
        {
            return View();
        }

        //static async Task<ActionResult> GetUserName(string UserID)
        //{
        //    using (var client = new HttpClient())
        //    {
        //        client.BaseAddress = new Uri("http://localhost:5025/");
        //        client.DefaultRequestHeaders.Accept.Clear();
        //        client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));

        //        HttpResponseMessage response = await client.GetAsync("api/account/RegisterUser/"+ UserID);
                
        //        if (response.IsSuccessStatusCode)
        //        {
                     
        //        }

        //    }

        //    return "";
        //}
    }
}
