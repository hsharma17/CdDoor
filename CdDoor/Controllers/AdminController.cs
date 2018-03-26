using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CDModels;
using System.Net.Http.Headers;
using System.Net.Http;
using CdDoor.CDUtilities;
using System.Threading.Tasks;
using System.Net;
using System.IO;
using System.Text;
using System.Data;

namespace CdDoor.Controllers
{
    [AllowAnonymous]
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult RegisterProperty()
        {
            return View();
        }
        [HttpPost]
        public async Task<ActionResult> RegisterProperty(submitNewProperty obj)
        {
            String strAddress = obj.locality + "," + obj.city;
            if (strAddress != null)
            {
                String url = "http://maps.google.com/maps/api/geocode/xml?address=" + strAddress + "&sensor=false";
                WebRequest request = WebRequest.Create(url);
                using (WebResponse response = (HttpWebResponse)request.GetResponse())
                {

                    using (StreamReader reader = new StreamReader(response.GetResponseStream(), Encoding.UTF8))
                    {
                        DataSet dsResult = new DataSet();
                        dsResult.ReadXml(reader);
                        obj.longitude = dsResult.Tables["Location"].Rows[0][0].ToString();
                        obj.latitude = dsResult.Tables["Location"].Rows[0][1].ToString();

                    }
                }
            }
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:5025/");
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
                //GET Method  
                HttpResponseMessage response = await client.PostAsJsonAsync("api/admin/RegisterProperty", obj);
                if (response.IsSuccessStatusCode)
                {
                    var customerJsonString = await response.Content.ReadAsStringAsync();
                                
                    var HouseId = Common.JsonDeserialize<string>(customerJsonString);

                    ViewBag.HouseId = "1013"; // HouseId;
                   ViewBag.Rooms = 3; //obj.rooms;
                   return RedirectToAction("RegisterPropertyPage2", "Admin", new { HouseId = "1013", Rooms = 3 });
                }
                            }
            return View();

        }


        public ActionResult RegisterPropertyPage2(String HouseId, int Rooms)
        {
            RegisterPropertyPage2Model objRegisterPropertyPage2Model = new RegisterPropertyPage2Model { HouseId = HouseId, Rooms = Rooms };
            return View(objRegisterPropertyPage2Model);
        }

        public class RegisterPropertyPage2Model
        {
           public string HouseId { get; set; }
           public int Rooms { get; set; }

        
        }

       
    }
}