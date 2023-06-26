namespace Chutes_cSharp.Controllers;

[ApiController]
[Route("api/chutes")]
public class ChutesController : ControllerBase
{
  private readonly ChutesService _chutesService;

public ChutesController(ChutesService chutesService)
{
  _chutesService = chutesService;
}

[HttpGet]
public ActionResult<List<Chute>> chutes()
{
  try
  {
    List<Chute> chutes = _chutesService.GetAllChutes();
    return Ok(chutes);
  }
  catch (System.Exception error)
  {
    return BadRequest("I cant do that." + error.Message);
  }
}

}