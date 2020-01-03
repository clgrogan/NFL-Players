using System;

namespace NFL_Players.Models
{

  public class Team
  {

    public int Id { get; set; }
    public string Name { get; set; }
    public string NickName { get; set; }
    public string Conference { get; set; }
    public string Division { get; set; }
    public int FirstSeason { get; set; }
    public string City { get; set; }
    public string State { get; set; }
    public string Stadium { get; set; }
    public string Ownership { get; set; }
    public string GeneralManager { get; set; }
    public string HeadCoach { get; set; }
    public string Mascot { get; set; }

  }

}