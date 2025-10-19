using Microsoft.AspNetCore.Mvc;
using DataServiceLayer;
using DataServiceLayer.DTOs;

namespace WebServiceLayer.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly DataService _dataService;

        public ProductsController()
        {
            _dataService = new DataService();
        }

        // GET: api/products/5
        [HttpGet("{id}")]
        public ActionResult<ProductDto> GetProduct(int id)
        {
            var product = _dataService.GetProduct(id);
            if (product == null)
            {
                return NotFound();
            }
            return Ok(product);
        }

        // GET: api/products/category/5
        [HttpGet("category/{categoryId}")]
        public ActionResult<IEnumerable<ProductDto>> GetProductsByCategory(int categoryId)
        {
            var products = _dataService.GetProductByCategory(categoryId);
            if (products == null || !products.Any())
            {
                return NotFound(new List<ProductDto>());
            }
            return Ok(products);
        }

        // GET: api/products/name/substring
        [HttpGet("name/{substring}")]
        public ActionResult<IEnumerable<ProductNameWithCategoryDto>> GetProductsByName(string substring)
        {
            var products = _dataService.GetProductByName(substring);
            if (products == null || !products.Any())
            {
                return NotFound(new List<ProductNameWithCategoryDto>());
            }
            return Ok(products);
        }
    }
}