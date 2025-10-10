using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grocery.App.ViewModels;

namespace Grocery.App.Views;

public partial class ProductCategoriesView : ContentView
{
    public ProductCategoriesView(ProductCategoriesViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}