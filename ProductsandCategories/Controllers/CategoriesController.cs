using ProductsandCategories.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ProductsandCategories;



public class CategoriesController : Controller
{

    private MyContext db;
    public CategoriesController(MyContext context)
    {
        db = context;

    }

    [HttpGet("/categories")]

    public IActionResult Category()
    {
    
        List<Category> AllCategories = db.Categories.OrderBy(c =>c.Name).ToList();
        ViewBag.Categories = AllCategories;
        return View("Category");

    
    }


    [HttpPost("/create/category")]

    public IActionResult CreateC(Category newCategory)
    {
        if (!ModelState.IsValid)
        {
            return View();
        }
        Console.WriteLine(newCategory.CategoryId);

        db.Categories.Add(newCategory);
        db.SaveChanges();
        Console.WriteLine(newCategory.CategoryId);

        return RedirectToAction("Category");

    }
   

    [HttpGet("/categories/{oneCategoryId}")]

    public IActionResult GetOneCategory(int oneCategoryId)
    {
        Category? category = db.Categories
        .Include(c => c.CategoryAssociation).ThenInclude(p =>p.Product).FirstOrDefault(c =>c.CategoryId == oneCategoryId);
        if (category == null)
        {
            return RedirectToAction("All");
        }

        return View("Details", category);
    }

    
}