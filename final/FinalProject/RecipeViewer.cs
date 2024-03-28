using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

public class RecipeViewer
{
    public void DisplayRecipe(RecipeBase recipe)
    {
        recipe.PrintRecipe();
        Console.Write("Do you want a shopping list for this recipe? (yes/no): ");
        var choice = Console.ReadLine().ToLower();
        if (choice == "yes")
        {
            GenerateShoppingList(recipe);
        }
    }

    public void DisplayAllRecipes(List<RecipeBase> recipes)
    {
        foreach (var recipe in recipes)
        {
            recipe.PrintRecipe();
            Console.WriteLine("------------------------------");
        }
        Console.WriteLine("Choose a recipe to view:");
        var name = Console.ReadLine();
        var selectedRecipe = recipes.FirstOrDefault(r => r.Name.Equals(name, StringComparison.OrdinalIgnoreCase));
        if (selectedRecipe != null)
        {
            DisplayRecipe(selectedRecipe);
        }
        else
        {
            Console.WriteLine("Recipe not found.");
        }
    }

    private void GenerateShoppingList(RecipeBase recipe)
    {
        using (StreamWriter writer = new StreamWriter($"{recipe.Name}_shoppingList.txt"))
        {
            foreach (var ingredient in recipe.Ingredients)
            {
                writer.WriteLine($"{ingredient.Quantity} {ingredient.Unit} of {ingredient.Name}");
            }
        }
        Console.WriteLine($"Shopping list for {recipe.Name} has been saved as {recipe.Name}_shoppingList.txt");
    }
}