using Products.Models.CategoryFolderModel;

namespace Products.Service.Interface
{
    public interface ICategory
    {
        public Task<List<CategoryModel>> GetAll();

        public Task<CategoryModel> CreateCategory(CategoryModelDto category);

        public Task<CategoryModel> GetCategoryById(int id);
    }
}
