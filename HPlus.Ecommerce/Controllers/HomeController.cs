using HPlus.Ecommerce.Filters;
using System.Web.Mvc;

namespace HPlus.Ecommerce.Controllers
{
    [CrawlerFilter]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //throw new System.Exception();
            return View();
        }
    }
}