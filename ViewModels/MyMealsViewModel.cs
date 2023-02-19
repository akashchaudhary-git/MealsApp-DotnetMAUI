using CommunityToolkit.Mvvm.ComponentModel;
using Meals_App.Models;

namespace Meals_App.ViewModels
{
    public partial class MyMealsViewModel : CommunityToolkit.Mvvm.ComponentModel.ObservableObject
    {
        [ObservableProperty]
        List<Meal> meals;

        public MyMealsViewModel()
        {
            LoadMeal();
        }

        private void LoadMeal()
        {
            Meals = new()
            {
            new Meal(
                Name:"Vegetable Sandwich",
                Description:"A healthy bite to start a day",
                StartDateTime:DateTime.UtcNow.AddDays(1),
                EndDateTime:DateTime.UtcNow.AddDays(1).AddHours(2),
                Image:new Uri("https://www.masala.tv/wp-content/uploads/2020/10/Veg-Sandwichh.jpg"),
                Contents:new List<string> {"Whole wheat bread", "Tomato", "Lettuce", "Potato","Mint Chutney" },
                Dish:"Veg"
                ),
            new Meal(
                Name:"Idli",
                Description:"Love from south! enjoy the rice cakes the most popular breakfast of Southern India ❤",
                StartDateTime:DateTime.UtcNow,
                EndDateTime:DateTime.UtcNow.AddHours(4),
                Image:new Uri("https://www.lacademie.com/wp-content/uploads/2022/03/indian-breakfast-recipes.jpg"),
                Contents:new List<string> {"Rice cakes", "Tomato chuttney", "Ghee","Cocunut chutney" },
                Dish:"Veg"
                )
            };
        }
    }
}
