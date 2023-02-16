using Microsoft.EntityFrameworkCore;
using Products.Data;
using Products.Models.ProductsFolderModel;
using Products.Service.Interface;

namespace Products.Service
{
    public class ProductService : IProduct
    {
        private readonly DataContext data;

        public ProductService(DataContext data)
        {
            this.data = data;
        }
        public async Task<ProductsModel> CreateProduct(ProductsModelDto product)
        {
            var finId = await data.categoryInnerModels.FirstOrDefaultAsync(i => i.Id == product.CategoryInnerId);

            if (finId == null)
            {
                throw new Exception("Такой подкатегории не существует");
            }

            var createProduct = new ProductsModel()
            {
                CategoryInnerId= product.CategoryInnerId,
                ProductName= product.ProductName,
                ProductDescription= product.ProductDescription,
            };

            data.Add(createProduct);
            await data.SaveChangesAsync();

            return createProduct;
        }

        public async Task<List<ProductsModel>> GetAllProducts()
        {
            var response = await data.productsModels.ToListAsync();

            return response;
        }

        public async Task<ProductsModel> GetProductById(int id)
        {
            var findById = data.productsModels.FirstOrDefault(p=> p.Id == id);

            return findById;
        }
    }
}
