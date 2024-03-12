using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class PecanCheckContaminate : MonoBehaviour
{

    public void PecanContaminate()
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
