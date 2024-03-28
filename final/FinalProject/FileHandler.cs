using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;


public class FileHandler
{
    public List<RecipeBase> ReadFromFile()
    {
        var recipes = new List<RecipeBase>();
        if (File.Exists("recipes.csv"))
        {
            var lines = File.ReadAllLines("recipes.csv");
            foreach (var line in lines)
            {
                var parts = line.Split(',');
                var type = (RecipeType)Enum.Parse(typeof(RecipeType), parts[0]);
                var name = parts[1];
                var ingredientParts = parts[2].Split(';');
                var ingredients = ingredientParts.Select(p =>
                {
                    var ingredientDetails = p.Split(':');
                    return new Ingredient
                    {
                        Name = ingredientDetails[0],
                        Quantity = double.Parse(ingredientDetails[1]),
                        Unit = ingredientDetails[2]
                    };
                }).ToList();
                var instructions = parts[3];
                
                
                switch (type)
                {
                    case RecipeType.Appetizer:
                        recipes.Add(new AppetizerRecipe
                        {
                            Type = type,
                            Name = name,
                            Ingredients = ingredients,
                            Instructions = instructions
                        });
                        break;
                    case RecipeType.MainCourse:
                        recipes.Add(new MainCourseRecipe
                        {
                            Type = type,
                            Name = name,
                            Ingredients = ingredients,
                            Instructions = instructions
                        });
                        break;
                    case RecipeType.Dessert:
                        recipes.Add(new DessertRecipe
                        {
                            Type = type,
                            Name = name,
                            Ingredients = ingredients,
                            Instructions = instructions
                        });
                        break;
                    default:
                        Console.WriteLine($"Unknown recipe type: {type}");
                        break;
                }

            }
        }
        return recipes;
    }

    public void WriteToFile(List<RecipeBase> recipes)
    {
        File.WriteAllLines("recipes.csv", recipes.Select(r => $"{r.Type},{r.Name},{string.Join(";", r.Ingredients.Select(i => $"{i.Name}:{i.Quantity}:{i.Unit}"))},{r.Instructions}"));
    }
}