using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LettuceContaminateOrNot : MonoBehaviour
{
    public void IsTheHolderContaminated()
    {
        if (ApplicationManager.Instance.CheckHandsContaminated())
        {
            ApplicationManager.Instance.DirtyLettuceContainer();
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
}
