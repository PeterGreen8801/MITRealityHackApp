using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Linq;
using UnityEngine.SceneManagement;
using UnityEngine.XR.Interaction.Toolkit;

using TMPro;
using Unity.VisualScripting;
using System.Net.Sockets;

public class ApplicationManager : MonoBehaviour
{
    public bool saladBowlIsContaminated;
    public bool eggBowlIsContaminated;
    public bool lettuceBowlIsContaminated;
    public bool pecanBowlIsContaminated;
    public bool tomatoBowlIsContaminated;
    public bool cheeseBowlIsContaminated;

    public GameObject newSaladBowlPrefab;

    public GameObject currentSaladBowl;

    public Transform SaladBowlSpawnPoint;

    public GameObject parentOfSaladBowl;

    public GameObject secondSaladMessage;

    public GameObject retryMessage;

    public GameObject SickRetryMessage;

    public GameObject spawnBowl;

    //Socket References
    public XRSocketInteractor LettuceSocket;
    public XRSocketInteractor TomatoSocket;
    public XRSocketInteractor EggSocket;
    public XRSocketInteractor PecanSocket;

    public void transportSpawn()
    {

    }



    public bool isHandsContaminated;


    public List<string> ingredientsInBowlList = new List<string>();

    private const string LETTUCE = "Lettuce";
    private const string TOMATO = "Tomato";
    private const string EGG = "Egg";
    private const string CHEESE = "Cheese";
    private const string PECAN = "Pecan";



    public static ApplicationManager Instance;

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

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void GetIngredientNames()
    {

    }

    public string SendEgg()
    {
        return EGG;
    }

    public string SendLettuce()
    {
        return LETTUCE;
    }

    public string SendPecan()
    {
        return PECAN;
    }

    public string SendTomato()
    {
        return TOMATO;
    }

    public string SendCheese()
    {
        return CHEESE;
    }

    public void ClearIngredientsInBowlList()
    {
        ingredientsInBowlList.Clear();
    }

    public void AddEgg()
    {
        ingredientsInBowlList.Add(EGG);

        Debug.Log(ingredientsInBowlList.ToList() + "Added");

    }

    public void AddLettuce()
    {
        ingredientsInBowlList.Add(LETTUCE);
    }

    public void AddPecan()
    {
        ingredientsInBowlList.Add(PECAN);
    }

    public void AddTomato()
    {
        ingredientsInBowlList.Add(TOMATO);
    }

    public void AddCheese()
    {
        ingredientsInBowlList.Add(CHEESE);
    }

    /*
    public bool CheckSaladBowlContaminated()
    {
        return saladBowlIsContaminated;
    }
    */

    public bool CheckHandsContaminated()
    {
        return isHandsContaminated;
    }

    public void CheckSaladBowlContaminated()
    {
        if (saladBowlIsContaminated)
        {
            //Popup Message
            SickRetryMessage.SetActive(true);

            //Reapeat course / Restart Scene on button press

        }
        else
        {
            //Load NIce mes
            //second window
            secondSaladMessage.gameObject.SetActive(true);
        }
    }

    //COMPLETE SALAD ONE CHECK
    public void CheckCompleteSaladOne()
    {
        if (CheckSaladOneIngredients())
        {
            Debug.Log(" TRUE, This confirms all ingredients present, just present.");
        }
        else
        {
            //put popup message here for incorrect salad, restart salad attempt.
            Debug.Log("The salad is not made right, remake it.");

            retryMessage.SetActive(true);
            return;
        }

        if (saladBowlIsContaminated)
        {
            Debug.Log("The SaladBowl is contaminated");
            //Popup Message
            SickRetryMessage.SetActive(true);

            //Reapeat course / Restart Scene on button press

        }
        else
        {
            Debug.Log("The SaladBowl is NOT contaminated");
            //Load NIce mes
            //second window
            secondSaladMessage.gameObject.SetActive(true);
        }
    }

    public void ResetBowlPosition()
    {
        //currentSaladBowl.gameObject.SetActive(false);
        currentSaladBowl.transform.position = SaladBowlSpawnPoint.position;
        currentSaladBowl.transform.rotation = SaladBowlSpawnPoint.rotation;
        //currentSaladBowl.gameObject.SetActive(true);
    }

    public bool CheckEggBowlContaminated()
    {
        return eggBowlIsContaminated;
    }

    public bool CheckLettuceBowlContaminated()
    {
        return lettuceBowlIsContaminated;
    }

    public bool CheckPecanBowlContaminated()
    {
        return pecanBowlIsContaminated;
    }

    public bool CheckTomatoBowlContaminated()
    {
        return tomatoBowlIsContaminated;
    }

    public bool CheckCheeseBowlContaminated()
    {
        return saladBowlIsContaminated;
    }

    List<string> requiredIngredientsFirstSalad = new List<string>
            {
                LETTUCE,
                TOMATO,
                EGG,
                PECAN
            };

    List<string> requiredIngredientsSecondSalad = new List<string>
            {
                LETTUCE,
                TOMATO,
                CHEESE,
            };

    //Starting to DEPRECATE for CheckSaladOneIngredients
    public bool ConfirmAllIngredientsPresentFirstSalad()
    {
        //return requiredIngredientsFirstSalad.All()
        Debug.Log("" + ingredientsInBowlList + requiredIngredientsFirstSalad.All(ingredient => ingredientsInBowlList.Contains(ingredient)));
        return requiredIngredientsFirstSalad.All(ingredient => ingredientsInBowlList.Contains(ingredient));

    }

    public void CleanALL()
    {
        saladBowlIsContaminated = false;
        eggBowlIsContaminated = false;
        lettuceBowlIsContaminated = false;
        pecanBowlIsContaminated = false;
        tomatoBowlIsContaminated = false;
        cheeseBowlIsContaminated = false;
        //transport bowl
        currentSaladBowl.gameObject.SetActive(false);
        currentSaladBowl.transform.position = SaladBowlSpawnPoint.position;
        currentSaladBowl.gameObject.SetActive(false);

    }


    //USE THIS GUY!!!!!!
    public void ConfirmAllIngredientsPresentFirstSaladVoid()
    {
        //return requiredIngredientsFirstSalad.All()
        Debug.Log("" + ingredientsInBowlList + requiredIngredientsFirstSalad.All(ingredient => ingredientsInBowlList.Contains(ingredient)));
        ingredientsInBowlList.Clear();
        //Possibly reset all objects, clear the actual bowl so its empty
        //Reference to SaladBowl- setActive false
        currentSaladBowl.gameObject.SetActive(false);
        currentSaladBowl.transform.position = SaladBowlSpawnPoint.position;
        currentSaladBowl.gameObject.SetActive(true);

        //Instantiate
        //Instantiate(newSaladBowlPrefab, parentOfSaladBowl.transform.position, parentOfSaladBowl.transform.rotation);
    }

    public void ConfirmAllIngredientsPresentSecondSaladVoid()
    {
        //return requiredIngredientsFirstSalad.All()
        Debug.Log("" + ingredientsInBowlList + requiredIngredientsFirstSalad.All(ingredient => ingredientsInBowlList.Contains(ingredient)));
    }

    public void ConfirmAllIngredientsPresentFirstSaladSequenceVoid()
    {
        if (ingredientsInBowlList.SequenceEqual(requiredIngredientsFirstSalad))
        {
            Debug.Log("True, it matches");
        }
        Debug.Log("" + ingredientsInBowlList.Count() + requiredIngredientsFirstSalad.All(ingredient => ingredientsInBowlList.Contains(ingredient)));
    }

    public void BothSaladsDoneRight()
    {
        //certificate set active.
    }

    public void DirtyHands()
    {
        isHandsContaminated = true;
    }

    public void CleanHands()
    {
        isHandsContaminated = false;
    }

    public void DirtyEggsContainer()
    {
        eggBowlIsContaminated = true;
    }

    public void DirtyLettuceContainer()
    {
        lettuceBowlIsContaminated = true;
    }

    public void DirtyCheeseContainer()
    {
        cheeseBowlIsContaminated = true;
    }

    public void DirtyTomatoContainer()
    {
        tomatoBowlIsContaminated = true;
    }
    public void DirtyPecanContainer()
    {
        pecanBowlIsContaminated = true;
    }

    public void DirtySaladBowl()
    {
        saladBowlIsContaminated = true;
    }

    public void TrashAndReplaceAllIngredients()
    {
        //reset all bools;
        saladBowlIsContaminated = false;
        //Need to rest salad bowl
        pecanBowlIsContaminated = false;
        tomatoBowlIsContaminated = false;
        cheeseBowlIsContaminated = false;
        //lettuceBowlIsContaminated
    }

    public void RestartTrainingModule()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().name);
    }

    public void ContaminateHands()
    {
        isHandsContaminated = true;
    }

    public bool CheckSaladOneIngredients()
    {
        if (LettuceSocketCheck() && TomatoSocketCheck() && EggSocketCheck() && PecanSocketCheck())
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public void LettuceSocketIngredientCheck()
    {
        if (LettuceSocket.hasSelection)
        {
            Debug.Log("Yes, socket is filled");
        }
        else
        {
            Debug.Log("Nothing there");
        }
    }

    public bool LettuceSocketCheck()
    {
        if (LettuceSocket.hasSelection)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool TomatoSocketCheck()
    {
        if (LettuceSocket.hasSelection)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool EggSocketCheck()
    {
        if (LettuceSocket.hasSelection)
        {
            return true;
        }
        else
        {
            return false;
        }
    }

    public bool PecanSocketCheck()
    {
        if (LettuceSocket.hasSelection)
        {
            return true;
        }
        else
        {
            return false;
        }
    }



    /*
    public void CheckIfContaminated()
    {

    }
    */


    /*
        public static bool ContainsAllIngredients(List<string> ingredientsList)
        {
            // Define a list of required ingredients
            List<Ingredients> requiredIngredients = new List<Ingredients>
            {
                Lettuce,
                Tomato,
                Egg,
                Cheese,
                Pecan
            };

            // Check if all required ingredients are present in the input list
            return requiredIngredients.All(ingredient => ingredientsList.Contains(ingredient));
        }

        */

}
