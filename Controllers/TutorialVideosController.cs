using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheSatoshiEra.DataAccess;

namespace TheSatoshiEra.Controllers
{
    [Route("api/TutorialVideos")]
    [ApiController]
    public class TutorialVideosController : ControllerBase
    {
        private TutorialVideosRepository _tutorialVideosRepository;

        public TutorialVideosController(TutorialVideosRepository tutorialVideosRepo)
        {
            _tutorialVideosRepository = tutorialVideosRepo;
        }


        [HttpGet]
        public IActionResult GetVideos()
        {
            var result = _tutorialVideosRepository.GetVideos();
            if (result.Count() >= 0)
            {
                return Ok(result);
            }
            else return NotFound("No entries found");
        }
    }
}
