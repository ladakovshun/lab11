using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using WebApplication111.Filters;
using WebApplication111.Models;

namespace WebApplication111.Controllers
{
    [ServiceFilter(typeof(ActionLoggingFilter))]
    [ServiceFilter(typeof(UniqueUsersFilter))]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            return View();
        }
    }
}
