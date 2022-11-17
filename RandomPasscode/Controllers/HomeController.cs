using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using RandomPasscode.Models;

namespace RandomPasscode.Controllers;

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


    [HttpPost("/Generate")]
    public IActionResult Generate()
    {
        string charMap = "QWERTYUIOPASDFGHJKLZXCVBNM1234567890";
        string tempPW = "";
        int count = 1;
        Random rand = new Random();
        for (int i = 0; i <= 14; i++)
        {
            tempPW += charMap[rand.Next(36)];
        }

        HttpContext.Session.SetString("tempPW", tempPW);

        if (HttpContext.Session.GetInt32("Count") == null)
        {
            HttpContext.Session.SetInt32("Count", count);
        }
        else
        {
            count = (int)HttpContext.Session.GetInt32("Count");
            count++;
            HttpContext.Session.SetInt32("Count", count);
        }

        return RedirectToAction("Index");
    }

    public IActionResult Privacy()
    {
        return View();
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
