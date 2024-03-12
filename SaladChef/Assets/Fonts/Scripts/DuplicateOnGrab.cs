using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class DuplicateOnGrab : MonoBehaviour
{
    public GameObject prefabToSpawn;

    public GameObject spawnPoint;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void spawnPrefab(GameObject gameObjectToDuplicate)
    {
        Instantiate(prefabToSpawn, spawnPoint.transform.position, spawnPoint.transform.rotation);
    }

    public void teleportPrefab()
    {

    }

    public void returnPrefabToParent()
    {

    }
}
