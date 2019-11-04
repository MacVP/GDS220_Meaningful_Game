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
    public int berriesPicked;

    void Update()
    {
        Interact();
    }

    void Interact()
    {
        RaycastHit hit;
        if (Physics.Raycast(transform.position, transform.forward, out hit, range, layerMask))
        {
            Debug.Log("Looking at Berry Bush");

            lookingAt = hit.collider.gameObject.GetComponent<InteractableManager>();

            //For Berry Bushes
            if(lookingAt.lookedAt == false)
            {
                //"E" Pick Berry
                text.enabled = true;
            }

            if (hit.collider.gameObject.GetComponent<InteractableManager>() != null && Input.GetButtonDown("Interact"))
            {
                //Stops text from appearing if berries have been picked
                lookingAt.lookedAt = true;
                text.enabled = false;
                Debug.Log("working");
                berriesPicked++;
            }
            else
            {
                //Null check
                Debug.Log("No Script");               
            }
        }
        else
        {
            //Don't display text when not looking at the berry bush
            text.enabled = false;
        }
    }
}
