using Microsoft.AspNetCore.Mvc;

namespace Keysafe.Server.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class TestController : ControllerBase
	{
		#region Public Methods

		[HttpGet]
		public IActionResult TestMethod()
		{
			return this.Ok("Test method called");
		}

		#endregion Public Methods
	}
}