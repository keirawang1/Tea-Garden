using UnityEngine;

public class AddIngredient : MonoBehaviour
{
    public Drink drink;
    public IngredientManager select;
    public GameObject AttributeDisplay;
    public OrderDisplay check;

    public void OnClick()
    {
        AttributeDisplay.GetComponent<UISlide>().Hide();

        Ingredient ingredient = select.currIngredient;
        
        if (ingredient == null) {
                return;
        }

        if (drink.cupSize == null && ingredient.type != IngredientType.Cup)
        {
            Debug.LogWarning("Must add a cup first!");
            return;
        }

        if (drink.cupSize != null && ingredient.type == IngredientType.Cup) {
            Debug.LogWarning("already added a cup");
            return;
        }    

        if (drink.teaBase != null && ingredient.type == IngredientType.Tea) {
            Debug.LogWarning("already added a tea");
            return;
        }

        if (drink.topping != null && ingredient.type == IngredientType.Topping) {
            Debug.LogWarning("already added a topping");
            return;
        }

        switch (ingredient.type)
        {
            case IngredientType.Cup:
                drink.cupSize = ingredient;
                drink.size = ingredient.size;
                break;
            case IngredientType.Tea:
                if (drink.cupSize == null)
                {
                    Debug.LogWarning("must add a cup first!");
                    break;
                }
                drink.teaBase = ingredient;
                break;
            case IngredientType.Topping:
                if (drink.cupSize == null)
                {
                    Debug.LogWarning("must add a cup first!");
                    break;
                }
                drink.topping = ingredient;
                break;
            case IngredientType.Decoration:
                if (drink.cupSize == null)
                {
                    Debug.LogWarning("must add a cup first!");
                    break;
                }
                drink.decoration = ingredient;
                break;
        }

        SceneIngredient[] sceneIngredients = Resources.FindObjectsOfTypeAll<SceneIngredient>();
        foreach (var sceneIngredient in sceneIngredients)
        {
            if (sceneIngredient.ingredientData == ingredient) {
                // Only enable if the cup size matches
                if (sceneIngredient.size == drink.size || (sceneIngredient.size == SizeType.Both))
                    sceneIngredient.gameObject.SetActive(true);
                else
                    sceneIngredient.gameObject.SetActive(false);
            }
        }
    
        drink.cutenessTotal += ingredient.cuteness;
        drink.sweetnessTotal += ingredient.sweetness;
        drink.costTotal += ingredient.cost;
        check.Refresh();
    }
}
