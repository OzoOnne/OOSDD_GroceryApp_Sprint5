using CommunityToolkit.Mvvm.ComponentModel;

namespace Grocery.Core.Models;

public partial class ProductCategory : Model
{
    [ObservableProperty] public int productId, categoryId;
    
    public ProductCategory(int id, string name, int productId, int categoryId) : base(id, name)
    {
        ProductId = productId;
        CategoryId = categoryId;
    }
}