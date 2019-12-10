using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerInteract : MonoBehaviour
{
    private AudioManager audioManager;

    public float range = 3;
    public LayerMask layerMask;
    public Text berryBText;
    public Text inspectText;
    private InteractableManager lookingAt;
    public GameObject interactable;
    public int berriesPicked;

    private void Awake()
    {
        audioManager = FindObjectOfType<AudioManager>();
    }

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

            interactable = hit.collider.gameObject;
            lookingAt = interactable.GetComponent<InteractableManager>();



            if (lookingAt != null)
            {
                if(interactable.name == "BerryBush")
                {
                    //For Berry Bushes
                    if (lookingAt.lookedAt == false)
                    {
                        //"E" Pick Berry
                        berryBText.enabled = true;
                    }

                    if (Input.GetButtonDown("Interact"))
                    {
                        //Stops text from appearing if berries have been picked
                        lookingAt.lookedAt = true;
                        lookingAt.PickBerry();
                        berryBText.enabled = false;
                        Debug.Log("working");
                        berriesPicked++;
                    }
                }

                if(interactable.name == "TeddyBear")
                {
                    Debug.Log("Looking At Teddy Bear");
                    inspectText.enabled = true;

                    if (Input.GetButtonDown("Interact"))
                    {
                        audioManager.Play("Fire_Portal");
                        lookingAt.TakeTeddyBear();
                    }
                }
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
            berryBText.enabled = false;
            inspectText.enabled = false;
        }
    }
}
