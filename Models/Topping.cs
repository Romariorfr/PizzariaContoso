using System.ComponentModel.DataAnnotations;

namespace ContosoPizza.Models;

public class Topping
{

    public int Id { get; set; }

    [Required]
    [MaxLength(100)]
    public string? Name { get; set; }

    public decimal Calories { get; set; }

    public ICollection<Pizza>? Pizzas { get; set; }
}