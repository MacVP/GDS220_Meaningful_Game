using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneChange : MonoBehaviour
{
    public bool started = false;

    public void StartGame()
    {
        SceneManager.LoadScene(1);
        print("Main Scene Started");
    }

    public void EndOfGame()
    {
        SceneManager.LoadScene(0);
        print("Back To Menu");
    }
}
