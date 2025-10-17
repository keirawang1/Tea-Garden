using UnityEngine;

public class AddIngredient : MonoBehaviour
{
    public Drink drink;
    public IngredientManager select;
    public GameObject AttributeDisplay;
    public OrderDisplay check;
    public TeaMaterialLibrary teaLibrary;

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
            if (ingredient.type == IngredientType.Tea && sceneIngredient.size == drink.size 
            && sceneIngredient.ingredientData.ingredientName == "None") {
                    sceneIngredient.ingredientData = ingredient;
                    sceneIngredient.gameObject.SetActive(true);
                    Material mat = null;
                    foreach (TeaMaterialEntry entry in teaLibrary.entries)
                    {
                        if (entry.teaName == ingredient.ingredientName)
                        {
                            mat = entry.material;
                        }
                        if (mat != null)
                        {
                            Renderer renderer = sceneIngredient.GetComponent<Renderer>();
                            if (renderer != null) {
                                renderer.material = mat;
                                break;
                            }
                        }
                    }
            }
            else if (sceneIngredient.ingredientData == ingredient) {
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
