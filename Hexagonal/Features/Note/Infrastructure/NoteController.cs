using Microsoft.AspNetCore.Mvc;
using Hexagonal.Features.Note.Domain.Ports.In;
using Hexagonal.Features.Note.Domain.Models;

namespace Hexagonal.Features.Note.Infrastructure
{
    [Route("api/Notes")]
    [ApiController]
    public class NoteController : Controller
    {
        private readonly INoteServicePort _service;

        public NoteController(INoteServicePort service)
        {
            _service = service;
        }

        // GET: api/<NoteController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NoteModel>>> Get()
        {
            return await _service.GetNotes();
        }

        // GET api/<NoteController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NoteModel>> Get(int id)
        {
            NoteModel? noteModel = await _service.GetNoteById(id);

            if (noteModel == null)
            {
                return NotFound($"Note with id {id} not found");
            }

            return noteModel;
        }

        // POST api/<NoteController>
        [HttpPost]
        public async Task<ActionResult<NoteModel>> Post([FromBody] NoteModel NoteModel)
        {
            try
            {
                NoteModel modelSaved = await _service.Create(NoteModel);
                return CreatedAtAction("Get", new { id = modelSaved.Id }, modelSaved);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PATCH api/<NoteController>/5
        [HttpPatch("{id}")]
        public async Task<IActionResult> Patch(int id, [FromBody] NoteModel NoteModel)
        {
            try
            {
                await _service.Update(id, NoteModel);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return NoContent();
        }

        // DELETE api/<NoteController>/5
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
