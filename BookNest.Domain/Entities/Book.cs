using System.ComponentModel.DataAnnotations;

namespace BookNest.Domain.Entities;

public class Book 
{
    [Key]
    public Guid BookId { get; set; }
    [Required]
    public string Title { get; set; } = string.Empty;
    public int Year { get; set; }
    public string Genre { get; set; } = string.Empty;
    
}