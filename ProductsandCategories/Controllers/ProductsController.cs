using ProductsandCategories.Models;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace ProductsandCategories;

public class ProductsController : Controller
{

    private MyContext db;
    public ProductsController(MyContext context)
    {
        db = context;

    }

    [HttpGet("/")]//Eggs

    [HttpGet("/products")]

    public IActionResult Index()
    {
    
        List<Product> AllProducts = db.Products.OrderBy(p =>p.Name).ToList();
        ViewBag.Products = AllProducts;
        return View("Index");

    
    }


    [HttpPost("/create/product")]

    public IActionResult CreateP(Product newProduct)
    {
        if (!ModelState.IsValid)
        {
            return View();
        }
        Console.WriteLine(newProduct.ProductId);

        db.Products.Add(newProduct);
        db.SaveChanges();
        Console.WriteLine(newProduct.ProductId);

        return RedirectToAction("Index");

    }
   

    [HttpGet("/products/{oneProductId}")]

    public IActionResult GetOneProduct(int oneProductId)
    {
        Product? product = db.Products.Include(p => p.ProductAssociation).ThenInclude(c =>c.Category).FirstOrDefault(p =>p.ProductId == oneProductId);
        ViewBag.product = product;

        if (product == null)
        {
            return RedirectToAction("Index");
        }

        List<Category> allcategories = db.Categories.ToList();

        List<Category> assignedcategory = new List<Category>();
        foreach(Association item in product.ProductAssociation.)
        {
            assignedcategory.Add(item.Category);
        }
        ViewBag.assignedcategory = assignedcategory;

        List<Category> unassignedcategory = allcategories.Except(assignedcategory).ToList();
        ViewBag.unassignedcategory = unassignedcategory;


        return View("ViewProduct");
    }
}