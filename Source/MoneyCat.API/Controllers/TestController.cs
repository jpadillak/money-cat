using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;

namespace MoneyCat.API.Controllers
{
	[Route("api/test")]
	public class TestController : Controller
	{
		[HttpGet()]
		public JsonResult GetTest()
		{
			return new JsonResult(new List<object>() {
				new { id=1, name="Hello World"}
			});
		}
	}
}