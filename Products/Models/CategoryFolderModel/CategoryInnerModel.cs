using Products.Models.ProductsFolderModel;

namespace Products.Models.CategoryFolderModel
{
    public class CategoryInnerModel
    {
        public int Id { get; set; }

        public string ChildCategoryName { get; set; }

        public int CategoryId { get; set; }
        public CategoryModel Category { get; set; }
        public List<ProductsModel> Products { get; set; }
    }
}
