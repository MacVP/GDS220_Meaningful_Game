using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class TriggerManager : MonoBehaviour
{
    private LevelOptimisation lvlOP;
    private AudioManager audioManager;
    private PlayerMovement playerM;
    private SceneChange sceneChange;

    public GameObject son;
    public GameObject pyre;
    public Camera mainCamera;
    public Camera scareCam;
    private Animator moveSon;

    public Text title;

    public GameObject player;
    public GameObject startPoint;
    public Image blackScreen;
    private bool fadeScreen;
    private float fadeRate = 0.1f;

    public GameObject pPHolster;

    void Awake()
    {
        sceneChange = FindObjectOfType<SceneChange>();
        playerM = FindObjectOfType<PlayerMovement>();
        lvlOP = FindObjectOfType<LevelOptimisation>();
        audioManager = FindObjectOfType<AudioManager>();

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
            pyre.SetActive(true);
        }
        else
        {
            Debug.Log("No pyre gameobject");
        }

        fadeScreen = false;
    }

    void Start()
    {
        StartOfGame();
    }

    void Update()
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
                audioManager.Play("Sees_Boy");

                son.SetActive(true);
                Debug.Log("Son Trigger");
                moveSon.SetTrigger("AroundCorner");
                Invoke("Destroy", 2);
            }

            //Activating the pyre
            if (gameObject.name == "PyreTrigger")
            {
                pyre.SetActive(false);
            }

            //Jumpscare
            if (gameObject.name == "ScareTrigger")
            {
                print("Jumpscare");
                audioManager.Play("Scare");
                mainCamera.enabled = false;
                Invoke("SwitchCams", 2);
                Invoke("MovePlayer", 2);
            }

            if (gameObject.name == "Voices_Bear")
            {
                audioManager.Play("Voices_Bear");
            }

            if (gameObject.name == "RocksTrigger")
            {
                audioManager.Play("Rocks");
            }

            if (gameObject.name == "Portal_1")
            {
                audioManager.Play("Portal_1");
            }

            if (gameObject.name == "GoUp")
            {
                audioManager.Play("GoUp");
            }

            if (gameObject.name == "BrokenBridge")
            {
                audioManager.Play("BrokenBridge");
            }

            if (gameObject.name == "GrassChange")
            {
                audioManager.Play("GrassChange");
            }

            if (gameObject.name == "Portal_3")
            {
                audioManager.Play("Portal_3");
            }

            if (gameObject.name == "End")
            {
                audioManager.Play("BOOM");
                audioManager.Play("Violin");
                audioManager.Play("Suspence");
                audioManager.Play("End");
                Invoke("StopEnd", 60);
            }
        }
    }

    void StartOfGame()
    {
        playerM.speed = 0f;
        var tempColor = blackScreen.color;
        tempColor.a = 1f;
        blackScreen.color = tempColor;
        audioManager.Play("Start");
        Invoke("FadeScreen", 26);
        Invoke("Follow", 26);
    }

    void Follow()
    {
        audioManager.Play("Follow");
    }

    void StopEnd()
    {
        audioManager.Play("BOOM");
        audioManager.Stop("Violin");
        audioManager.Stop("Suspence");

        pPHolster.SetActive(false);

        var tempColor = blackScreen.color;
        tempColor.a = 1f;
        blackScreen.color = tempColor;

        var tempText = title.color;
        tempText.a = 1f;
        title.color = tempText;
    }

    void SwitchCams()
    {
        audioManager.Stop("Suspence");
        audioManager.Play("BOOM");

        var tempColor = blackScreen.color;
        tempColor.a = 1f;
        blackScreen.color = tempColor;
        player.transform.position = startPoint.transform.position;
        lvlOP.StartLevelStop();
        Invoke("FadeScreen", 9);
        Invoke("PlayWakeUp", 7);
    }

    void PlayWakeUp()
    {
        audioManager.Play("WakeUp");
    }

    void FadeScreen()
    {
        fadeScreen = true;
        playerM.speed = 6f;
    }

    void Level_1()
    {
        if (fadeScreen)
        {
            //print("Fade Black Screen");
            var tempColor = blackScreen.color;
            if(mainCamera.enabled == false)
            {
                mainCamera.enabled = true;
            }

            if (tempColor.a != 0f)
            {
                //print("Fading");
                tempColor.a = tempColor.a - 0.005f;
            }

            if (tempColor.a <= 0f)
            {
                //print("FadeScreen = false");
                fadeScreen = false;
            }
            blackScreen.color = tempColor;
        }
    }

    void MovePlayer()
    {
        player.transform.position = startPoint.transform.position;
    }

    void Destroy()
    {
        son.SetActive(false);
    }
}
