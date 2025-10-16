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
        resetPrefab(drink.cupSize);
        resetPrefab(drink.teaBase);
        resetPrefab(drink.topping);
        resetPrefab(drink.decoration);
        drink.cupSize = null;
        drink.teaBase = null;
        drink.topping = null;
        drink.decoration = null;
        drink.size = SizeType.None;

    }

    private void resetPrefab(Ingredient ingredient) {
        SceneIngredient[] sceneIngredients = Resources.FindObjectsOfTypeAll<SceneIngredient>();
        foreach (var sceneIngredient in sceneIngredients)
        {
            if (sceneIngredient.ingredientData == ingredient) {
                sceneIngredient.gameObject.SetActive(false);
            }
        }
    }
}
