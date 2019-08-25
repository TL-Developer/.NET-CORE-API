using Microsoft.AspNetCore.Mvc;

namespace API.Controllers
{
  [Route("api/v1")]
  public class HomeController : Controller
  {

    [Route("")]
    [HttpGet]
    public string Get () => "Hello World";
  }
}
