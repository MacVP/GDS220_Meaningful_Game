using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyboxManager : MonoBehaviour
{
    public Material nightMat;
    public Material sunsetMat;
    public Material purpleMat;

    public bool night = false;
    public bool sunset = false;
    public bool purple = false;

    void Start()
    {
        
    }

    //void Update()
    //{
    //    Debug.Log("Night" + night);
    //    Debug.Log("Sunset" + sunset);
    //    Debug.Log("Purple" + purple);
    //}

    public void ChangeSkybox()
    {
        if (night)
        {
            RenderSettings.skybox = nightMat;
            Debug.Log("Night");
        }

        if (sunset)
        {
            RenderSettings.skybox = sunsetMat;
            Debug.Log("Sunset");
        }

        if (purple)
        {
            RenderSettings.skybox = purpleMat;
            Debug.Log("Purple");
        }
    }
}
