using Products.Models.CategoryFolderModel;

namespace Products.Models.ProductsFolderModel
{
    public class ProductsModel
    {
        public int Id { get; set; }

        public string ProductName { get; set; }

        public string ProductDescription { get; set; }

        public int CategoryInnerId { get; set; }
        public CategoryInnerModel CategoryInner { get; set; }
    }
}
