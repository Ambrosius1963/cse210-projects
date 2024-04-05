public abstract class RecipeBase
{
    public string Name { get; set; }
    public List<Ingredient> Ingredients { get; set; }
    public string Instructions { get; set; }
    public RecipeType Type { get; set; }

    public RecipeBase()
    {
        Ingredients = new List<Ingredient>();
    }

    public void AddIngredient(Ingredient ingredient)
    {
        Ingredients.Add(ingredient);
    }

    public virtual void Cook()
    {
        Console.WriteLine("Cook the recipe");
    }

    public void  PrintRecipeName()
    {
        Console.WriteLine($"{Name}");
    }
    public void PrintRecipe()
    {
        Console.WriteLine($"{Name}\n-----------------");
        Console.WriteLine($"Type: {Type}");
        Console.WriteLine("\nIngredients:");
        foreach (var ingredient in Ingredients)
        {
            Console.WriteLine($"- {ingredient}");
        }
        Console.WriteLine("\nInstructions:");
        Console.WriteLine(Instructions);
    }

    // public void SaveToFile()
    // {
    //     using (StreamWriter writer = new StreamWriter("recipes.csv", true))
    //     {
    //         writer.WriteLine($"{Type},{Name},{string.Join(";", Ingredients.Select(i => $"{i.Name}:{i.Quantity}:{i.Unit}"))},{Instructions}");
    //     }
    // }
}