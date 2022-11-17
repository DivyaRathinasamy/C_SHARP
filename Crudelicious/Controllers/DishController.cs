using Crudelicious.Models;
using Microsoft.AspNetCore.Mvc;

public class DishController : Controller
{
     private int? uid
    {
        get
        {
             return HttpContext.Session.GetInt32("UUID");
        }
       
    }
    private bool loggedIn
    {
        get
        {
            return uid != null;
        }
        
    }

    private CrudeliciousContext db;
    public DishController(CrudeliciousContext context)
    {
        db = context;
    }


    [HttpGet("/dishes")]

    public IActionResult All()
    {
        if (!loggedIn)
        {
            return RedirectToAction("Index" , "Users");
        }
        List<Dish> AllDishes =db.Dishes.ToList();
        return View("All" , AllDishes);
    }

    [HttpGet("/dishes/new")]

    public IActionResult New()
    {
        if (!loggedIn)
        {
            return RedirectToAction("Index" , "Users");
        }
        return View("New");
    }

    [HttpPost("dishes/create")]

    public IActionResult Create(Dish newDish)
    {
        if (!loggedIn)
        {
            return RedirectToAction("Index" , "Users");
        }
        if (!ModelState.IsValid)
        {
            return New();
        }
        Console.WriteLine(newDish.DishId);

        db.Dishes.Add(newDish);
        db.SaveChanges();
        Console.WriteLine(newDish.DishId);

        return RedirectToAction("All");


    }

    [HttpGet("/dishes/{oneDishId}")]

    public IActionResult GetOneDish(int oneDishId)
    {
        if (!loggedIn)
        {
            return RedirectToAction("Index" , "Users");
        }
        Dish? dish = db.Dishes.FirstOrDefault(d => d.DishId == oneDishId);

        if (dish == null)
        {
            return RedirectToAction("All");
        }

        return View("Details", dish);
    }

    [HttpPost("/dishes/{deletedDishId}/delete")]

    public IActionResult DeleteDish(int deletedDishId)
    {
        if (!loggedIn)
        {
            return RedirectToAction("Index" , "Users");
        }
        Dish? dish = db.Dishes.FirstOrDefault(d => d.DishId == deletedDishId);

        if (dish != null)
        {
            db.Dishes.Remove(dish);
            db.SaveChanges();
        }
        return RedirectToAction("All");
    }

    [HttpGet("/dishes/{dishId}/edit")]

    public IActionResult Edit(int dishId)
    {
        if (!loggedIn)
        {
            return RedirectToAction("Index" , "Users");
        }
        Dish? dish = db.Dishes.FirstOrDefault(d => d.DishId == dishId);
        if (dish == null)
        {
            return RedirectToAction("All");
        }

        return View ("Edit" ,dish);
    }


    [HttpPost("/dishes/{dishId}/update")]

    public IActionResult Update(Dish editedDish, int dishId)
    {
        if (!loggedIn)
        {
            return RedirectToAction("Index" , "Users");
        }
        if (ModelState.IsValid == false)
        {
            return Edit(dishId);
        }

         Dish? dish = db.Dishes.FirstOrDefault(d => d.DishId == dishId);

        if (dish == null)
        {
            return RedirectToAction("All");
        }

        dish.Name = editedDish.Name;
        dish.Chef = editedDish.Chef;
        dish.Calories = editedDish.Calories;
        dish.Tastiness = editedDish.Tastiness;
        dish.Description = editedDish.Description;
        dish.UpdatedAt = DateTime.Now;

        db.Dishes.Update(dish);
        db.SaveChanges();

        
        return RedirectToAction("GetOneDish" , new {dishId = dish.DishId} );
    }

}
   