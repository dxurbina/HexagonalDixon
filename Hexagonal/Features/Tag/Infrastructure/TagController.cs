using Microsoft.AspNetCore.Mvc;
using Hexagonal.Features.Tag.Domain.Ports.In;
using Hexagonal.Features.Tag.Domain.Models;

namespace Hexagonal.Features.Tag.Infrastructure
{
    [Route("api/Tags")]
    [ApiController]
    public class TagController : Controller
    {
        private readonly ITagServicePort _service;

        public TagController(ITagServicePort service)
        {
            _service = service;
        }

        // GET: api/<TagController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<TagModel>>> Get()
        {
            return await _service.GetTags();
        }

        // GET api/<TagController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<TagModel>> Get(int id)
        {
            TagModel? tagModel = await _service.GetTagById(id);

            if (tagModel == null)
            {
                return NotFound($"Tag with id {id} not found");
            }

            return tagModel;
        }

        // POST api/<TagController>
        [HttpPost]
        public async Task<ActionResult<TagModel>> Post([FromBody] TagModel TagModel)
        {
            try
            {
                TagModel modelSaved = await _service.Create(TagModel);
                return CreatedAtAction("Get", new { id = modelSaved.Id }, modelSaved);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PATCH api/<TagController>/5
        [HttpPatch("{id}")]
        public async Task<IActionResult> Patch(int id, [FromBody] TagModel TagModel)
        {
            try
            {
                await _service.Update(id, TagModel);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return NoContent();
        }

        // DELETE api/<TagController>/5
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
