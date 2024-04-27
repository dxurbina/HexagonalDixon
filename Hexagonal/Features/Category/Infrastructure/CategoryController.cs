using Microsoft.AspNetCore.Mvc;
using Hexagonal.Features.Category.Domain.Ports.In;
using Hexagonal.Features.Category.Domain.Models;

namespace Hexagonal.Features.Category.Infrastructure
{
    [Route("api/Categories")]
    [ApiController]
    public class CategoryController : Controller
    {
        private readonly ICategoryServicePort _service;

        public CategoryController(ICategoryServicePort service)
        {
            _service = service;
        }

        // GET: api/<CategoryController>
        [HttpGet]
        public async Task<ActionResult<IEnumerable<CategoryModel>>> Get()
        {
            return await _service.GetCategories();
        }

        // GET api/<CategoryController>/5
        [HttpGet("{id}")]
        public async Task<ActionResult<CategoryModel>> Get(int id)
        {
            CategoryModel? categoryModel = await _service.GetCategoryById(id);

            if (categoryModel == null)
            {
                return NotFound($"Category with id {id} not found");
            }

            return categoryModel;
        }

        // POST api/<CategoryController>
        [HttpPost]
        public async Task<ActionResult<CategoryModel>> Post([FromBody] CategoryModel CategoryModel)
        {
            try
            {
                CategoryModel modelSaved = await _service.Create(CategoryModel);
                return CreatedAtAction("Get", new { id = modelSaved.Id }, modelSaved);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PATCH api/<CategoryController>/5
        [HttpPatch("{id}")]
        public async Task<IActionResult> Patch(int id, [FromBody] CategoryModel CategoryModel)
        {
            try
            {
                await _service.Update(id, CategoryModel);
            }
            catch (Exception ex)
            {
                return BadRequest(ex.Message);
            }

            return NoContent();
        }

        // DELETE api/<CategoryController>/5
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
