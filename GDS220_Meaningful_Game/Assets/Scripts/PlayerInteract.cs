using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteract : MonoBehaviour
{
    public float range = 3;
    public LayerMask layerMask;
    public Text text;
    private InteractableManager lookingAt;

    void Update()
    {
        BerryBush();
    }

    void BerryBush()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, range, layerMask) && lookingAt.berryBPicked == false)
        {
            Debug.Log("Looking at Berry Bush");
            text.enabled = true;

            lookingAt = hit.collider.gameObject.GetComponent<InteractableManager>();

            if (hit.collider.gameObject.GetComponent<InteractableManager>() != null && Input.GetButtonDown("Interact"))
            {
                hit.collider.gameObject.GetComponent<InteractableManager>().lookedAt = true;
                hit.collider.gameObject.GetComponent<InteractableManager>().berryBPicked = true;
                Debug.Log("working");
            }
            else
            {
                Debug.Log("No Script");               
            }
        }
        else
        {
            text.enabled = false;
        }
    }
}
