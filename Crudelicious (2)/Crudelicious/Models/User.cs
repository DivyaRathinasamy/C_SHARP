// Disabled because we know the framework will assign non-null values when it
// constructs this class for us.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Crudelicious.Models;

public class User

{
    [Key]

   
    public int UserId { get; set;}

    [Required(ErrorMessage = "is Required")]
    [Display(Name = "First Name")]
    public string Firstname { get; set;}

    [Required(ErrorMessage = "is Required")]
    [Display(Name = "Last Name")]
    public string Lastname { get; set;}

    [Required(ErrorMessage = "is Required")]
    [Display(Name = "Email")]
    [DataType(DataType.EmailAddress)]
    public string Email { get; set;}

    [Required(ErrorMessage = "is Required")]
    [MinLength(8, ErrorMessage = "Must Be atleast 8 Characters")]
    [DataType(DataType.Password)]
    public string Password { get; set;}

    [NotMapped]
    [DataType(DataType.Password)]
    [Compare("Password", ErrorMessage ="Password doesn't Match")]
    [Required(ErrorMessage = "is Required")]
    [Display(Name = "Confirm Password")]
    public string ConfirmPassword { get; set;}

    public DateTime CreatedAt { get; set;} = DateTime.Now;

    public DateTime UpdatedAt { get; set;} = DateTime.Now;


}