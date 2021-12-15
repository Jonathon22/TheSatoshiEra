using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheSatoshiEra.DataAccess;
using TheSatoshiEra.Models;

namespace TheSatoshiEra.Controllers
{
    [Route("api/About")]
    [ApiController]
    public class AboutController : ControllerBase
    {
        private AboutRepository _aboutRepository;

        public AboutController(AboutRepository aboutRepo)
        {
            _aboutRepository = aboutRepo;
        }

        [HttpGet]
        public IActionResult ReadAbout()
        {
            var result = _aboutRepository.ReadAbout();
            if (result.Count() >= 0)
            {
                return Ok(result);
            }
            else return NotFound("No About");
        }


    }
}
