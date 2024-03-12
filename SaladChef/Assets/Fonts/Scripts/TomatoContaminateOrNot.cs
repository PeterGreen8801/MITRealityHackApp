using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TomatoContaminateOrNot : MonoBehaviour
{
    public void IsTheHolderContaminated()
    {
        if (ApplicationManager.Instance.CheckHandsContaminated())
        {
            ApplicationManager.Instance.DirtyTomatoContainer();
        }
    }
}
