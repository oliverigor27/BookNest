namespace BookNest.User.Models.UserModels;

using System.ComponentModel.DataAnnotations;
using BookNest.Books.Models.BookModel;

public class ReviewsModel 
{  
    [Required(ErrorMessage="É necessário que haja um título para a review!", AllowEmptyStrings=false)]
    public string Title { get; set; } = string.Empty;

    [Required(ErrorMessage="Texto da review não pode estar em branco!", AllowEmptyStrings=false)]
    public string Text { get; set; } = string.Empty;
    public Guid UserId { get; set; }
    public Guid BookId { get; set; }

    // Foreigin Key
    public UserModel? User { get; set; }
    // Naviagtion Property
    public BookModel? Book { get; set; }
}