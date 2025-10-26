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

    public void onClick()
    {
        drink.resetDrink();
        Order newOrder = Instantiate(orderTemp);
        order.setOrder(newOrder);
      

        if (sweetCheck.activeSelf && cuteCheck.activeSelf && costCheck.activeSelf)
        {
            numCompl += 1;
        }
        numDrinks += 1;
    }
}
