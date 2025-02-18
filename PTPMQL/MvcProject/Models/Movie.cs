using System.ComponentModel.DataAnnotations;

namespace MvcProject.Models;

public class Movie
{
public int Id { get; set;}

public String? Title { get; set;}
[DataType(DataType.Date)]
public DateTime ReleaseDate{ get; set;}

public String? Geren { get; set;}

public decimal Price { get; set;}

}