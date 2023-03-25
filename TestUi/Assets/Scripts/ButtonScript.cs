using UnityEngine.SceneManagement;
using UnityEngine;

public class ButtonScript : MonoBehaviour
{
    public void Scenes(int NumScene)
    {
        SceneManager.LoadScene(NumScene);
    }

    public void Exit()
    {
        Application.Quit();
    }
}
