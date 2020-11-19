using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace TestApi.Controllers
{
  [Route("[controller]")]
  public class ReproController : ControllerBase
  {
    [HttpGet]
    public IActionResult GetByIdList([FromQuery] IEnumerable<int> filterId)
    {
      if (!ModelState.IsValid)
      {
        return BadRequest(ModelState);
      }

      return Ok(filterId);
    }
  }
}
