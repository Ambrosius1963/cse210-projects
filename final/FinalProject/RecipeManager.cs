public class RecipeManager
{
    private List<RecipeBase> recipes;
    private readonly FileHandler fileHandler;

    public RecipeManager(FileHandler fileHandler)
    {
        this.fileHandler = fileHandler;
        recipes = fileHandler.ReadFromFile();
    }

    public void AddRecipe()
    {
        var ui = new UserInterface();
        RecipeBase recipe = null;
        var typeChoice = ui.GetRecipeTypeChoice();
        if (typeChoice.HasValue)
        {
            switch (typeChoice.Value)
            {
                case RecipeType.Appetizer:
                    recipe = new AppetizerRecipe();
                    break;
                case RecipeType.MainCourse:
                    recipe = new MainCourseRecipe();
                    break;
                case RecipeType.Dessert:
                    recipe = new DessertRecipe();
                    break;
            }

            var ingredient = ui.GetIngredient();
            while (ingredient != null)
            {
                recipe.AddIngredient(ingredient);
                ingredient = ui.GetIngredient();
            }

            recipe.Instructions = ui.GetInstructions();

            if (ui.ConfirmSave())
            {
                recipe.Type = typeChoice.Value;
                recipe.Name = ui.GetRecipeName();
                recipes.Add(recipe);
                fileHandler.WriteToFile(recipes);
                Console.WriteLine("Recipe saved successfully!");
            }
        }
    }

    public List<RecipeBase> GetRecipes()
    {
        return recipes;
    }

    public List<RecipeBase> GetRecipesByType(RecipeType type)
    {
        return recipes.Where(r => r.Type == type).ToList();
    }
}