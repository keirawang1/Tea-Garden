using UnityEngine;

public class DrinkManager : MonoBehaviour
{
    public Drink drink;

    void Start()
    {
        resetDrink();

    }

    public void resetDrink()
    {
        drink.cutenessTotal = 0;
        drink.sweetnessTotal = 0;
        drink.costTotal = 0;
    }
}
