using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalTexture : MonoBehaviour
{
    public Camera lvl1ACamB;
    public Camera lvl1BCamB;
    public Camera lvl1CCamB;
    public Camera lvl1DCamB;
    public Camera lvl1ECamB;
    public Camera pyreCamB;

    public Material lvl1AMatB;
    public Material lvl1BMatB;
    public Material lvl1CMatB;
    public Material lvl1DMatB;
    public Material lvl1EMatB;
    public Material pyreMatB;

    void Start()
    {
        Lvl1A();
        Lvl1B();
        Lvl1C();
        Lvl1D();
        Lvl1E();
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

    void Lvl1C()
    {
        if (lvl1CCamB.targetTexture != null)
        {
            lvl1CCamB.targetTexture.Release();
        }
        lvl1CCamB.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        lvl1CMatB.mainTexture = lvl1CCamB.targetTexture;
    }

    void Lvl1D()
    {
        if (lvl1DCamB.targetTexture != null)
        {
            lvl1DCamB.targetTexture.Release();
        }
        lvl1DCamB.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        lvl1DMatB.mainTexture = lvl1DCamB.targetTexture;
    }

    void Lvl1E()
    {
        if (lvl1ECamB.targetTexture != null)
        {
            lvl1ECamB.targetTexture.Release();
        }
        lvl1ECamB.targetTexture = new RenderTexture(Screen.width, Screen.height, 24);
        lvl1EMatB.mainTexture = lvl1ECamB.targetTexture;
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
