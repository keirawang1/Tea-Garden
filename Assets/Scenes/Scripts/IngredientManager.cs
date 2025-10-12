using UnityEngine;

public class IngredientManager : MonoBehaviour
{
    public Ingredient currIngredient;

    public void SelectIngredient(Ingredient ingredient)
    {
        currIngredient = ingredient;
    }
        
}
