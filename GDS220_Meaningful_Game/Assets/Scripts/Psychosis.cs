using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Psychosis : MonoBehaviour
{
    public GameObject[] voicePos;

    private GameObject left;
    private GameObject rightFront;
    private GameObject right;
    private GameObject leftFront;
    private GameObject leftBack;
    private GameObject rightBack;

    void Awake()
    {
        left = voicePos[0];
        right = voicePos[1];
        rightFront = voicePos[2];
        leftBack = voicePos[3];
        leftFront = voicePos[4];
        rightBack = voicePos[5];
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

        if (Input.GetButtonDown("Left"))
        {
            left.GetComponent<AudioSource>().Play();
        }

        if (Input.GetButtonDown("Right"))
        {
            right.GetComponent<AudioSource>().Play();
        }

        if (Input.GetButtonDown("RightFront"))
        {
            rightFront.GetComponent<AudioSource>().Play();
        }

        if (Input.GetButtonDown("LeftBack"))
        {
            leftBack.GetComponent<AudioSource>().Play();
        }

        if (Input.GetButtonDown("LeftFront"))
        {
            leftFront.GetComponent<AudioSource>().Play();
        }

        if (Input.GetButtonDown("RightBack"))
        {
            rightBack.GetComponent<AudioSource>().Play();
        }
    }
}
