using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public GameObject submitButton;
    public DrinkManager manager;
    public OrderDisplay order;
    public GameObject sweetCheck;
    public GameObject cuteCheck;
    public GameObject costCheck;

    private int numCompl;
    private int numDrinks;

    public void onClick()
    {
        Order newOrder = ScriptableObject.CreateInstance<Order>();
        order.setOrder(newOrder);
        manager.resetDrink();
        if (sweetCheck.activeSelf && cuteCheck.activeSelf && costCheck.activeSelf)
        {
            numCompl += 1;
        }
        numDrinks += 1;
    }
}
