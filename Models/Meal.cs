namespace Meals_App.Models;

public record Meal(
    string Name,
    string Description,
    DateTime StartDateTime,
    DateTime EndDateTime,
    Uri Image,
    List<string> Contents,
    string Dish
    );
