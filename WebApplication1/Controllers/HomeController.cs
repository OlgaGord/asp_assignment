using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using WebApplication1.Models;




namespace WebApplication1.Controllers
{
    public class HomeController : Controller
        {
        private DiamondEntities1 _db = new DiamondEntities1();

        public ActionResult Details1()

        {

            return View(_db.Items.ToList());

        }
        public ActionResult Index()
        {
            return View();
        }
    
        // GET: /Home/Create 

        public ActionResult Create()

        {

            return View();

        }

        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult Create([Bind(Exclude = "id")]Item itemToCreate)

        {

            if (!ModelState.IsValid)

                return View();
            itemToCreate.IdItems=_db.Items.Count();

            _db.Items.Add(itemToCreate);

            _db.SaveChanges();

            return RedirectToAction("Details1");

        }
        //

        // POST: /Home/Create 


        //

        // GET: /Home/Edit/5

        public ActionResult Edit(int id)

        {

            var itemToEdit = (from m in _db.Items

                               where m.IdItems == id

                               select m).First();

            return View(itemToEdit);

        }

        //

        // POST: /Home/Edit/5 


                             
        [AcceptVerbs(HttpVerbs.Post)]

        public ActionResult Edit(Item itemToEdit)

        {

            var diamondItem = (from m in _db.Items

                                 where m.IdItems == itemToEdit.IdItems

                                 select m).First();

            if (!ModelState.IsValid)

                return View(diamondItem);

//   var itemToUpdate1 = _db.Items.Find();
            if (TryUpdateModel(diamondItem, "",
               new string[] { "name", "description", "price", "category", "image" })) ;
            {
                try
                {
                    _db.SaveChanges();

                    return RedirectToAction("Index");
                }
                catch (DataException /* dex */)
                {
                    //Log the error (uncomment dex variable name and add a line here to write a log.
                    ModelState.AddModelError("", "Unable to save changes. Try again, and if the problem persists, see your system administrator.");
                }
            }
            return View(diamondItem);




            




               // _db.ApplyPropertyChanges(diamondItem.name, itemToEdit);

            /*
             var diamondItem1 = (from m in _db.Items

                                    where m.IdItems == itemToEdit.IdItems

                                    select m).First();

              diamondItem1.name = diamondItem.name;


  */


            _db.SaveChanges();

            return RedirectToAction("Details1");

        }
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