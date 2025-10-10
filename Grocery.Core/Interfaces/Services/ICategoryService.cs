using Grocery.Core.Models;

namespace Grocery.Core.Interfaces.Services;

public interface ICategoryService
{
    public Category Add(Category item);
    
    public Category? GetById(int id);

    public List<Category> GetAll();
}