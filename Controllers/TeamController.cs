using System.Linq;
using Microsoft.AspNetCore.Mvc;
using NFL_Players.Models;

namespace NFL_Players.Controllers
{
  [ApiController]
  [Route("api[controller]")]
  public class TeamController : ControllerBase
  {
    [HttpGet]
    public ActionResult GetAllTeams()
    {
      var db = new DatabaseContext();
      // return Ok(new { Pong = DateTime.Now });
      return Ok(db.Teams.OrderBy(team => team.Name));
    }

    [HttpPost]
    public ActionResult CreateTeam(Team team)
    {
      var db = new DatabaseContext();
      db.Teams.Add(team);
      db.SaveChanges();
      return Ok(team);
    }
  }

}