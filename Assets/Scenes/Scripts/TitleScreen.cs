using UnityEngine;
using UnityEngine.SceneManagement;


public class TitleScreen : MonoBehaviour
{
    public GameObject startButton;
    public GameObject overlayButton;
    private float timeDelay = 0f;
    private bool clicked = false;

    void Update()
    {
        timeDelay += Time.deltaTime;
        if (timeDelay >= 0.5f && clicked)
        {
            SceneManager.LoadScene(sceneName: "MainScene");

        }
    }

    public void OnClick()
    {
        timeDelay = 0f;
        overlayButton.SetActive(true);
        clicked = true;
        LeanTween.scale(overlayButton, Vector3.one * 2f, 0.8f).setEaseOutQuad();
        LeanTween.alpha(overlayButton.GetComponent<RectTransform>(), 0f, 0.6f).setEaseOutQuad();

    }
}
