﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerManager : MonoBehaviour
{
    public GameObject son;
    public GameObject pyre;
    private Animator moveSon;

    void Awake()
    {
        //null checks
        if(son != null)
        {
            moveSon = son.GetComponent<Animator>();
            son.SetActive(false);
        }
        else
        {
            Debug.Log("No son gameobject");
        }

        if (pyre != null)
        {
            pyre.SetActive(false);
        }
        else
        {
            Debug.Log("No pyre gameobject");
        }
    }

    void OnTriggerEnter(Collider other)
    {
        //Animation trigger
        if (other.CompareTag("Player"))
        {
            //Trigger animation of son walking around house
            if(gameObject.name == "SonTrigger")
            {
                son.SetActive(true);
                Debug.Log("Son Trigger");
                moveSon.SetTrigger("AroundCorner");
                Invoke("Destroy", 5);
            }

            //if (gameObject.name == "TeddyBear")
            //{

            //}

            //Activating the pyre
            if (gameObject.name == "PyreTrigger")
            {
                pyre.SetActive(true);
            }
        }
    }

    void Destroy()
    {
        son.SetActive(false);
    }
}
