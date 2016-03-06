using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MVC523ExpressionHelperBug.Models;

namespace MVC523ExpressionHelperBug.Controllers
{
    public class HomeController : Controller
    {
        // GET: Home
        public ActionResult Index()
        {
            var data = new List<Person>();

            data.Add(new Person() { Id = 1, Name = "Will" });
            data.Add(new Person() { Id = 2, Name = "Tom" });
            data.Add(new Person() { Id = 3, Name = "Mary" });

            return PartialView(data);
        }
    }
}