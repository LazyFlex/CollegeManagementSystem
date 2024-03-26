
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CollegeManagementSystem.Controllers
{
    public class HomeController : Controller
    {


        public IActionResult Index()
        {
            return View();
        }

  
    }
}
