using UnityEngine;
using System.Collections;

public class LevelOptimisation : MonoBehaviour
{
    public GameObject Level_1A;
    public GameObject Level_1B;
    public GameObject Level_1C;
    public GameObject Level_1D;
    public GameObject Level_1E;
    public GameObject Pyre_A;
    public GameObject Pyre_B;

    private void Start()
    {
        Level_1A.SetActive(true);
        Level_1B.SetActive(true);
        Level_1C.SetActive(false);
        Level_1D.SetActive(false);
        Level_1E.SetActive(false);
        Pyre_A.SetActive(false);
        Pyre_B.SetActive(false);
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
        Level_1A.SetActive(true);
        Level_1B.SetActive(true);
    }
    void LevelShow_2()
    {
        Level_1A.SetActive(false);
        Level_1B.SetActive(true);
        Level_1C.SetActive(true);
    }
    void LevelShow_3()
    {
        Level_1B.SetActive(false);
        Level_1C.SetActive(true);
        Level_1D.SetActive(true);
    }
    void LevelShow_4()
    {
        Level_1C.SetActive(false);
        Level_1D.SetActive(true);
        Level_1E.SetActive(true);
    }
    void LevelShow_5()
    {
        Level_1D.SetActive(false);
        Level_1E.SetActive(true);
        Pyre_A.SetActive(true);
    }
    void LevelShow_6()
    {
        Level_1E.SetActive(false);
        Pyre_A.SetActive(true);
        Pyre_B.SetActive(true);
    }
    void LevelShow_7()
    {
        Pyre_A.SetActive(false);
    }
}
