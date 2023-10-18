using App_Views.Models;

namespace App_Views.Pages;

public partial class ListView : ContentPage
{
    public ListView()
    {
        InitializeComponent();


        var items = new List<Models.CollectionView>
        {
            new Models.CollectionView { Title = "Techtorium", Description = "The Greatest School" },
            new Models.CollectionView { Title = "Techtorium", Description = "The Greatest School" },
            new Models.CollectionView { Title = "Techtorium", Description = "The Greatest School" },
            new Models.CollectionView { Title = "Techtorium", Description = "The Greatest School" },
            new Models.CollectionView { Title = "Techtorium", Description = "The Greatest School" }
        };
        listView.ItemsSource = items;
    }
}