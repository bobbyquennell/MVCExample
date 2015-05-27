using AuthAndRedirect.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AuthAndRedirect.Controllers
{
    public class WebserviceController : Controller
    {
        // GET: Webservice
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult CheckForm(FormCollection form)
        {
            string ThirdPartyUrl = "http://www.sina.com.cn";
            string address1 = form["emailToCheck_1"];
            //...to check the form data here
            
            
            // if check successful, redirect to other page
            if (true)
            {
                //return RedirectToAction("Index","Login");// option1: log in page

                return Redirect(ThirdPartyUrl);// option 2: thrid party page
            }
            else
            {
                return View("Index");
            }

        }
    }
}