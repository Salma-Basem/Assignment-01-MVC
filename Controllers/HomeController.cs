using Microsoft.AspNetCore.Mvc;

namespace Assignment_01_MVC.Controllers
{
    public class HomeController : Controller
    {
        //public IActionResult  Index()
        //{
        //    ContentResult result = new ContentResult();
        //    result.Content = "Hello from content  ";
        //    return result ;
        //}

        //public ActionResult AboutUs()
        //{
        //    return Redirect("https://translate.google.com/?sl=ar&tl=en&op=translate");
        //}

        //public ActionResult ContactUs()
        //{
        //    return Content("Hello From Contact Us Action");
        //return RedirectToAction("Index"); 
        //}



        public IActionResult Index()
        {
            return View();
        } 

        public IActionResult AboutUs()
        {
            return View();
        }

        public IActionResult ContactUs()
        {
            return View();
        }

        public IActionResult Privacy ()
        {
            return View();
        }
    }
}
