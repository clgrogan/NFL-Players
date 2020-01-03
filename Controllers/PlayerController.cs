using System;
using Microsoft.AspNetCore.Mvc;

namespace NFL_Players.Controllers
{
  [ApiController]
  [Route("api[controller]")]
  public class PlayerController : ControllerBase
  {
    [HttpGet]
    public ActionResult GetPlayer()
    {
      return Ok(new { Pong = DateTime.Now });
    }
  }

}