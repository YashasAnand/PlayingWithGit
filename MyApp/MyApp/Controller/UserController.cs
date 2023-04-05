using Microsoft.AspNetCore.Mvc;
using MyApp.Models;
using MyApp.Service;

namespace MyApp.Controller
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
       UserService user = new UserService();

       [HttpGet]
       public User Get()
       {
            return new User(1,"Yashas","yashas");
       }
    }
}
