using Microsoft.AspNetCore.Mvc;

namespace CQRS_Project.API.Controllers
{
    public class ProductController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
