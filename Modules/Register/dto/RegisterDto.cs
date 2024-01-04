namespace  BookNest.Modules.Register.dto;

// Camada que deveria estar mais perto da infra / view do client

public class RegisterDTO 
{
    public string Username { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Password { get; set; } = string.Empty;
};