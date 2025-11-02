using UnityEngine;
using TMPro;

public class Timer : MonoBehaviour
{
    [SerializeField] private float timeLeft = 120f;
    public TMP_Text timer;
    private bool timerRunning = true;
    public GameObject finishText;
    private bool gameOver = false;


    void Update()
    {
        if (timerRunning)
        {
            timeLeft -= Time.deltaTime;
            int mins = Mathf.FloorToInt(timeLeft / 60);
            int secs = Mathf.FloorToInt(timeLeft % 60);
            timer.text = string.Format("{0}:{1:00}", mins, secs);
            if (timeLeft <= 0)
            {
                gameOverRun();
            }
        }
        return;
    }

    void gameOverRun()
    {
        timer.text = "0:00";
        timerRunning = false;
        finishText.GetComponent<UIPop>().Show();
        
        gameOver = true;
        //finishText.GetComponent<UISlide>().Show();
    }

    public bool getGameOver()
    {
        return gameOver;
    }

    }
