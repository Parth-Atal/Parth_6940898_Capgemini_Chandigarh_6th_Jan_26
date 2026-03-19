using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

[Route("api/[controller]")]
[ApiController]
public class SecureApiController : ControllerBase
{
    [HttpGet]
    [Authorize] // JWT Protected
    public IActionResult GetData()
    {
        return Ok("Secure Data Accessed!");
    }
}