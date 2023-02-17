using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using WebGameApi.Models;
using XPagedList;


namespace WebGameApi.Controllers
{



    public class CardsController : Controller
    {
        private readonly string ENDPOINT = "https://api.magicthegathering.io/v1/cards";
        private readonly HttpClient _httpClient = null;
        private List<Card> _cards = null;

        public CardsController()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(ENDPOINT);

        }
        public IActionResult Index()
        {
            return View();
        }

    }

}