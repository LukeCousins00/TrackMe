using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using TrackMe.Models;

namespace TrackMe.Controllers;
public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
}
