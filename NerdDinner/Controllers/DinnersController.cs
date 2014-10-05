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
      // ViewModel Classes

     public class DinnerFormViewModel
    {



        // Properties

        public Dinner Dinner { get; private set; }

        public SelectList Countries { get; private set; }



        // Constructor

        public DinnerFormViewModel(Dinner dinner)
        {

            Dinner = dinner;

            Countries = new SelectList(PhoneValidator.Countries, Dinner.Country);

        }

    }


    
    
    public class DinnersController : Controller
    {

        DinnerRepository dinnerRepository = new DinnerRepository();
        
        // GET: /Dinners/

        //ActionResult Index
        public ActionResult Index(int? page)
        {
           //Response.Write("<h1>Coming Soon: Dinners</h1>");

            var upComingDinners = dinnerRepository.FindUpComingDinners();

            //adding paging
            const int pageSize = 10;

            var paginatedDinners = new PaginatedList<Dinner>(upComingDinners, page ?? 0, pageSize);
            return View(paginatedDinners);
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
        //[Authorize]
        public ActionResult Edit(int id)
        {
            var dinner = dinnerRepository.GetDinner(id);

            //ViewData
            ViewData["countries"] = new SelectList(PhoneValidator.Countries, dinner.Country);

            return View(new DinnerFormViewModel(dinner));
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
                  //Locking down the UpdateModel to update only fields specified in allowed properties
                 //string[] allowedProperties = new []{"Title", "Description", "ContactPhone", "..."}
                 //UpdateModel(dinner, allowedProperties);
            UpdateModel(dinner);

            //Persist changes back to database
            dinnerRepository.Save();

            //Perform Http redirect to details page for the saved Dinner
            return RedirectToAction("Details", new { id = dinner.DinnerId });

            }
            catch
            {
                ModelState.AddRuleViolations(dinner.GetRuleViolations());
                //ViewData
                ViewData["countries"] = new SelectList(PhoneValidator.Countries, dinner.Country);
                return View(new DinnerFormViewModel(dinner));
            }
            
        }

        //Get: /Dinners/Create
        public ActionResult Create()
        {
            Dinner dinner = new Dinner() { EventDate = DateTime.Now.AddDays(7) };
            return View(new DinnerFormViewModel(dinner));
        }

        //Post: /Dinners/Create
        [AcceptVerbs(HttpVerbs.Post)]
        //public ActionResult Create( [Bind(Include=Title,Address")]Dinner dinner) //locking down bind on object passed as parameter to only update Include Fields
        public ActionResult Create(Dinner dinner)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    dinner.HostedBy = "SomeUser";

                    dinnerRepository.Add(dinner);
                    dinnerRepository.Save();

                    return RedirectToAction("Details", new { Id = dinner.DinnerId });
                }
                catch
                {
                    ModelState.AddRuleViolations(dinner.GetRuleViolations());
                }
            }
            return View(new DinnerFormViewModel(dinner));
        }

        //HTTP GET: /Diners/Delete/1
        public ActionResult Delete(int id)
        {
            Dinner dinner = dinnerRepository.GetDinner(id);

            if (dinner == null)
                return View("NotFound");
            else

                return View(dinner);
        }

        //Http Post: /Dinners/Delete/1
        [AcceptVerbs(HttpVerbs.Post)]
        public ActionResult Delete(int id, string confirmButton)
        {
            Dinner dinner = dinnerRepository.GetDinner(id);

            if (dinner == null)
                return View("NotFound");
            
            dinnerRepository.Delete(dinner);
            dinnerRepository.Save();

            return View("Deleted");


        }



    }
}
