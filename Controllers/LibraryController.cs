using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TheSatoshiEra.DataAccess;
using TheSatoshiEra.Models;
using Dapper;

namespace TheSatoshiEra.Controllers
{
    [Route("api/Library")]
    [ApiController]
    public class LibraryController : ControllerBase
    {
        private LibraryRepository _libraryRepository;

        public LibraryController(LibraryRepository libraryRepo)
        {
            _libraryRepository = libraryRepo;
        }

        [HttpGet]
        public IActionResult GetLibrary()
        {
            var result = _libraryRepository.GetLibrary();
            if (result.Count() >= 0)
            {
                return Ok(result);
            }
            else return NotFound("No entries found");
        }

        [HttpDelete("{id}")]
        public IActionResult deleteUser(Guid id)
        {
            _libraryRepository.Delete(id);

            return Ok();
        }

        [HttpPost]
        public IActionResult AddLibrary(Library newLibrary)
        {
            if (string.IsNullOrEmpty(newLibrary.link))
            {
                return BadRequest("First and Last Name Required");
            }
            _libraryRepository.Add(newLibrary);
            return Created($"/api/users/{newLibrary.id}", newLibrary);
        }

        [HttpPut("{LibraryId}")]
        public IActionResult UpdateLibrary(Guid LibraryId, Library library)
        {
            var LibraryEntryToGet = _libraryRepository.GetById(LibraryId);

            if (LibraryEntryToGet == null)
            {
                return NotFound($"{LibraryId} was not found try a different id");
            }
            var libraryUpdated = _libraryRepository.UpdateLibrary(LibraryId, library);
            return Ok(libraryUpdated);
        }

    }
 
}
