using Core.Services;
using Core.Test;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers
{
	[ApiController]
	[Route("api/test")]
	public class TestController : Controller
	{
		public TestService testService { get; set; }

		public TestController(TestService testService) 
		{
			this.testService = testService;		
		}

		[HttpGet("get-200")]
		public IActionResult GetTest()
		{
			return Ok();
		}

		[HttpGet("test")]
		public IActionResult Test()
		{
			var body = testService.GetTestBody();
			return Ok(body);
		}

		[HttpPost("trigger-400")]
		public IActionResult TriggerBadRequest()
		{
			return BadRequest();
		}
	}

}