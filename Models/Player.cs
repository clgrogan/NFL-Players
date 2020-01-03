using System;

namespace NFL_Players.Models
{

  public class Player
  {

    public int Id { get; set; }
    public string FullName { get; set; }
    public string Team { get; set; }
    public string Position { get; set; }
    public int JerseyNumber { get; set; }
    public DateTime BirthDate { get; set; }
    public int Height { get; set; }
    public int Weight { get; set; }
    public string College { get; set; }
    public string HighSchool { get; set; }

  }

}