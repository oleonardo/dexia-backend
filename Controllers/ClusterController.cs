using Microsoft.AspNetCore.Mvc;

namespace DexiaApi.Controllers;

[ApiController]
[Route("[controller]")]
public sealed class ClusterController : ControllerBase
{
   [HttpGet]
   public IActionResult Get()
   {
      return Ok("Hello World!");
   }
}