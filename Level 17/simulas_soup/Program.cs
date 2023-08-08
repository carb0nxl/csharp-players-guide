Console.WriteLine("Welcome to Simula's Kitchen");
Console.WriteLine("You can create your own soup using" +
                  "\n your own food TYPE, INGREDIENT, and SEASONING.\n");

Console.WriteLine("Food TYPE: Soup | Stew | Gumbo");
Console.Write($"Choose your food BASE:");
var userFoodBase = Console.ReadLine();

Console.WriteLine("Main INGREDIENT: Mushrooms | Chicken | Carrots | Potatoes");
Console.Write($"Choose your INGREDIENT:");
var userIngredient = Console.ReadLine();

Console.WriteLine("SEASONING: Spicy | Salty | Sweet");
Console.Write($"Choose your SEASONING:");
var userSeasoning = Console.ReadLine();

(FoodBase foodbase, MainIngredient ingredient, Seasoning seasoning) =
    playerCreation => (userFoodBase, userIngredient, userSeasoning);


enum FoodBase { Soup, Stew, Gumbo };
enum MainIngredient { Mushrooms, Chicken, Carrots, Potatoes };
enum Seasoning { Spicy, Salty, Sweet };