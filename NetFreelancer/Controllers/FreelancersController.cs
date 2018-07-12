using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using NetFreelancer.Models;

namespace NetFreelancer.Controllers
{
    public class FreelancersController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        //// GET: Freelancers
        //public ActionResult Index()
        //{
            
        //    return View(db.Freelancers.ToList());
        //}
        // GET: Freelancers by category
        public ActionResult Index(string category)
        {
            if (String.IsNullOrEmpty(category)) {
                return View(db.Freelancers.ToList());
            }

            return View(db.Freelancers.Where(f => f.ServiceCategory.ToLower().Contains(category.ToLower())).ToList());
        }

        // GET: Freelancers/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Freelancer freelancer = db.Freelancers  .Find(id);
            if (freelancer == null)
            {
                return HttpNotFound();
            }
            return View(freelancer);
        }
        
     
        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
