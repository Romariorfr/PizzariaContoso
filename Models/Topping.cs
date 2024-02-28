using System.ComponentModel.DataAnnotations;

namespace ContosoPizza.Models;

public class Topping
{
    [Required]
    [MaxLength(100)]
    public int Id { get; set; }
    public string? Name { get; set; }

    public decimal Calories { get; set; }

    public ICollection<Pizza>? Pizzas { get; set; }
}