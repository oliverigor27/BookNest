namespace BookNest.Books.Models.BookModel;

using System.ComponentModel.DataAnnotations;

public class BookModel 
{
    [Key]
    public Guid BookId { get; set; }
    [Required]
    public string Title { get; set; } = string.Empty;
    public int Year { get; set; }
    public string Genre { get; set; } = string.Empty;
    
}