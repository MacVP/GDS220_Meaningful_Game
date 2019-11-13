using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractableManager : MonoBehaviour
{
    public SceneManagement sceneManagement;

    public GameObject player;
    public GameObject berries;
    public GameObject teddyBear;
    public bool lookedAt;

    public Vector3 startPoint;

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
        player.transform.position = startPoint;
    }
}
