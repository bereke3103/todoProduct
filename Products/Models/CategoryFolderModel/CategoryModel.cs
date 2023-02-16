namespace Products.Models.CategoryFolderModel
{
    public class CategoryModel
    {
        public int Id { get; set; }

        public string CategoryName { get; set; }

        public string CategoryDescription { get; set; }

        public List<CategoryInnerModel> ChildCategories { get; set; }

    }
}
