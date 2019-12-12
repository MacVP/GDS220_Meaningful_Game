using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InteractableManager : MonoBehaviour
{
    private LevelOptimisation lvlOP;
    private TriggerManager trigger;

    public GameObject player;
    public GameObject berries;
    public GameObject teddyBear;
    public GameObject firePortal;
    public GameObject jumpScare;

    public bool lookedAt;  

    private void Awake()
    {
        trigger = FindObjectOfType<TriggerManager>();
        lvlOP = FindObjectOfType<LevelOptimisation>();
    }

    private void Start()
    {
        if (firePortal == null)
        {
            return;
        }

        firePortal.SetActive(false);
        jumpScare.SetActive(false);
    }

    public void PickBerry()
    {
        //Pick up berries
        Debug.Log("Picked Berries");
        berries.SetActive(false);
    }

    public void TakeTeddyBear()
    {
        //trigger.ScreenCheck();
        //Pick up Teddy Bear
        Debug.Log("Teddy Picked Up");
        teddyBear.SetActive(false);
        firePortal.SetActive(true);
        jumpScare.SetActive(true);      
        lvlOP.StartLevelB();
    }
}
