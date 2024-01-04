namespace BookNest.Modules.Register. Repositories;

using BookNest.Modules.Register.dto;

public interface IRegisterRepository 
{
    Task<RegisterDTO> CreateUser(RegisterDTO user);
    Task<CompleteRegisterDTO> CompleteUser(string token, CompleteRegisterDTO user);
}