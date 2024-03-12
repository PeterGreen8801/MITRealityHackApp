using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ingredients : MonoBehaviour
{

    public static Ingredients Instance;

    private void Awake()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(gameObject);
        }
        else
        {
            Destroy(gameObject);
        }
    }

    void Start()
    {
        /*
        Ingredients lettuce = new Ingredients(LETTUCE);
        Ingredients tomato = new Ingredients(TOMATO);
        Ingredients egg = new Ingredients(EGG);
        Ingredients cheese = new Ingredients(CHEESE);
        Ingredients pecan = new Ingredients(PECAN);
        */
    }

    private string ingredientName;
    private const string LETTUCE = "Lettuce";
    private const string TOMATO = "Tomato";
    private const string EGG = "Egg";
    private const string CHEESE = "Cheese";
    private const string PECAN = "Pecan";


    /*
    public Ingredients(string name)
    {
        ingredientName = name;
    }
    */


    public string GetIngredientName(Ingredients ingredient)
    {
        return ingredient.ingredientName;
    }

    // Update is called once per frame
    void Update()
    {

    }


}
