using UnityEngine;

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
        Level_1A.SetActive(false);
        Level_1B.SetActive(false);
        Level_1C.SetActive(false);
        Level_1D.SetActive(false);
        Level_1E.SetActive(false);
        Pyre_A.SetActive(false);
        Pyre_B.SetActive(false);
    }

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && gameObject.name == "1A-1B")
        {
            Level_1A.SetActive(true);
            Level_1B.SetActive(true);
        }

        if (other.CompareTag("Player") && gameObject.name == "1B-1C")
        {
            Level_1A.SetActive(false);
            Level_1B.SetActive(true);
            Level_1C.SetActive(true);
        }

        if (other.CompareTag("Player") && gameObject.name == "1C-1D")
        {
            Level_1B.SetActive(false);
            Level_1C.SetActive(true);
            Level_1D.SetActive(true);
        }

        if (other.CompareTag("Player") && gameObject.name == "1D-1E")
        {
            Level_1C.SetActive(false);
            Level_1D.SetActive(true);
            Level_1E.SetActive(true);
        }

        if (other.CompareTag("Player") && gameObject.name == "1E-PyreA")
        {
            Level_1D.SetActive(false);
            Level_1E.SetActive(true);
            Pyre_A.SetActive(true);
        }

        if (other.CompareTag("Player") && gameObject.name == "PyreA-PyreB")
        {
            Level_1E.SetActive(false);
            Pyre_A.SetActive(true);
            Pyre_B.SetActive(true);
        }
    }
}
