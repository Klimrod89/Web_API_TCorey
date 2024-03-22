using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace GettingStartedWithApi.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UsersController : ControllerBase
{
    // GET: api/Users
    [HttpGet]
    public IEnumerable<string> Get()
    {
        List<string> output = new();
        for (int i = 0; i < Random.Shared.Next(2, 10); i++)
        {
            output.Add($"Value #{i + 1}");
        }
        return output;
    }

    // Get: api/Users/5
    [HttpGet("{id}")]
    public string Get(int id)
    {
        return $"Value #{id}";
    }

    // Get: api/Users/5
    [HttpPost]
    public void Post([FromBody] string value)
    {
        
    }
}
