using EduConnect.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace EduConnect.Controllers

{

    
    public class HomeController : Controller
    {
        private readonly EduConnectDBContext eduConnectDB;
        public HomeController(EduConnectDBContext eduConnectDB)
        {
            this.eduConnectDB = eduConnectDB;


        }

        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Tutor()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [HttpPost]
        public ActionResult Contact(RequestTable req)
        {
            /*ViewBag.Message = "Your contact page.";*/
            if (ModelState.IsValid)
            {
                eduConnectDB.RequestTable.Add(req);
                eduConnectDB.SaveChanges();
                TempData["req submit"] = "Your request has been submitted....";
                return RedirectToAction("Index");
            }
            return View();
        }
        public ActionResult Hire()
        {
            ViewBag.Message = "Your Hire page.";

            return View();
        }
        [HttpPost]
        public ActionResult Hire(HiringForm HF)
        {
            if (ModelState.IsValid)
            {
                eduConnectDB.HiringForm.Add(HF);
                eduConnectDB.SaveChanges();
                TempData["req submit"] = "Your Hiring request has been submitted....";
                return RedirectToAction("Index");
            }

            return View();
        }
    }
}
