using UnityEngine;

public class DrinkManager : MonoBehaviour
{
    public Drink drink;

    void Start()
    {
        resetDrink();

    }

    public int getMoney()
    {
        return drink.costTotal;
    }

    public void resetDrink()
    {
        drink.cutenessTotal = 0;
        drink.sweetnessTotal = 0;
        drink.costTotal = 0;
        resetPrefab(drink.cupSize);
        resetPrefab(drink.teaBase);
        resetPrefab(drink.topping);
        resetPrefab(drink.decoration1);
        resetPrefab(drink.decoration2);
        drink.cupSize = null;
        drink.teaBase = null;
        drink.topping = null;
        drink.decoration1 = null;
        drink.decoration2 = null;
        drink.size = SizeType.None;
        
    }

    private void resetPrefab(Ingredient ingredient) {
        SceneIngredient[] sceneIngredients = Resources.FindObjectsOfTypeAll<SceneIngredient>();
        foreach (var sceneIngredient in sceneIngredients)
        {
            if (sceneIngredient.ingredientData == ingredient) {
                sceneIngredient.gameObject.SetActive(false);
            }
            if (sceneIngredient.ingredientData.type == IngredientType.Tea) {
                foreach (var s in sceneIngredients)
                {
                    if (s.ingredientData.ingredientName == "None") {
                        sceneIngredient.ingredientData = s.ingredientData;
                        sceneIngredient.gameObject.SetActive(false);
                    }
                }
            }
        }
    }
}
