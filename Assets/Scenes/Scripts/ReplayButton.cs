using UnityEngine;
using UnityEngine.SceneManagement;


public class ReplayButton : MonoBehaviour
{
    public void onClick()
    {
        SceneManager.LoadScene(sceneName: "MainScene");

    }
}
