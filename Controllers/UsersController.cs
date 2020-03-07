using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MyAppBack.Data;

namespace MyAppBack.Controllers
{

  [Route("api/[controller]")]
  [ApiController]
  public class UsersController : ControllerBase
  {
    private readonly IUserRepository _repo;
    public UsersController(IUserRepository repo)
    {
      _repo = repo;
    }

    [HttpGet]
    public async Task<IActionResult> GetUsers()
    {
      var users = await _repo.GetUsers();
      return Ok(users);
    }

    [HttpGet("{id}")]
    public async Task<IActionResult> GetUser(int id)
    {
      var user = await _repo.GetUser(id);
      return Ok(user);
    }
  }
}