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
       
        if (ingredient != null)
        {
            SceneIngredient[] sceneIngredients = FindObjectsOfType<SceneIngredient>(true); // include inactive
            foreach (var sceneIngredient in sceneIngredients)
            {
                if (sceneIngredient.ingredientData == ingredient)
                {
                    sceneIngredient.gameObject.SetActive(true);
                    break;
                }
            }

            switch (ingredient.type)
            {
                case IngredientType.Cup:
                    drink.cupSize = ingredient;
                    break;
                case IngredientType.Tea:
                    drink.teaBase = ingredient;
                    break;
                case IngredientType.Topping:
                    drink.topping = ingredient;
                    break;
                case IngredientType.Decoration:
                    drink.decoration = ingredient;
                    break;
            }
            drink.cutenessTotal += ingredient.cuteness;
            drink.sweetnessTotal += ingredient.sweetness;
            drink.costTotal += ingredient.cost;
        }
        check.Refresh();
    }
}
