using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Lab_1.Models;

namespace Lab_1.Controllers
{
    public class PersonController : Controller
    {
        // GET: Person
        public ActionResult Index()
        {
            Person person = new Person();
            ViewBag.Title = "Person";
            ViewBag.FirstName = person.FirstName = "Ethan";
            ViewBag.LastName = person.LastName = "Allgood";
            ViewBag.Age = person.Age = 26;

            return View();
        }
    }
}