using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using NerdDinner.Models;
using NerdDinner.Helpers;

namespace NerdDinner.Controllers
{
    public class DinnersController : Controller
    {

        DinnerRepository dinnerRepository = new DinnerRepository();
        
        // GET: /Dinners/

        //ActionResult Index
        public ActionResult Index()
        {
           //Response.Write("<h1>Coming Soon: Dinners</h1>");

            var dinners = dinnerRepository.FindUpComingDinners().ToList();
            return View(dinners);
        }


        //Get: /Dinners/Details/2
        public ActionResult Details(int id)
        {
            //Response.Write("<h1>Details DinnerId: " + id +"</h1>");
            Dinner dinner = dinnerRepository.GetDinner(id);
            if (dinner == null)
                return View("NotFound");
            else
                return View(dinner);
        }

        //GET /Dinner/Edit/2

        public ActionResult Edit(int id)
        {
            var dinner = dinnerRepository.GetDinner(id);
            return View(dinner);
        }

        //Post /Dinners/Edit/2
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Edit(int id, FormCollection formValues)
        {
            
            //Retrieve existing dinner
            Dinner dinner = dinnerRepository.GetDinner(id);

            //handle errors gracefully and let user know what failed validation:
            try
            {
              //Update dinner with controller Base Class UpdateModel:
            UpdateModel(dinner);

            //Persist changes back to database
            dinnerRepository.Save();

            //Perform Http redirect to details page for the saved Dinner
            return RedirectToAction("Details", new { id = dinner.DinnerId });

            }
            catch
            {
                ModelState.AddRuleViolations(dinner.GetRuleViolations());
                return View(dinner);
            }
            
        }


    }
}
