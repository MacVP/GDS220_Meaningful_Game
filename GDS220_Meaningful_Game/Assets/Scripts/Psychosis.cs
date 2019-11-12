using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Psychosis : MonoBehaviour
{
    public GameObject[] voicePos;

    private GameObject front;
    private GameObject back;
    private GameObject right;
    private GameObject left;

    void Awake()
    {
        front = voicePos[0];
        back = voicePos[1];
        right = voicePos[2];
        left = voicePos[3];
    }

    void Update()
    {
        PsychosisTest();
    }

    void PsychosisTest()
    {
        if (Input.GetButtonDown("Jump"))
        {
            GameObject currentPos = voicePos [Random.Range(0, voicePos.Length)];
            Debug.Log(currentPos);
            AudioSource audio = currentPos.GetComponent<AudioSource>();
            audio.Play();
        }

        if (Input.GetButtonDown("AudioTestF"))
        {
            front.GetComponent<AudioSource>().Play();
        }

        if (Input.GetButtonDown("AudioTestB"))
        {
            back.GetComponent<AudioSource>().Play();
        }

        if (Input.GetButtonDown("AudioTestR"))
        {
            right.GetComponent<AudioSource>().Play();
        }

        if (Input.GetButtonDown("AudioTestL"))
        {
            left.GetComponent<AudioSource>().Play();
        }
    }
}
