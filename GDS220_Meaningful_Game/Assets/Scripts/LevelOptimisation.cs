using UnityEngine;
using System.Collections;

public class LevelOptimisation : MonoBehaviour
{
    public GameObject startLevelA;
    public GameObject startLevelB;
    public GameObject level_1A;
    public GameObject level_1B;
    public GameObject level_1C;
    public GameObject level_1D;
    public GameObject level_1E;
    public GameObject pyre_A;
    public GameObject pyre_B;

    private void Start()
    {
        startLevelA.SetActive(true);
        startLevelB.SetActive(false);
        level_1A.SetActive(false);
        level_1B.SetActive(false);
        level_1C.SetActive(false);
        level_1D.SetActive(false);
        level_1E.SetActive(false);
        pyre_A.SetActive(false);
        pyre_B.SetActive(false);
    }

    public void StartLevelB()
    {
        startLevelB.SetActive(true);
    }

    public void StartLevelStop()
    {
        startLevelA.SetActive(false);
        startLevelB.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player") && gameObject.name == "1A-1B")
        {
            Invoke("LevelShow_1", 0.01f);
            return;
        }

        if (other.CompareTag("Player") && gameObject.name == "1B-1C")
        {           
            Invoke("LevelShow_2", 0.01f);
            return;
        }

        if (other.CompareTag("Player") && gameObject.name == "1C-1D")
        {
            Invoke("LevelShow_3", 0.01f);
            return;
        }

        if (other.CompareTag("Player") && gameObject.name == "1D-1E")
        {
            Invoke("LevelShow_4", 0.01f);
            return;
        }

        if (other.CompareTag("Player") && gameObject.name == "1E-PyreA")
        {
            Invoke("LevelShow_5", 0.01f);
            return;
        }

        if (other.CompareTag("Player") && gameObject.name == "PyreA-PyreB")
        {
            Invoke("LevelShow_6", 0.01f);
            return;
        }

        if (other.CompareTag("Player") && gameObject.name == "PyreB")
        {
            Invoke("LevelShow_7", 0.01f);
            return;
        }
    }

    void LevelShow_1()
    {
        startLevelA.SetActive(false);
        startLevelB.SetActive(false);
        level_1A.SetActive(true);
        level_1B.SetActive(true);
    }
    void LevelShow_2()
    {
        level_1A.SetActive(false);
        level_1B.SetActive(true);
        level_1C.SetActive(true);
    }
    void LevelShow_3()
    {
        level_1B.SetActive(false);
        level_1C.SetActive(true);
        level_1D.SetActive(true);
    }
    void LevelShow_4()
    {
        level_1C.SetActive(false);
        level_1D.SetActive(true);
        level_1E.SetActive(true);
    }
    void LevelShow_5()
    {
        level_1D.SetActive(false);
        level_1E.SetActive(true);
        pyre_A.SetActive(true);
    }
    void LevelShow_6()
    {
        level_1E.SetActive(false);
        pyre_A.SetActive(true);
        pyre_B.SetActive(true);
    }
    void LevelShow_7()
    {
        pyre_A.SetActive(false);
    }
}
