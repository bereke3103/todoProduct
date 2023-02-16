using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Products.Models.ProductsFolderModel;
using Products.Service.Interface;

namespace Products.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProduct product;

        public ProductController(IProduct product)
        {
            this.product = product;
        }

        [HttpPost("/product")]

        public async Task<ActionResult<ProductsModel>> CreateProduct(ProductsModelDto dto)
        {
            var response = await product.CreateProduct(dto);

            return Ok(response);
        }

        [HttpGet("/getProductById/{id}")]

        public async Task<ActionResult<ProductsModel>> GetProductById(int id)
        {
            var response = await product.GetProductById(id);

            return Ok(response);
        }

        [HttpGet("/getProducts")]

        public async Task<ActionResult<List<ProductsModel>>> GetAllProducts()
        {
            var response = await product.GetAllProducts();

            return Ok(response);
        }
    }
}
