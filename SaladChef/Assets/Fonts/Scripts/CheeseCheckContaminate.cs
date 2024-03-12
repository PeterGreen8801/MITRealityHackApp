using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheeseCheckContaminate : MonoBehaviour
{
    public void CheeseContaminate()
    {
        ApplicationManager.Instance.isHandsContaminated = true;
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
