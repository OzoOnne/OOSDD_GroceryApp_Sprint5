using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;

namespace Grocery.Core.Services;

public class CategoryService : ICategoryService
{
    private readonly ICategoryRepository _categoryRepository;

    public CategoryService(ICategoryRepository categoryRepository)
    {
        _categoryRepository = categoryRepository;
    }
    
    public Category Add(Category item)
    {
        return _categoryRepository.Add(item);
    }

    public Category? GetById(int id)
    {
        return _categoryRepository.GetById(id);
    }

    public List<Category> GetAll()
    {
        return _categoryRepository.GetAll();
    }
}