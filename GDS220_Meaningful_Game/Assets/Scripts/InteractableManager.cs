using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableManager : MonoBehaviour
{
    private SceneManagement sceneManagement;
    private LevelOptimisation lvlOP;

    public GameObject player;
    public GameObject berries;
    public GameObject teddyBear;
    public GameObject firePortal;
    public GameObject jumpScare;

    public bool lookedAt;

    public Vector3 startPoint;

    private void Awake()
    {
        sceneManagement = FindObjectOfType<SceneManagement>();
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
        //Pick up Teddy Bear
        Debug.Log("Teddy Picked Up");
        teddyBear.SetActive(false);
        firePortal.SetActive(true);
        jumpScare.SetActive(true);
        player.transform.position = startPoint;
        lvlOP.StartLevelB();
    }
}
