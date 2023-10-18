using App_Views.Models;
using App_Views.Pages;
using Microsoft.Maui.Controls;


namespace App_Views.Pages;

public partial class CarouselView : ContentPage
{
	public CarouselView()
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
        carouselView.ItemsSource = items;


    }
}