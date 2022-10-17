
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CleanArch.WebAPI.Controller;

[ApiController]
[Route("category")]
public class CategoryController : ControllerBase
{

    private readonly ILogger<CategoryController> logger;

    public CategoryController(ILogger<CategoryController> _logger)
    {
        this.logger = _logger;
    }


    [HttpGet("getall")]
    public string GetAll(string username, string password)
    {
        return "Login";
    }
    [HttpGet("get/{id}")]
    public string GetById(int id)
    {
        return "Login";
    }

    [HttpPost("create")]
    public string Create(string name, string username, string password, int roleId)
    {
        return "Register";
    }

    [HttpPut("update/{id}")]
    public string Update(int id, [FromBody]string Name)
    {
        return "Register";
    }

    [HttpDelete("delete/{id}")]
    public string Delete(int id)
    {
        return "Register";
    }

}
