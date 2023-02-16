using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Products.Models.CategoryFolderModel;
using Products.Service.Interface;

namespace Products.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        private readonly ICategory category;

        public CategoryController(ICategory category)
        {
            this.category = category;
        }

        [HttpPost("/createCategory")]
        public async Task<ActionResult<CategoryModel>> CreateCategory(CategoryModelDto dto)
        {
            var respons = await category.CreateCategory(dto);

            return Ok(respons);
        }

        [HttpGet("/getCategoryById/{id}")]

        public async Task<ActionResult<CategoryModel>> GetCategoryById(int id)
        {
            var response = await category.GetCategoryById(id);

            return Ok(response);
        }

        [HttpGet("/getAllCategory")]
        public async Task<ActionResult<List<CategoryModel>>> GetAll()
        {
            var response = await category.GetAll();

            return Ok(response);
        }
    }
}
