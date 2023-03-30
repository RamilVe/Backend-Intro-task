using Microsoft.AspNetCore.Mvc;

namespace Backend_Intro.Controllers
{
    public class ProductController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Detail(int id)
        {
            return Content("Id: " + id);
        }
    }
}
