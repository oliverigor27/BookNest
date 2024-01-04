namespace BookNest.App.Controllers.Register;

using BookNest.Domain.Models.UserModels;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;


[Route("api/[controller]")]
[ApiController]
public class RegisterController : ControllerBase 
{
    [HttpPost]
    public async Task<ActionResult<UserModel>> CreateUser(UserModel register) 
    {
        return Ok(new { Message = "User was created!", register.UserId });
    }

    [HttpPost("{id}")]
    public async Task<ActionResult<UserModel>> CompleteRegister(UserModel register) {
        return Ok(new { Message = "Yu are now able to use our application!", register.FirstName, register.LastName, register.Preferences });
    } 

}
