using Products.Models.CategoryFolderModel;

namespace Products.Service.Interface
{
    public interface ICategoryInner
    {
        public Task<List<CategoryInnerModel>> GetAllInner();
        public Task<CategoryInnerModel> CreateInnerCategory (CategoryInnerModelDto category);

        public Task<CategoryInnerModel> GetCategoryInnerById(int id);
    }
}
