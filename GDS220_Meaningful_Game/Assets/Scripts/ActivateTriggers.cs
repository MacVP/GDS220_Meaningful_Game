using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateTriggers : MonoBehaviour
{
    public GameObject sonTrigger1;
    private PlayerInteract playerIntr;

    void Awake()
    {
        playerIntr = FindObjectOfType<PlayerInteract>();
    }

    void Start()
    {
        sonTrigger1.SetActive(false);
    }

    void Update()
    {
        if(playerIntr.berriesPicked >= 5)
        {
            sonTrigger1.SetActive(true);
        }
    }
}
