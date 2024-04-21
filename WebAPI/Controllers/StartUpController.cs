using Microsoft.AspNetCore.Mvc;


namespace WebAPI.Controllers
{
	[ApiController]
	[Route("[controller]/[action]")]
	public class StartUpController : ControllerBase
	{

		public StartUpController() { }

		[HttpGet]
		public IActionResult GetStarted()
		{
			string resultObje = "{ \"Result\" : \"Welcome To My API Service.\"}";
			return Ok(resultObje);
		}
	}
}
