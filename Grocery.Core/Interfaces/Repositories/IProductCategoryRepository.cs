using Grocery.Core.Models;

namespace Grocery.Core.Interfaces.Repositories;

public interface IProductCategoryRepository
{
    public ProductCategory Add(Product product, Category category);
    
    public ProductCategory? GetById(int id);
    
    public ProductCategory Update(Product product, Category category);
    
    public List<ProductCategory> GetAll();
    
    public List<ProductCategory> GetAllByCategoryId(int categoryId);
}