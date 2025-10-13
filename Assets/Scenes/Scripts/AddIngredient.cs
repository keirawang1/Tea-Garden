using UnityEngine;

public class AddIngredient : MonoBehaviour
{
    public Drink drink;
    public Ingredient ingredient;
    public IngredientManager select;
    public GameObject AttributeDisplay;
    public OrderDisplay check;

    public void OnClick()
    {
        AttributeDisplay.GetComponent<UISlide>().Hide();

        ingredient = select.currIngredient;
       
        if (ingredient != null)
        {
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
