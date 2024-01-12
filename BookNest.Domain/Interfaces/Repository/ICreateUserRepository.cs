using System;
using System.Threading.Tasks;
using BookNest.Domain.Entities;

namespace BookNest.Domain.interfaces.Repository;

public interface ICreateUserRepository 
{
    Task<UserDto> CreateUser(UserDto user);
}