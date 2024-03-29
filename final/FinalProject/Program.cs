using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public enum RecipeType
{
    Appetizer,
    MainCourse,
    Dessert,
    All
}

public class Program
{
    public static void Main(string[] args)
    {
        var fileHandler = new FileHandler();
        var manager = new RecipeManager(fileHandler);
        var ui = new UserInterface();
        var viewer = new RecipeViewer();

        while (true)
        {
            ui.DisplayMenu();
            var choice = ui.GetUserInput();

            switch (choice)
            {
                case "1":
                    var typeChoice = ui.GetRecipeTypeChoice();
                    if (typeChoice.HasValue)
                    {
                        var recipes = typeChoice.Value == RecipeType.All ? manager.GetRecipes() : manager.GetRecipesByType(typeChoice.Value);
                        viewer.DisplayAllRecipes(recipes);
                    }
                    break;
                case "2":
                    manager.AddRecipe();
                    break;
                case "3":
                    return;
                default:
                    Console.WriteLine("Invalid choice.");
                    break;
            }
            Console.WriteLine("Press any key to return to the main menu.");
            Console.ReadKey();
            Console.Clear();
        }
    }
}