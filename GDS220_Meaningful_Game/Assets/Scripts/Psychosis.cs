using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Psychosis : MonoBehaviour
{
    public GameObject[] voicePos;

    void Awake()
    {
        
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
    }
}
