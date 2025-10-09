using Grocery.Core.Models;
using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.Input;
using Grocery.Core.Interfaces.Services;

namespace Grocery.App.ViewModels;

public partial class CategoriesViewModel : BaseViewModel
{
    private readonly ICategoryService _categoryService;
    public ObservableCollection<Category> CategoryList { get; set; }

    public CategoriesViewModel(ICategoryService categoryService)
    {
        _categoryService = categoryService;
        CategoryList = [];
        foreach (var category in _categoryService.GetAll())
            CategoryList.Add(category);
    }
    
    [RelayCommand]
    public async Task SelectCategoryList(Category category)
    {
        Dictionary<string, object> paramater = new() { { nameof(Category), category } };
        await Shell.Current.GoToAsync("ProductCategoriesView");
    }
}