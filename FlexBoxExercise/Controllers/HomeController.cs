using Microsoft.AspNetCore.Mvc;

namespace FlexBoxExercise.Controllers
{
    public class HomeController : Controller
    {
        public ViewResult Index()
        {
            return View();
        }
    }
}
