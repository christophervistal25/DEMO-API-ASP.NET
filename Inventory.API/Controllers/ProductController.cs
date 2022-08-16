using Inventory.API.Contracts;
using Inventory.API.DatabaseContext;
using Inventory.API.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Inventory.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService _productService;
        public ProductController(IProductService productService)
        {
            _productService = productService;
        }

        [HttpGet(template:nameof(GetProducts), Name = nameof(GetProducts))]
        public IActionResult GetProducts()
        {
            var results = _productService.Get();
            return Ok(results);
        }

        [HttpGet]
        public IActionResult GetProduct(int id)
        {
            var result = _productService.Find(id);
            return Ok(result);
        }

        [HttpPost]
        public ActionResult AddProduct([FromBody] Product product)
        {
            _productService.Add(product);
            return CreatedAtAction(nameof(GetProduct), product.Id);
        }

        [HttpPut]
        public ActionResult UpdateProduct([FromBody] Product product, int id)
        {
            _productService.Update(product);
            return CreatedAtAction(nameof(GetProduct), product.Id);
        }

    }
}
