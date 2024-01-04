namespace BookNest.Modules.Register.dto;

public class CompleteRegisterDTO 
{
    public string FirstName { get; set; } = string.Empty;
    public string LastName { get; set; } = string.Empty;
    public List<string>? Preferences { get; set; }
}