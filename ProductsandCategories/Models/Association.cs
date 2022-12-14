// Disabled because we know the framework will assign non-null values when it
// constructs this class for us.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

using System.ComponentModel.DataAnnotations;

namespace ProductsandCategories;

public class Association
{
    [Key] 
    public int AssociationId { get; set; }

    public int ProductId { get; set; }

    public int CategoryId { get; set; }

    public Product? Product { get; set;}

    public Category? Category { get; set;}



}