// Disabled because we know the framework will assign non-null values when it
// constructs this class for us.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

using System.ComponentModel.DataAnnotations;

public class Dish
{
    [Key] 
    public int DishId { get; set; }


    [Required(ErrorMessage = "is Required")]

    public string Name { get; set;}

    [Required(ErrorMessage = "is Required")]
    public string Chef { get; set;}

    [Required(ErrorMessage = "is Required")]
    [Range(1,int.MaxValue, ErrorMessage ="Must be more than Zero")]

    public int Calories { get; set;}

    [Required(ErrorMessage = "is Required")]
   [Range(1,5 ,ErrorMessage = "Must be Greater than 1 and lesser than 5")]   
    public int Tastiness { get; set;}

    [Required(ErrorMessage = "is Required")]
    public string Description { get; set;}

    public DateTime CreatedAt { get; set;} = DateTime.Now;

    public DateTime UpdatedAt { get; set;} = DateTime.Now;

}