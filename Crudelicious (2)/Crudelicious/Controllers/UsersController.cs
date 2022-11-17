using Crudelicious.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;

public class UsersController : Controller
{

    private CrudeliciousContext db;
    public UsersController(CrudeliciousContext context)
    {
        db = context;
    }


    [HttpGet("/")]
    public IActionResult Index()
    {
        return View("Index");
    }

    [HttpPost("/register")]

    public IActionResult Register(User newUser)
    {
        if (ModelState.IsValid)
        {
            if (db.Users.Any(u => u.Email == newUser.Email))
            {
                ModelState.AddModelError("Email", "is already Taken");
            }
        }

        if (ModelState.IsValid == false)
        {
            return Index();
        }

        PasswordHasher<User> hashPass = new PasswordHasher<User>();
        newUser.Password = hashPass.HashPassword(newUser, newUser.Password);

        db.Users.Add(newUser);
        db.SaveChanges();

        HttpContext.Session.SetInt32("UUID", newUser.UserId);
        HttpContext.Session.SetString("Email", newUser.Email);
        return RedirectToAction("All", "Dish");

    }

    [HttpPost("/login")]

    public IActionResult Login(LoginUser loginUser)
    {
        if (ModelState.IsValid == false)
        {
            return Index();
        }

        User? dbUser = db.Users.FirstOrDefault(u => u.Email == loginUser.LoginEmail);

        if (dbUser == null)
        {
            ModelState.AddModelError("LoginEmail", "not found");
            return Index();
        }

        PasswordHasher<LoginUser> hashPass = new PasswordHasher<LoginUser>();
        PasswordVerificationResult pwCompareResult = hashPass.VerifyHashedPassword(loginUser, dbUser.Password, loginUser.LoginPassword);
        if (pwCompareResult == 0)
        {
            ModelState.AddModelError("LoginPassword" , "invalid password");
            return Index();
        }

        HttpContext.Session.SetInt32("UUID" , dbUser.UserId);
        HttpContext.Session.SetString("Email" , dbUser.Email);
        
        return RedirectToAction ("All" , "Dish");
    }


    [HttpPost("/logout")]

    public IActionResult Logout()
    {
        HttpContext.Session.Clear();
        return RedirectToAction("Index");
    }

}

