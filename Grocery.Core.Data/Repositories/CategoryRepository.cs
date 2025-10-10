using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Models;

namespace Grocery.Core.Data.Repositories;

public class CategoryRepository : ICategoryRepository
{
    private readonly List<Category> _categories;

    public CategoryRepository()
    {
        _categories =
        [
            new Category(1, "Bakkerij"),
            new Category(2, "Zuivel"),
            new Category(3, "AGF")
        ];
    }
    
    public Category Add(Category item)
    {
        int id = _categories.Max(x => x.Id) + 1;
        item.Id = id;
        _categories.Add(item);
        return GetById(item.Id);
    }

    public Category? Delete(Category item)
    {
        _categories.Remove(item);
        return null;
    }

    public Category? GetById(int id)
    {
        Category? category = _categories.FirstOrDefault(x => x.Id == id);
        return category;
    }

    public List<Category> GetAll()
    {
        return _categories; 
    }
}