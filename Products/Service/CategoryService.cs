using Microsoft.EntityFrameworkCore;
using Products.Data;
using Products.Models.CategoryFolderModel;
using Products.Service.Interface;

namespace Products.Service
{
    public class CategoryService : ICategory
    {
        private readonly DataContext data;

        public CategoryService(DataContext data)
        {
            this.data = data;
        }
        public async Task<CategoryModel> CreateCategory(CategoryModelDto category)
        {
            var createCategory = new CategoryModel()
            {
                CategoryName = category.CategoryName,
                CategoryDescription = category.CategoryDescription,
            };

            data.Add(createCategory);
            await data.SaveChangesAsync();

            return createCategory;

        }

        public async Task<List<CategoryModel>> GetAll()
        {
            var findCategory = await data.categoryModels.Include(c=> c.ChildCategories).ToListAsync();

            return findCategory;
        }

        public async Task<CategoryModel> GetCategoryById(int id)
        {
            var findById = await data.categoryModels.Include(i=> i.ChildCategories).FirstOrDefaultAsync(i=> i.Id == id);

            return findById;
        }
    }
}
