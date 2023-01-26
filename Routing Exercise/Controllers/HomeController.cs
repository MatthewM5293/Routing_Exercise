using Microsoft.AspNetCore.Mvc;
using Routing_Exercise.Models;
using System.Diagnostics;

namespace Routing_Exercise.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        
        //cow moo
        [Route("{num}")]
        public IActionResult Cow(int num)
        { 
            return Content($"The Cow moos at you " + num.ToString() + " times.");
        }

        //chickfila
        [Route("EatMoreChicken")]
        public IActionResult Chicken()
        {
            return Redirect("https://www.chick-fil-a.com/?gclid=CjwKCAiA5sieBhBnEiwAR9oh2qWawostPJ58tQ3I0j4G5WpK3I4-yUyPTB97AxT_ZXBwfE8oNiVl1RoC7TgQAvD_BwE");
        }
        
        //cowName
        [Route("{num}/{name}")]
        public IActionResult CowName(string name, int num)
        {
            return Content($"The cow {name} moos at you {num.ToString()} times.");
        }
        
        //cow gallery
        [Route("AllCows/Gallery/{num}")]
        public IActionResult AllCows(int num)
        {
            return Content($"There are {num.ToString()} cows features on our website");
        }
        
        //cow pages
        [Route("AllCows/Gallery/{num}/Page{num2}")]
        public IActionResult AllCowsPage(int num, int num2)
        {
            return Content($"There are {num.ToString()} cows featured in {num2} pages on our website");
        }
        
        //cow double nums
        [Route("AllCows/Gallery/{num}/{num2}")]
        public IActionResult AllCows2nums(int num, int num2)
        {
            return Content($"There are {num.ToString()} cows per page, page {num2}");
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}