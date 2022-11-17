#pragma warning disable CS8618

using System.ComponentModel.DataAnnotations;

public class Result
{
    [Required]
    [MinLength(3)]
    public string Name {get; set;}
    public string Location {get; set;}
    public string Language {get; set;}

    [MinLength(20)]
    public string? Comment {get; set;}


}

