using Microsoft.AspNetCore.Mvc;
using Hexagonal.Features.NotesTags.Domain.Ports.In;
using Hexagonal.Features.NotesTags.Domain.Models;

namespace Hexagonal.Features.NotesTags.Infrastructure
{
    [Route("api/NotesTags")]
    [ApiController]
    public class NotesTagsController : Controller
    {
        private readonly INotesTagsServicePort _service;

        public NotesTagsController(INotesTagsServicePort service)
        {
            _service = service;
        }

        // GET: api/<NotesTagsController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<NotesTagsModel>>> Get()
        {
            return await _service.GetNotesTags();
        }

        // GET api/<NotesTagsController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<NotesTagsModel>> Get(int id)
        {
            NotesTagsModel? notesTagsModel = await _service.GetNotesTagsById(id);

            if (notesTagsModel == null)
            {
                return NotFound($"NotesTags with id {id} not found");
            }

            return notesTagsModel;
        }

        // POST api/<NotesTagsController>
        [HttpPost]
        public async Task<ActionResult<NotesTagsModel>> Post([FromBody] NotesTagsModel NotesTagsModel)
        {
            try
            {
                NotesTagsModel modelSaved = await _service.Create(NotesTagsModel);
                return CreatedAtAction("Get", new { id = modelSaved.Id }, modelSaved);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PATCH api/<NotesTagsController>/5
        [HttpPatch("{id}")]
        public async Task<IActionResult> Patch(int id, [FromBody] NotesTagsModel NotesTagsModel)
        {
            try
            {
                await _service.Update(id, NotesTagsModel);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return NoContent();
        }

        // DELETE api/<NotesTagsController>/5
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
