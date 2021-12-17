using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using Dapper;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheSatoshiEra.DataAccess;

namespace TheSatoshiEra.Controllers
{
    [Route("api/UserTypes")]
    [ApiController]
    public class UserTypesController : ControllerBase
    {
        private UserTypesRepository _userTypesRepository;

        public UserTypesController(UserTypesRepository userTypesRepo)
        {
            _userTypesRepository = userTypesRepo;
        }

        [HttpGet]
       public IActionResult GetUserTypes()
        {
            var result = _userTypesRepository.GetUserTypes();
            if (result.Count() >= 0)
            {
                return Ok(result);
            }
            else return NotFound("No About");
        }
    }
}
