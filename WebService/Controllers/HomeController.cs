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
            ViewBag.MyList = "the temperature in ";
            ViewBag.MyList += forcast.City.ToString();
            ViewBag.MyList += " is ";
            ViewBag.MyList += forcast.Temperature.ToString();
            ViewBag.MyList += " Degrees";
            return View(model);
        }
    }
}