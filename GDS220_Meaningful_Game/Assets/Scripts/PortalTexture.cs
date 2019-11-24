using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTexture : MonoBehaviour
{
    public Camera lvl1ACamB;
    public Camera lvl1BCamB;
    public Camera pyreCamB;

    public Material lvl1AMatB;
    public Material lvl1BMatB;
    public Material pyreMatB;

    void Start()
    {
        Lvl1A();
        Lvl1B();
        Pyre();
    }

    void Lvl1A()
    {
        if (lvl1ACamB.targetTexture != null)
        {
            lvl1ACamB.targetTexture.Release();
        }
        lvl1ACamB.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        lvl1AMatB.mainTexture = lvl1ACamB.targetTexture;
    }

    void Lvl1B()
    {
        if (lvl1BCamB.targetTexture != null)
        {
            lvl1BCamB.targetTexture.Release();
        }
        lvl1BCamB.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        lvl1BMatB.mainTexture = lvl1BCamB.targetTexture;
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
