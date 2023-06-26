using System.ComponentModel.DataAnnotations;

namespace Chutes_cSharp.Models;

public class Chute
{
  public Chute(string name, int? jumps, string color, int? cells, int id)
  {
    Name = name;
    Jumps = jumps;
    Color = color;
    Cells = cells;
    Id = id;
  }

  public int Id { get; set; }

  public string Name { get; set; }

  public int? Jumps { get; set; }

  public string Color { get; set; }

  public int? Cells { get; set; }


}