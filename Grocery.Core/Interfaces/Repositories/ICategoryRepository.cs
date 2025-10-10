using Grocery.Core.Models;

namespace Grocery.Core.Interfaces.Repositories;

public interface ICategoryRepository
{
    public Category Add(Category item);
    
    public Category? Delete(Category item);
    
    public Category? GetById(int id);
    
    public List<Category>  GetAll();
    
}