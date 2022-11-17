// Disabled because we know the framework will assign non-null values when it
// constructs this class for us.
#pragma warning disable CS8618 // Non-nullable field must contain a non-null value when exiting constructor. Consider declaring as nullable.

using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

[NotMapped]
public class LoginUser
{

    [Required(ErrorMessage = "Login Email is Required")]
    [Display(Name = "Email")]
    public string LoginEmail { get; set;}

    
    
    [Required(ErrorMessage = "Password is Required")]
    [DataType(DataType.Password)]
    [Display(Name = "Password")]
    public string LoginPassword { get; set;}
}