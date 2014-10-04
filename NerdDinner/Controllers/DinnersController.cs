using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Mvc.Ajax;
using NerdDinner.Models;

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

    }
}
