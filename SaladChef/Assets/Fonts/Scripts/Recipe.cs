using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Recipe : MonoBehaviour
{
    public string RecipeName { get; set; }
    public List<string> Ingredients { get; set; }

    /*
    public Recipe(string recipeName, List<string> ingredients)
    {
        RecipeName = recipeName;
        Ingredients = ingredients;
    }
    */

    // Example of how to initialize a list of Recipe objects
    void Start()
    {
        // Initialize a list of Recipe objects


        // Now 'recipes' contains a list of Recipe objects with different names and ingredients
    }

    public string GetRecipeName(Recipe recipe)
    {
        return recipe.RecipeName;
    }

    /*
    List<Recipe> recipes = new List<Recipe>
        {
            new Recipe("Salad1", new List<string>{"Lettuce", "Tomato", "Pecan", }),
            new Recipe("Omelette", new List<string>{"Egg", "Cheese", "Lettuce", "Tomato"}),
            // Add more recipes as needed
        };
    */


}
