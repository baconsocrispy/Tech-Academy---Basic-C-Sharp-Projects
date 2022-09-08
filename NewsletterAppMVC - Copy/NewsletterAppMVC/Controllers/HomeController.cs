using NewsletterAppMVC.Models;
using NewsletterAppMVC.ViewModels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Windows.Input;

namespace NewsletterAppMVC.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        // good practice to add [HttpPost] tag above all post methods
        [HttpPost]
        public ActionResult SignUp(string firstName, string lastName, string emailAddress)
        {
            if (string.IsNullOrEmpty(firstName) || string.IsNullOrEmpty(lastName) || string.IsNullOrEmpty(emailAddress)) {
                // ~ sign means relative path
                return View("~/Views/Shared/Error.cshtml");
            }
            else
            {
                using (NewsletterEntities db = new NewsletterEntities())
                {
                    var signup = new SignUp();
                    signup.FirstName = firstName;
                    signup.LastName = lastName;
                    signup.EmailAddress = emailAddress;

                    db.SignUps.Add(signup);
                    db.SaveChanges();
                }

                return View("Success");
            }
        }
        
        public ActionResult Admin()
        {
            // connection to db via Entity Framework
            using (NewsletterEntities db = new NewsletterEntities())
            {
                var signups = db.SignUps;
                // passing View Models to View is considered best practice in almost all cases
                var signUpVMs = new List<SignUpVM>();
                foreach (var signup in signups)
                {
                    var signUpVM = new SignUpVM();
                    signUpVM.FirstName = signup.FirstName;
                    signUpVM.LastName = signup.LastName;
                    signUpVM.EmailAddress = signup.EmailAddress;

                    signUpVMs.Add(signUpVM);
                }
                return View(signUpVMs);
            }
        }
    }
}