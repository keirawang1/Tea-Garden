using UnityEngine;
using TMPro;


public class ScoreManager : MonoBehaviour
{
    public GameObject submitButton;
    public DrinkManager drink;
    public OrderDisplay order;
    public GameObject sweetCheck;
    public GameObject cuteCheck;
    public GameObject costCheck;
    public Order orderTemp;

    public TMP_Text moneyCounter;
    public TMP_Text moneyChangeText;
    public GameObject moneyChange;

    private int numCompl;
    private int numDrinks;
    private int totMoney;

    public void onClick()
    {
        if (sweetCheck.activeSelf && cuteCheck.activeSelf && costCheck.activeSelf)
        {
            numCompl += 1;
            totMoney += drink.getMoney();
            moneyCounter.text = "$ " + totMoney;
            moneyChangeText.text = "+ $ " + drink.getMoney();

            moneyChange.GetComponent<CanvasGroup>().alpha = 1;
            LeanTween.alphaCanvas(moneyChange.GetComponent<CanvasGroup>(), 0f, 0.5f).setEaseOutQuad();
            LeanTween.moveY(moneyChange.GetComponent<RectTransform>(), moneyChange.GetComponent<RectTransform>().anchoredPosition.y + 50f, 1f).setEaseOutQuad();

        }

        drink.resetDrink();
        Order newOrder = Instantiate(orderTemp);

        order.setOrder(newOrder);
      

        
        numDrinks += 1;

    }

    public int getNumComp()
    {
        return numCompl;
    }

    public int getNumDrinks()
    {
        return numDrinks;
    }

    public int getTotalMoney()
    {
        return totMoney;
    }
}
