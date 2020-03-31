using HPlus.Ecommerce.Data;
using HPlus.Ecommerce.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HPlus.Ecommerce.Controllers
{
    [Authorize]
    public class AccountController : Controller
    {
        public ActionResult Index()
        {
            Customer customer = null;
            using (HPlusSportDbContext ctx = new HPlusSportDbContext())
            {
                var user = ctx.Users.FirstOrDefault(u => u.EmailAddress == User.Identity.Name);
                customer = ctx.Customers.FirstOrDefault(c => c.CustomerID == user.CustomerId);
                View(customer);
            }

            return View();
        }
    }
}