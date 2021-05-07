using Newtonsoft.Json;
using PESMVC.Data.DTO.Endorsement;
using PESMVC.Data.DTO.InsuranceProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;

namespace PESMVC.UI.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult EndorsmentApproval()
        {
            return View();
        }
        public ActionResult InsuranceProduct()
        {
            List<GetInsuranceProductResponse> insuranceProducts = new List<GetInsuranceProductResponse>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:51259/api/InsuranceProduct/");

              
                //HTTP GET
                var responseTask = client.GetAsync("GetAllInsuranceProductsApi").Result;
                if (responseTask.IsSuccessStatusCode)
                {
                    var JsonContent = responseTask.Content.ReadAsStringAsync().Result;
                    insuranceProducts = JsonConvert.DeserializeObject<List<GetInsuranceProductResponse>>(JsonContent);
                }
            }
            return View(insuranceProducts);
        }
        public ActionResult SearchCustomer()
        {
            return View();
        }

        public ActionResult SearchPolicy()
        {
            return View();
        }

        public ActionResult EndorsementDetails()
        {
            List<GetEndorsementsResponse> endorsements = new List<GetEndorsementsResponse>();
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:51259/api/Endorsement/");
                //HTTP GET
                var responseTask = client.GetAsync("GetAllEndorsementsApi").Result;
                if (responseTask.IsSuccessStatusCode)
                {
                    var JsonContent = responseTask.Content.ReadAsStringAsync().Result;
                    endorsements = JsonConvert.DeserializeObject<List<GetEndorsementsResponse>>(JsonContent);
                }
            }
            return View(endorsements);
        }
    }
}