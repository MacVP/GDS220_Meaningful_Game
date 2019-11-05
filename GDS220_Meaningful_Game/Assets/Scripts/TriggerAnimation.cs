using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAnimation : MonoBehaviour
{
    public GameObject son;
    private Animator moveSon;

    private void Awake()
    {
        moveSon = son.GetComponent<Animator>();
        son.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        //Animation trigger
        if (other.CompareTag("Player"))
        {
            if(gameObject.name == "SonTrigger")
            {
                son.SetActive(true);
                Debug.Log("Son Trigger");
                moveSon.SetTrigger("AroundCorner");
                Invoke("Destroy", 5);
            }

            if (gameObject.name == "TeddyBear")
            {

            }
        }
    }

    void Destroy()
    {
        son.SetActive(false);
    }
}
