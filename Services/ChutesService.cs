namespace Chutes_cSharp.Services;

public class ChutesService
{

  private readonly ChutesRepository _repo;

  public ChutesService(ChutesRepository repo)
  {
    _repo = repo;
  }

   public List<Chute> GetAllChutes() {
    
   List<Chute> chutes = _repo.GetAllChutes();
   return chutes;

   }


}