using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTexture : MonoBehaviour
{
    public Camera lvl1CamB;
    public Camera redPlane;
    public Camera pyreCamB;

    public Material lvl1MatB;
    public Material redPlaneB;
    public Material pyreMatB;

    void Start()
    {
        Lvl1();
        RedPlane();
        Pyre();
    }

    void Update()
    {
        
    }

    void Lvl1()
    {
        if (lvl1CamB.targetTexture != null)
        {
            lvl1CamB.targetTexture.Release();
        }
        lvl1CamB.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        lvl1MatB.mainTexture = lvl1CamB.targetTexture;
    }

    void RedPlane()
    {
        if (redPlane.targetTexture != null)
        {
            redPlane.targetTexture.Release();
        }
        redPlane.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        redPlaneB.mainTexture = redPlane.targetTexture;
    }

    void Pyre()
    {
        if (pyreCamB.targetTexture != null)
        {
            pyreCamB.targetTexture.Release();
        }
        pyreCamB.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        pyreMatB.mainTexture = pyreCamB.targetTexture;
    }
}
