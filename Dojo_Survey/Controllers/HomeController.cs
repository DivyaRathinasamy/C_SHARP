using Microsoft.AspNetCore.Mvc;



public class HomeController : Controller
{
    [HttpGet("")]
    public IActionResult Index()
    {
        return View ("Index");
    }

    [HttpPost("/result")]

    public IActionResult Submit(string name, string language, string location,string comment)
    {
        ViewBag.Name = name;
        ViewBag.Language = language;
        ViewBag.Location = location;
        ViewBag.Comment = comment;

        return View("Result");
    }


}