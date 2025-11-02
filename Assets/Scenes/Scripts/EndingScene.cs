using UnityEngine;
using TMPro;

public class EndingScene : MonoBehaviour
{
    public TMP_Text moneyText;
    public TMP_Text successText;
    public TMP_Text totalText;

    public GameObject starL;
    public GameObject starM;
    public GameObject starR;

    void Start()
    {
        moneyText.text = GameManager.money.ToString();
        successText.text = GameManager.complDrinks.ToString();
        totalText.text = GameManager.drinks.ToString();


        int starCount = GameManager.stars;
        if (starCount >= 1)
        {
            starM.SetActive(true);
        }
        if (starCount >= 2)
        {
            starL.SetActive(true);
        }
        if (starCount >= 3)
        {
            starR.SetActive(true);
        }
    }
}
