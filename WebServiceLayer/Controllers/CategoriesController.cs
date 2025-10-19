using Microsoft.AspNetCore.Mvc;
using DataServiceLayer;
using DataServiceLayer.DTOs;

namespace WebServiceLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly DataService _dataService;

        public CategoriesController()
        {
            _dataService = new DataService();
        }

        // GET: api/categories
        [HttpGet]
        public ActionResult<IEnumerable<CategoryDto>> GetCategories()
        {
            var categories = _dataService.GetCategories();
            return Ok(categories);
        }

        // GET: api/categories/5
        [HttpGet("{id}")]
        public ActionResult<CategoryDto> GetCategory(int id)
        {
            var category = _dataService.GetCategory(id);
            if (category == null)
            {
                return NotFound();
            }
            return Ok(category);
        }

        // POST: api/categories
        [HttpPost]
        public ActionResult<CategoryDto> PostCategory(CategoryDto categoryDto)
        {
            try
            {
                var category = _dataService.CreateCategory(categoryDto.Name!, categoryDto.Description);
                return CreatedAtAction(nameof(GetCategory), new { id = category.Id }, category);
            }
            catch (ArgumentException ex)
            {
                return BadRequest(ex.Message);
            }
        }

        // PUT: api/categories/5
        [HttpPut("{id}")]
        public IActionResult PutCategory(int id, CategoryDto categoryDto)
        {
            var success = _dataService.UpdateCategory(id, categoryDto.Name!, categoryDto.Description);
            if (!success)
            {
                return NotFound();
            }
            return Ok();
        }

        // DELETE: api/categories/5
        [HttpDelete("{id}")]
        public IActionResult DeleteCategory(int id)
        {
            var success = _dataService.DeleteCategory(id);
            if (!success)
            {
                return NotFound();
            }
            return Ok();
        }
    }
}