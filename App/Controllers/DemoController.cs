using App.Dto;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Xml.Linq;

namespace App.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DemoController : ControllerBase
    {
        [HttpGet]
        public ActionResult<Demo> Get()
        {
            Demo demo = new Demo();
            demo.Name = "Test";
            demo.Description = "Description Test";


            return Ok(new { 
                Name = demo.Name,
                Description= demo.Description
            });
        }
    }
}
