// Disabled because we know the framework will assign non-null values when it
// constructs this class for us.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

using System.ComponentModel.DataAnnotations;

namespace ProductsandCategories;

public class Category
{
    [Key] 
    public int CategoryId { get; set; }


    [Required(ErrorMessage = "is Required")]

    public string Name { get; set;}

    public DateTime CreatedAt { get; set;} = DateTime.Now;

    public DateTime UpdatedAt { get; set;} = DateTime.Now;

    public int ProductId {get; set;}

    public Product? Author{get; set;}

    public List<Association> CategoryAssociation  { get; set; } = new List<Association>();


}
