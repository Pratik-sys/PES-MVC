using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Mvc;


namespace PESMVC.UI.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri("http://localhost:51259/api/Policy/");
                //HTTP GET
                var responseTask = client.GetAsync("GetAllPolicyApi").Result;
                if (responseTask.IsSuccessStatusCode)
                {
                    var JsonContent = responseTask.Content.ReadAsStringAsync().Result;
                    ViewBag.result = JsonContent;
                }
                else
                {
                    ViewBag.result = "Server error. Please contact administrator.";
                }

            }
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}