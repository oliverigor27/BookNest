using System;
using System.Threading.Tasks;
using BookNest.Domain.Entities;

namespace BookNest.Domain.interfaces.Repository;

public interface IProfileUserRepository 
{
   Task GetAllBooks();
}