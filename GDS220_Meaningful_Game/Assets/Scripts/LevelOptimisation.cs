using UnityEngine;

public class LevelOptimisation : MonoBehaviour
{
    public GameObject Level_1A;
    public GameObject Level_1B;
    public GameObject Level_1C;
    public GameObject Level_1D;
    public GameObject Level_1E;

    void OnTriggerEnter(Collider other)
    {
        if(other.CompareTag("Player") && gameObject.name == "Level_1-2")
        {
            Level_1A.SetActive(true);
            Level_1B.SetActive(true);
            Level_1C.SetActive(false);
            Level_1D.SetActive(false);
            Level_1E.SetActive(false);
        }

        if (other.CompareTag("Player") && gameObject.name == "Level_2-3")
        {
            Level_1A.SetActive(true);
            Level_1B.SetActive(true);
            Level_1C.SetActive(true);
            Level_1D.SetActive(false);
            Level_1E.SetActive(false);
        }

        if (other.CompareTag("Player") && gameObject.name == "Level_3-4")
        {
            Level_1A.SetActive(false);
            Level_1B.SetActive(true);
            Level_1C.SetActive(true);
            Level_1D.SetActive(true);
            Level_1E.SetActive(false);
        }

        if (other.CompareTag("Player") && gameObject.name == "Level_4-5")
        {
            Level_1A.SetActive(false);
            Level_1B.SetActive(false);
            Level_1C.SetActive(true);
            Level_1D.SetActive(true);
            Level_1E.SetActive(true);
        }
    }
}
