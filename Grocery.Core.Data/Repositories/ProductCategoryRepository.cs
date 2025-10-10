using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Models;

namespace Grocery.Core.Data.Repositories;

public class ProductCategoryRepository : IProductCategoryRepository
{
    private readonly List<ProductCategory> _productCategories;

    public ProductCategoryRepository()
    {
        _productCategories =
        [
            new ProductCategory(1, "Zuivel", 1, 2),
            new ProductCategory(2, "Zuivel", 2, 2),
            new ProductCategory(3, "Bakkerij", 3, 3)
        ];
    }
    
    public ProductCategory Add(Product product, Category category)
    {
        int id = _productCategories.Max(x => x.Id) + 1;
        
        ProductCategory productCategory = new ProductCategory(id,category.Name, product.Id,category.Id);
        _productCategories.Add(productCategory);
        
        return GetById(productCategory.Id);
    }

    public ProductCategory? GetById(int id)
    {
        return _productCategories.FirstOrDefault(x => x.Id == id);
    }
    
    public List<ProductCategory> GetAll()
    {
        return _productCategories;
    }

    public List<ProductCategory> GetAllByCategoryId(int categoryId)
    {
        return _productCategories.Where(x => x.CategoryId == categoryId).ToList();
    }
}