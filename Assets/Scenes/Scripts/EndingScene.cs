using UnityEngine;
using TMPro;

public class EndingScene : MonoBehaviour
{
    public TMP_Text moneyText;
    public TMP_Text successText;
    public TMP_Text failText;

    public GameObject starL;
    public GameObject starM;
    public GameObject starR;
    public GameObject summaryTab;

    private float timeDelay = 0f;
    private int starCount;

    void Start()
    {
        
        //summaryTab.GetComponent<UISlide>().Show();

        moneyText.text = "$" + GameManager.money.ToString();
        successText.text = GameManager.complDrinks.ToString();
        failText.text = (GameManager.drinks - GameManager.complDrinks).ToString();
        starCount = GameManager.stars;
     
        
    }
    void Update()
    {
        timeDelay += Time.deltaTime;

        if (!summaryTab.activeSelf && timeDelay >= 0.2f)
        {
            summaryTab.GetComponent<UISlide>().Show();
        }

        if (starCount >= 1 && timeDelay >= 0.3f && !starM.activeSelf)
        {
            starM.GetComponent<UIPop>().Show();
        }
        if (starCount >= 2 && timeDelay >= 0.8f && !starL.activeSelf)
        {
            starL.GetComponent<UIPop>().Show();
        }
        if (starCount >= 3 && timeDelay >= 1.3f && !starR.activeSelf)
        {
            starR.GetComponent<UIPop>().Show();
        }
    }
}
