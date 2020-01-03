using System;
using System.Text.RegularExpressions;
using Microsoft.EntityFrameworkCore;
// using Microsoft.EntityFrameworkCore.Metadata;

namespace NFL_Players.Models
{
  public partial class DatabaseContext : DbContext
  {
    public DbSet<Team> Teams { get; set; }
    public DbSet<Player> Players { get; set; }

    private string ConvertPostConnectionToConnectionString(string connection)
    {
      var _connection = connection.Replace("postgres://", String.Empty);
      var output = Regex.Split(_connection, ":|@|/");
      return $"server={output[2]};database={output[4]};User Id={output[0]}; password={output[1]}; port={output[3]}";
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
      if (!optionsBuilder.IsConfigured)
      {
        var envConn = Environment.GetEnvironmentVariable("DATABASE_URL");
#warning Update this furry string to point to your own database.
        var conn = "server=localhost;database=NFL_PlayersDatabase";
        if (envConn != null)
        {
          conn = ConvertPostConnectionToConnectionString(envConn);
        }
        optionsBuilder.UseNpgsql(conn);
      }
    }



  }
}
