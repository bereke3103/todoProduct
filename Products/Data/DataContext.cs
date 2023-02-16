using Microsoft.EntityFrameworkCore;
using Products.Models.CategoryFolderModel;
using Products.Models.ProductsFolderModel;

namespace Products.Data
{
    public class DataContext : DbContext
    {
        public DataContext(DbContextOptions<DataContext> options) : base(options)
        {

        }

        public DbSet<CategoryModel> categoryModels { get; set; }
        public DbSet<CategoryInnerModel> categoryInnerModels { get; set; }

        public DbSet<ProductsModel> productsModels { get; set; }
    }
}
