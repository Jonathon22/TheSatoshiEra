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
    [Route("api/users")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private UsersRepository _usersRepository;

        public UsersController(UsersRepository usersRepo)
        {
            _usersRepository = usersRepo;
        }

        [HttpGet("{id}")]
        public IActionResult GetUserById(Guid userId)
        {
            var user = _usersRepository.GetById(userId);
            if (user == null)
            {
                return NotFound("No user found.");
            }
            return Ok(user);
        }

        [HttpGet]
        public IActionResult GetAllUsers()
        {
            var result = _usersRepository.GetUsers();
            if (result.Count() >= 0)
            {
                return Ok(result);
            }
            else return NotFound("No users");
        }

        [HttpPost]
        public IActionResult addUser(User newUser)
        {
            if (string.IsNullOrEmpty(newUser.FirstName))
            {
                return BadRequest("First and Last Name Required");
            }
            _usersRepository.Add(newUser);
            return Created($"/api/users/{newUser.id}", newUser);
        }

        [HttpPut("{userId}")]
        public IActionResult UpdateUser(Guid userId, User user)
        {
            var UserToGet = _usersRepository.GetById(userId);

            if (UserToGet == null)
            {
                return NotFound($"{userId} was not found try a different id");
            }
            var userUpdate = _usersRepository.UpdateUser(userId, user);
            return Ok(userUpdate);
        }

        [HttpDelete("{id}")]
        public IActionResult deleteUser(Guid id)
        {
            _usersRepository.Delete(id);

            return Ok();
        }

    }
}
