namespace Chutes_cSharp.Repositories;


  public class ChutesRepository
  {
    private List<Chute> dbChutes;

    public ChutesRepository()
    {
      this.dbChutes = new List<Chute> { };
      dbChutes.Add(new Chute("Spider", 55, "Red", 9, 1));
      dbChutes.Add(new Chute("Javelin", 250, "Blue/Green", 7, 2));
      dbChutes.Add(new Chute("Spider", 500, "Yellow", 9, 3));
      
    }

    internal List<Chute> GetAllChutes()
    {
      return dbChutes;
    }




  }
