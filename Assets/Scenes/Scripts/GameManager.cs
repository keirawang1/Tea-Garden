using UnityEngine;
using UnityEngine.SceneManagement;


public class GameManager : MonoBehaviour
{
    public ScoreManager scoreManager;
    public Timer timer;
    private bool gameOver;
    public static int money;
    public static int complDrinks;
    public static int drinks;
    public static int stars;
    private float timeDelay = 0f;

    public GameObject screenPanel;
    


    void Update()
    {
        gameOver = timer.getGameOver();

        if (gameOver)
        {
            money = scoreManager.getTotalMoney();
            complDrinks = scoreManager.getNumComp();
            drinks = scoreManager.getNumDrinks();

            stars = ((complDrinks + money) / 25);

            timeDelay += Time.deltaTime;
        
            screenPanel.SetActive(true);
            if (timeDelay > 3f)
            {
                SceneManager.LoadScene(sceneName: "EndingScene");

            }
        }

    }

    
    

}