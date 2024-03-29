using System;

public class UserInterface
{
    public void DisplayMenu()
    {
        Console.Clear();
        Console.WriteLine("\n~~~  M.A.D. For Food ~~~\n------------------------\nMain, Appetizer, Dessert\n------------------------\n");
        Console.WriteLine("1. Find Recipe");
        Console.WriteLine("2. Add Recipe");
        Console.WriteLine("3. Exit");
    }

    public string GetUserInput()
    {
        Console.Write("Enter your choice: ");
        return Console.ReadLine();
    }

    public RecipeType? GetRecipeTypeChoice()
    {
        Console.Clear();
        Console.WriteLine("Choose Recipe Type:");
        Console.WriteLine("1. Appetizer");
        Console.WriteLine("2. Main Course");
        Console.WriteLine("3. Dessert");
        Console.WriteLine("4. All Recipes");
        var choice = Console.ReadLine();
        switch (choice)
        {
            case "1":
                return RecipeType.Appetizer;
            case "2":
                return RecipeType.MainCourse;
            case "3":
                return RecipeType.Dessert;
            case "4":
                return null;  // Figure out how to print All recipes
            default:
                Console.WriteLine("Invalid choice.");
                return GetRecipeTypeChoice();
        }
    }

    public string GetRecipeName()
    {
        Console.Write("\nEnter Recipe Name: ");
        return Console.ReadLine();
    }

    public Ingredient GetIngredient()
    {
        Console.Write("\nEnter Ingredient Name (press Enter to finish): ");
        var name = Console.ReadLine();
        if (string.IsNullOrEmpty(name))
            return null;

        Console.Write("Enter Quantity: ");
        var quantity = Console.ReadLine(); //double.Parse(?

        Console.Write("Enter Unit: ");
        var unit = Console.ReadLine();

        return new Ingredient { Name = name, Quantity = quantity, Unit = unit };
    }

    public string GetInstructions()
    {
        Console.WriteLine("\nEnter Instructions:");
        return Console.ReadLine();
    }

    public bool ConfirmSave()
    {
        Console.Write("\nDo you want to save the recipe? (yes/no): ");
        var choice = Console.ReadLine().ToLower();
        return choice == "yes";
    }
}