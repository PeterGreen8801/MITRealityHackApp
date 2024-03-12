using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PecanContaminateOrNot : MonoBehaviour
{
    public void IsTheHolderContaminated()
    {
        if (ApplicationManager.Instance.CheckHandsContaminated())
        {
            ApplicationManager.Instance.DirtyPecanContainer();
        }
    }
}
