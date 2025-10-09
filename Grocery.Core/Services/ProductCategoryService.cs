using Grocery.Core.Interfaces.Repositories;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;

namespace Grocery.Core.Services;

public class ProductCategoryService : IProductCategoryService
{
    private readonly IProductCategoryRepository _productCategoryRepository;

    public ProductCategoryService(IProductCategoryRepository productCategoryRepository)
    {
        _productCategoryRepository = productCategoryRepository;
    }
    

    public ProductCategory Add(Product product, Category category)
    {
        return _productCategoryRepository.Add(product, category);
    }

    public ProductCategory? GetById(int id)
    {
        return _productCategoryRepository.GetById(id);
    }

    public List<ProductCategory> GetAll()
    {
        return _productCategoryRepository.GetAll();
    }

    public List<ProductCategory> GetAllByCategoryId(int categoryId)
    {
        return _productCategoryRepository.GetAllByCategoryId(categoryId);
    }
}