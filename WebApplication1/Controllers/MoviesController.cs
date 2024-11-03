using Microsoft.AspNetCore.Mvc;

namespace WebApplication1.Controllers
{
    public class MoviesController : Controller
    {
        // Action --> public non-static function

        public IActionResult GetMovie(int id,string name)
        {
            //ContentResult result = new ContentResult();
            //result.Content = $"Movie With Id: {id}";
            //return result;
            return Content($"Movie With Id: {id}");
        }

        //public IActionResult Index()
        //{
            //ContentResult result = new ContentResult();
            //result.Content = "Index";
            //result.ContentType = "object/pdf";
            //return Content("Index","text/html");
        //}

        //public IActionResult Hamda()
        //{
            //RedirectResult result = new RedirectResult("https://localhost:44325/Movies/Index");

            //return Redirect("https://localhost:44325/Movies/Index");

            //return RedirectToAction("Index");
            //return RedirectToAction(nameof(Index));

            //return RedirectToRoute("default", new { controller = "Home", action = "Index" });
        //}

    }
}
