using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheeseContaminateOrNot : MonoBehaviour
{
    public void IsTheHolderContaminated()
    {
        if (ApplicationManager.Instance.CheckHandsContaminated())
        {
            ApplicationManager.Instance.DirtyCheeseContainer();
        }
    }
}
