using Microsoft.AspNetCore.Mvc;
using Hexagonal.Features.User.Domain.Ports.In;
using Hexagonal.Features.User.Domain.Models;
using Hexagonal.Features.User.Domain;

namespace Hexagonal.Features.User.Infrastructure
{
    [Route("api/Users")]
    [ApiController]
    public class UserController : Controller
    {
        private readonly IUserServicePort _service;

        public UserController(IUserServicePort service)
        {
            _service = service;
        }

        // GET: api/<UserController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<UserModel>>> Get()
        {
            return await _service.GetUsers();
        }

        // GET api/<UserController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<UserModel>> Get(int id)
        {
            UserModel? userModel = await _service.GetUserById(id);

            if (userModel == null)
            {
                return NotFound($"User with id {id} not found");
            }

            return userModel;
        }


        // POST api/<UserController>
        [HttpPost]
        public async Task<ActionResult<UserModel>> Post([FromBody] UserModel userModel)
        {
            try
            {
                UserModel userModelSaved = await _service.Create(userModel);
                return CreatedAtAction("Get", new { id = userModelSaved.Id }, userModelSaved);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PATCH api/<UserController>/5
        [HttpPatch("{id}")]
        public async Task<IActionResult> Patch(int id, UserModel userModel)
        {
            try
            {
                await _service.Update(id, userModel);
            }
            catch (UserNotFoundException ex)
            {
                return NotFound(ex.Message);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return NoContent();
        }

        // DELETE api/<UserController>/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _service.Delete(id);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return NoContent();
        }


    }
}
