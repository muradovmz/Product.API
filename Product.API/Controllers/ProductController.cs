using Microsoft.AspNetCore.Mvc;

namespace Product.API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
        ProductRepository repository;
        public ProductController()
        {
            repository = new ProductRepository();
        }

        [HttpGet("list")]
        [ProducesResponseType(typeof(List<Product>), StatusCodes.Status200OK)]
        public IActionResult List()
        {
            return Ok(repository.Products.ToList());
        }

        [HttpGet("{id}")]
        [ProducesResponseType(typeof(Product), StatusCodes.Status200OK)]
        public IActionResult ById(int id)
        {
            return Ok(repository.Products.FirstOrDefault(x=>x.Id == id));
        }
    }
}
