using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public GameObject submitButton;
    public DrinkManager drink;
    public OrderDisplay order;
    public GameObject sweetCheck;
    public GameObject cuteCheck;
    public GameObject costCheck;
    public Order orderTemp;

    private int numCompl;
    private int numDrinks;
    private int totMoney;

    public void onClick()
    {
        if (sweetCheck.activeSelf && cuteCheck.activeSelf && costCheck.activeSelf)
        {
            numCompl += 1;
        }
        totMoney += drink.getMoney();
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
