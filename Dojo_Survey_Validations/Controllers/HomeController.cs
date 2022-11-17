﻿using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using Dojo_Survey_Validations.Models;

namespace Dojo_Survey_Validations.Controllers;

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

     [HttpPost("/result")]

    public IActionResult Submit(Result result)
    {
        if(ModelState.IsValid){
            return View("Result" , result);

        } else{
            return View("Index");
        }

    
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
