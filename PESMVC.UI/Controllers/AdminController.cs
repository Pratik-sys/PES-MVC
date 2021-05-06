using System;
using System.Collections.Generic;
using System.Linq;
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
            return View();
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
            return View();
        }
    }
}