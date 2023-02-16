using Microsoft.EntityFrameworkCore;
using Products.Data;
using Products.Models.CategoryFolderModel;
using Products.Service.Interface;

namespace Products.Service
{
    public class CategoryInnerService : ICategoryInner
    {
        private readonly DataContext data;

        public CategoryInnerService(DataContext data)
        {
            this.data = data;
        }
        public async Task<CategoryInnerModel> CreateInnerCategory(CategoryInnerModelDto category)
        {
            var findId = await data.categoryModels.FirstOrDefaultAsync(i => i.Id == category.CategoryId);

            if (findId == null)
            {
                throw new Exception("Такой категории не существует");
            }
            var newCreateInner = new CategoryInnerModel()
            {
                ChildCategoryName= category.ChildCategoryName,
                CategoryId= category.CategoryId,
            };

            data.Add(newCreateInner);
            await data.SaveChangesAsync();

            return newCreateInner;
        }

        public async Task<List<CategoryInnerModel>> GetAllInner()
        {
            var response = await data.categoryInnerModels.Include(p=> p.Products).ToListAsync();
            return response;
        }

        public async Task<CategoryInnerModel> GetCategoryInnerById(int id)
        {
            var findId = await data.categoryInnerModels.Include(p=> p.Products).FirstOrDefaultAsync(i=> i.Id == id);

            return findId;


        }
    }
}
