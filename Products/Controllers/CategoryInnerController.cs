using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Products.Models.CategoryFolderModel;
using Products.Service.Interface;

namespace Products.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryInnerController : ControllerBase
    {
        private readonly ICategoryInner inner;

        public CategoryInnerController(ICategoryInner inner)
        {
            this.inner = inner;
        }

        [HttpPost("/createInnerCategory")]

        public async Task<ActionResult<CategoryInnerModel>> CreateInnerCategory(CategoryInnerModelDto dto)
        {
            var response = await inner.CreateInnerCategory(dto);

            return Ok(response);
        }

        [HttpGet("/getInnerCategory/{id}")]

        public async Task<ActionResult<CategoryInnerModel>> GetCategoryInnerById(int id)
        {
            var response = await inner.GetCategoryInnerById(id);

            return Ok(response);
        }

        [HttpGet("/getAllInnerCategory")]

        public async Task<ActionResult<List<CategoryInnerModel>>> GetAllCategoryInner()
        {
            var response = await inner.GetAllInner();

            return Ok(response);
        }
    }
}
