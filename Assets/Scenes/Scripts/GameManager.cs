using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public ScoreManager scoreManager;
    public Timer timer;
    private bool gameOver;
    private bool gameStarted = false;
    public static int money;
    public static int complDrinks;
    public static int drinks;
    public static int stars;
    private float timeDelay = 0f;

    public GameObject screenPanel;
    public GameObject readyText;
    public GameObject GoText;

    bool readyShown = false;
    bool readyHidden = false;
    bool goShown = false;


    void Update()
    {

        if (!gameStarted)
        {
            timeDelay += Time.deltaTime;

            if (!readyShown && timeDelay <= 1f)
            {
                readyText.GetComponent<UIPop>().Show();
                readyShown = true;
            }

            if (timeDelay >= 1f && !readyHidden)
            {
                readyHidden = true;
                readyText.GetComponent<UIPop>().Hide();
            }
            if (timeDelay >= 1.8f && timeDelay <= 2.9f && !goShown) 
            { 
                GoText.GetComponent<UIPop>().Show();
                goShown = true;
            }

            if (timeDelay >= 3f && goShown)
            {
                goShown = false;
                GoText.GetComponent<UIPop>().Hide();
            }

            if (timeDelay >= 3.6f)
            {
                timer.setTimeRun();
                gameStarted = true;
                screenPanel.SetActive(false);
            }


        }
        gameOver = timer.getGameOver();

        if (gameOver)
        {
            money = scoreManager.getTotalMoney();
            complDrinks = scoreManager.getNumComp();
            drinks = scoreManager.getNumDrinks();

            stars = ((complDrinks * 5 + money) / 5 + 10* (drinks - complDrinks));

            timeDelay += Time.deltaTime;
        
            screenPanel.SetActive(true);
            if (timeDelay > 3f)
            {
                SceneManager.LoadScene(sceneName: "EndingScene");

            }
        }

    }

 

}