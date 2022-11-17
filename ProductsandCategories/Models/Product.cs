// Disabled because we know the framework will assign non-null values when it
// constructs this class for us.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

using System.ComponentModel.DataAnnotations;

namespace ProductsandCategories;

public class Product
{
    [Key] 
    public int ProductId { get; set; }


    [Required(ErrorMessage = "is Required")]

    public string Name { get; set;}

    [Required(ErrorMessage = "is Required")]
    public string Description { get; set;}

    [Required(ErrorMessage = "is Required")]
    [Range(1,int.MaxValue, ErrorMessage ="Must be more than Zero")]

    public decimal Price { get; set;}

    public DateTime CreatedAt { get; set;} = DateTime.Now;

    public DateTime UpdatedAt { get; set;} = DateTime.Now;

    public List<Product> Products { get; set;} = new List<Product>();

    
    public List<Association> ProductAssociation  { get; set; } = new List<Association>();

}
