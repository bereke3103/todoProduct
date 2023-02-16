using Products.Models.ProductsFolderModel;

namespace Products.Service.Interface
{
    public interface IProduct
    {
        public Task<List<ProductsModel>> GetAllProducts();
        public Task<ProductsModel> CreateProduct(ProductsModelDto product);

        public Task<ProductsModel> GetProductById(int id);
    }
}
