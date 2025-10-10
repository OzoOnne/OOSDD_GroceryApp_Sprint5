using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using Grocery.Core.Interfaces.Services;
using Grocery.Core.Models;

namespace Grocery.App.ViewModels;

public partial class ProductCategoriesViewModel : BaseViewModel
{
    private readonly IProductCategoryService _productCategoryService;
    private readonly IProductService _productService;

    public ObservableCollection<Product> ProductCategories { get; set; } = [];
    public ObservableCollection<Product> AvailableCategories { get; set; } = [];
    
    private string _searchText = "";
    
    [ObservableProperty]
    private Category category = new(0, "None");
    
    public ProductCategoriesViewModel(IProductCategoryService productCategoryRepository, IProductService productService)
    {
        _productCategoryService = productCategoryRepository;
        _productService = productService;
    }
    
    [RelayCommand]
    public async Task AddProductToCategory(Product product)
    {
        if (product == null)
            return;
        
        _productCategoryService.Add(product, category);
        
        ProductCategories.Add(product);
        
        AvailableCategories.Remove(product);
    }
    
    [RelayCommand]
    public async Task PerformSearch(string searchText)
    {
        _searchText = searchText;
        
        LoadAvailableProducts();
    }
    
    partial void OnCategoryChanged(Category value)
    {
        LoadProductCategoriesByCategory(value);
        LoadAvailableProducts();
    }

    public void LoadProductCategoriesByCategory(Category category)
    {
        ProductCategories.Clear();
        
        foreach(ProductCategory productCategory in _productCategoryService.GetAllByCategoryId(category.Id))
        {
            Product product = _productService.Get(productCategory.ProductId);
            
            ProductCategories.Add(product);
        }
    }
    
    public void LoadAvailableProducts()
    {
        AvailableCategories.Clear();
        foreach (Product product in _productService.GetAll())
        {
            if (!ProductCategories.Any(p => p.Id == product.Id) && product.Name.ToLower().Contains(_searchText))
            {
                AvailableCategories.Add(product);
            }
        }
    }
}