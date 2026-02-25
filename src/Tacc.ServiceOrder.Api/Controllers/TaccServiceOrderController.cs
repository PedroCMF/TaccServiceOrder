using Microsoft.AspNetCore.Mvc;

namespace Tacc.ServiceOrder.Api.Controllers;

[Route("api/[controller]")]
[ApiController]
public class TaccServiceOrderController : ControllerBase
{
    [HttpGet]
    public IActionResult Get()
    {       
        return Ok(new {message = "Tacc ServiceOrder está rodando",date = DateTime.UtcNow} );
    }
}