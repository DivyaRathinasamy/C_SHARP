
using Microsoft.AspNetCore.Mvc;




public class HomeController : Controller

{
    [HttpGet("")]
    public ViewResult Index()
    {
        return View ("Index");
    }


    [HttpGet("/projects")]

    public IActionResult Projects()
    {
        return View("Project");
    }

    [HttpGet("/contact")]

    public IActionResult Contacts()
    {
        return View("Contact");

    }


}

