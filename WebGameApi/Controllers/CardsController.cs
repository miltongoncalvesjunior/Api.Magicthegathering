using Microsoft.AspNetCore.Mvc;



namespace WebGameApi.Controllers
{
    public class CardsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

    }

}