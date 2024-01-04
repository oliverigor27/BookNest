namespace BookNest.User.Models.UserModels;

using System.ComponentModel.DataAnnotations;

public class UserModel 
{
    public Guid UserId { get; set; }

    public string Username { get; set; } = string.Empty;

    [Required(ErrorMessage = "Informe o seu email")]
    public string Email { get; set; } = string.Empty;

    [Required]
    [DataType(DataType.Password)]
    [StringLength(19, MinimumLength = 6)]
    public string Password { get; set; } = string.Empty;

    public string? FirstName { get; set; } = string.Empty;

    public string? LastName { get; set; } = string.Empty;

    public string[]? Preferences { get; set; }
}