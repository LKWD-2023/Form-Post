using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using WebApplication13.Models;

namespace WebApplication13.Controllers
{
    public class PostDemoController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult FormPost(string value)
        {
            FormPostViewModel vm = new FormPostViewModel
            {
                Value = value
            };

            return View(vm);
        }

        public ActionResult HiddenDemo()
        {
            return View();
        }

        [HttpPost]
        public ActionResult PostHidden(string hiddenValue)
        {
            HiddenViewModel vm = new HiddenViewModel
            {
                Value = hiddenValue
            };
            return View(vm);
        }
    }
}