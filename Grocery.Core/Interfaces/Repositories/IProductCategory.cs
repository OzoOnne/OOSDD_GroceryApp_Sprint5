using Grocery.Core.Models;

namespace Grocery.Core.Interfaces.Repositories;

public interface IProductCategory
{
    public ProductCategory Add(Product product, Category category);
    
    public ProductCategory? GetById(int id);
    
    public ProductCategory Update(Product product, Category category);
    
    public List<ProductCategory> getAll();
    
    public List<ProductCategory> getAllByCategoryId(int categoryId);
}