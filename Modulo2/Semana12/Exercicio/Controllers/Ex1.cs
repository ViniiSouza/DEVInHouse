using Microsoft.AspNetCore.Mvc;

namespace Ex1.Controllers;

[ApiController]
[Route("[controller]")]
public class Ex1 : ControllerBase
{
    [HttpGet]
    public string HelloWorld()
    {
        return "Hello World";
    }
}
