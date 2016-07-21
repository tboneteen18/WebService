using System.Web.Mvc;
using WebService.Models;

namespace WebService.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(WeatherModel model)
        {
            return View(model);
        }

        WeatherService.WeatherSoapClient client = new WeatherService.WeatherSoapClient("WeatherSoap");

        [HttpPost]
        public ActionResult Weather(WeatherModel model)
        {
            var forcast = client.GetCityWeatherByZIP(model.ZipCode);
            ViewData["MyList"] = "the temperature in ";
            ViewData["MyList"] += forcast.City.ToString();
            ViewData["MyList"] += " is ";
            ViewData["MyList"] += forcast.Temperature.ToString();
            ViewData["MyList"] += " Degrees";
            return View("Index", model);
        }
    }
}