using Newtonsoft.Json;
using PESMVC.Data.DTO.Customer;
using PESMVC.Data.DTO.InsuranceProducts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Web;
using System.Web.Mvc;

namespace PESMVC.UI.Controllers
{
    public class InsuranceProductController : Controller
    {
        // GET: InsuranceProduct
        public ActionResult Index()
        {
            List<GetInsuranceProductResponse> insuranceProducts = new List<GetInsuranceProductResponse>();
            using (var client = new HttpClient())
            {
                client.DefaultRequestHeaders.TryAddWithoutValidation("Authorization","Bearer " + Session["access_token"].ToString());
                client.BaseAddress = new Uri("http://localhost:51259/api/InsuranceProduct/");
                var responseTask = client.GetAsync("GetAllInsuranceProductsApi").Result;
                if (responseTask.IsSuccessStatusCode)
                {
                    var JsonContent = responseTask.Content.ReadAsStringAsync().Result;
                    insuranceProducts = JsonConvert.DeserializeObject<List<GetInsuranceProductResponse>>(JsonContent);
                }
            }
            return View(insuranceProducts);
        }
    }
}