using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PESMVC.UI.Controllers
{
    public class CustomerController : Controller
    {
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult ViewUpdate()
        {
            return View();
        }
        public ActionResult Login()
        {
            return View();
        }

        public ActionResult EndorsementStatus()
        {
            return View();
        }
        public ActionResult Home()
        {
            return View();
        }
        public ActionResult SearchPolicy()
        {
            return View();
        }
        //Sign Up View Page
        public ActionResult SignUp()
        {
            return View();
        }
        //New Policy View Page
        public ActionResult NewPolicy()
        {
            return View();
        }
        // Apply policy page
        public ActionResult ApplyPolicy()
        {
            return View();
        }

    }
}