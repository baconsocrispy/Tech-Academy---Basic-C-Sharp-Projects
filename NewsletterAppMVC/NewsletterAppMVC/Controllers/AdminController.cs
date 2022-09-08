using NewsletterAppMVC.ViewModels;
using NewsletterAppMVC.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace NewsletterAppMVC.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
        public ActionResult Index()
        {
            // connection to db via Entity Framework
            using (NewsletterEntities1 db = new NewsletterEntities1())
            {
                var signups = db.SignUps.Where(x => x.Removed == null).ToList();
                // passing View Models to View is considered best practice in almost all cases
                var signUpVMs = new List<SignUpVM>();
                foreach (var signup in signups)
                {
                    var signUpVM = new SignUpVM();
                    signUpVM.Id = signup.Id;
                    signUpVM.FirstName = signup.FirstName;
                    signUpVM.LastName = signup.LastName;
                    signUpVM.EmailAddress = signup.EmailAddress;

                    signUpVMs.Add(signUpVM);
                }
                return View(signUpVMs);
            }
        }

        public ActionResult Unsubscribe(int Id) 
        {
            using (NewsletterEntities1 db = new NewsletterEntities1())
            {
                var signup = db.SignUps.Find(Id);
                signup.Removed = DateTime.Now;
                db.SaveChanges();
            }
            return RedirectToAction("Index");
        }
    }
}