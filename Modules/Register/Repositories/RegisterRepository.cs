namespace BookNest.Modules.Register.Repositories;

using BookNest.Modules.Register.dto;


public class RegisterRepository : IRegisterRepository
{
    public Task<CompleteRegisterDTO> CompleteUser(string token, CompleteRegisterDTO user)
    {
        throw new NotImplementedException();
    }

    public Task<RegisterDTO> CreateUser(RegisterDTO user)
    {
        throw new NotImplementedException();
    }
}