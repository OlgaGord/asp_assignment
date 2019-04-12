using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;



namespace WebApplication1.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
/*

        // GET: /Home/Details/5 

        public ActionResult Details(int id)

        {

            return View();

        }

        //

        // GET: /Home/Create 

        public ActionResult Create()

        {

            return View();

        }

        //

        // POST: /Home/Create 

        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult Create(FormCollection collection)

        {

            try

            {

                // TODO: Add insert logic here 

                return RedirectToAction("Index");

            }

            catch

            {

                return View();

            }

        }

        //

        // GET: /Home/Edit/5

        public ActionResult Edit(int id)

        {

            return View();

        }

        //

        // POST: /Home/Edit/5 

        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult Edit(int id, FormCollection collection)

        {

            try

            {

                // TODO: Add update logic here

                return RedirectToAction("Index");

            }

            catch

            {

                return View();

            }

        }
*/





        public ActionResult About()
        {
            ViewBag.Message = "At Luxe Diamond Jewelers the passion for beautiful jewelry and friendly service is obvious..";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Please Visit Luxe Diamond Jewelers at the following location.";

            return View();
        }





    }
}