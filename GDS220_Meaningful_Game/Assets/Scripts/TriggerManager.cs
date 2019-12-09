using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerManager : MonoBehaviour
{
    private LevelOptimisation lvlOP;

    public GameObject son;
    public GameObject pyre;
    public Camera mainCamera;
    public Camera scareCam;
    private Animator moveSon;

    public GameObject player;
    public GameObject startPoint;
    public Image blackScreen;
    private bool fadeScreen;
    private float fadeRate = 0.1f;

    void Awake()
    {
        lvlOP = FindObjectOfType<LevelOptimisation>();

        //null checks
        if(son != null)
        {
            moveSon = son.GetComponent<Animator>();
            //son.SetActive(false);
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

        fadeScreen = false;
    }

    private void Update()
    {
        Level_1();
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
                Invoke("Destroy", 2);
            }

            //Activating the pyre
            if (gameObject.name == "PyreTrigger")
            {
                pyre.SetActive(true);
            }

            //Jumpscare
            if (gameObject.name == "ScareTrigger")
            {
                print("Jumpscare");
                mainCamera.enabled = false;
                Invoke("SwitchCams", 2);
            }
        }
    }

    void SwitchCams()
    {
        var tempColor = blackScreen.color;
        tempColor.a = 1f;
        blackScreen.color = tempColor;
        lvlOP.StartLevelStop();
        Invoke("FadeScreen", 3);
    }

    void FadeScreen()
    {
        fadeScreen = true;
    }

    void Level_1()
    {
        if (fadeScreen)
        {
            //print("Fade Black Screen");
            var tempColor = blackScreen.color;
            player.transform.position = startPoint.transform.position;
            mainCamera.enabled = true;

            if (tempColor.a != 0f)
            {
                //print("Fading");
                tempColor.a = tempColor.a - 0.009f;
            }

            if (tempColor.a <= 0f)
            {
                //print("FadeScreen = false");
                fadeScreen = false;
            }


            blackScreen.color = tempColor;
        }
    }

    void Destroy()
    {

        son.SetActive(false);
    }
}
