using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableManager : MonoBehaviour
{
    public GameObject berries;
    public bool lookedAt;
    public bool berryBPicked = false;

    void Update()
    {
        PickBerry();
    }

    void PickBerry()
    {
        if(lookedAt == true)
        {
            Debug.Log("Picked Berries");
            berries.SetActive(false);
        }
    }
}
