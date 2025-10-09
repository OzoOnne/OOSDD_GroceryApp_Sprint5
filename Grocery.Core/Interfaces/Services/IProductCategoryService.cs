using Grocery.Core.Models;

namespace Grocery.Core.Interfaces.Services;

public interface IProductCategoryService
{
    public ProductCategory Add(ProductCategory item);
    
    public ProductCategory? GetById(int id);
    
    public List<ProductCategory> GetAll();
    
    public List<ProductCategory> GetAllByCategoryId(int categoryId);
    
}