
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace CleanArch.WebAPI.Controller;

[ApiController]
[Route("article")]
public class ArticleController : ControllerBase
{
 private readonly ILogger<ArticleController> logger;
    public ArticleController(ILogger<ArticleController> logger)
    {
        this.logger = logger;
    }

    [HttpGet("getall")]
    public string GetAll()
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
