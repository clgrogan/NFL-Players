using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NFL_Players.Models;

namespace NFL_Players.Controllers
{
  [ApiController]
  [Route("api[controller]")]
  public class PlayerController : ControllerBase
  {
    [HttpGet]
    public ActionResult GetAllPlayers()
    {
      var db = new DatabaseContext();
      // return Ok(new { Pong = DateTime.Now });
      return Ok(db.Players.OrderBy(player => player.Team));
    }

    [HttpPost]
    public ActionResult CreatePlayer(Player player)
    {
      var db = new DatabaseContext();
      db.Players.Add(player);
      db.SaveChanges();
      return Ok(player);
    }
  }

}