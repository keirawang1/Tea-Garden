using UnityEngine;
using TMPro;

public class AddIngredient : MonoBehaviour
{
    public Drink drink;
    public IngredientManager select;
    public GameObject AttributeDisplay;
    public OrderDisplay check;
    public TeaMaterialLibrary teaLibrary;
    public SFXUI sfx;

    public GameObject warningIcon;
    public GameObject warningText;
    public TMP_Text warnMsg;

    public void OnClick()
    {
        warningText.SetActive(false);
        warningIcon.SetActive(false);

        Ingredient ingredient = select.currIngredient;
        
        if (ingredient == null) {
                return;
        }

        if (drink.cupSize == null && ingredient.type != IngredientType.Cup)
        {
            Debug.LogWarning("Must add a cup first!");
            warningIcon.SetActive(true);
            warnMsg.text = "Add a cup first!";
            warningText.GetComponent<UIPop>().Show();

            return;
        }

        if (drink.cupSize != null && ingredient.type == IngredientType.Cup) {
            Debug.LogWarning("already added a cup");
            warningIcon.SetActive(true);
            warnMsg.text = "You already have a cup!";
            warningText.GetComponent<UIPop>().Show();

            return;
        }    

        if (drink.teaBase != null && ingredient.type == IngredientType.Tea) {
            Debug.LogWarning("already added a tea");
            warningIcon.SetActive(true);
            warnMsg.text = "There is already tea in the cup!";
            warningText.GetComponent<UIPop>().Show();

            return;
        }

        if (drink.topping != null && ingredient.type == IngredientType.Topping) {
            Debug.LogWarning("already added a topping");
            warningIcon.SetActive(true);
            warnMsg.text = "You already have a topping in the cup!";
            warningText.GetComponent<UIPop>().Show();

            return;
        }

        if (drink.decoration1 != null && ingredient.type == IngredientType.Decoration1) {
            Debug.LogWarning("already added a deco1");
            warningIcon.SetActive(true);
            warnMsg.text = "You already have a lid!";
            warningText.GetComponent<UIPop>().Show();

            return;
        }

        if (drink.decoration2 != null && ingredient.type == IngredientType.Decoration2) {
            Debug.LogWarning("already added a deco2");
            warningIcon.SetActive(true);
            warnMsg.text = "You already have a straw!";
            warningText.GetComponent<UIPop>().Show();

            return;
        }

        switch (ingredient.type)
        {
            case IngredientType.Cup:
                drink.cupSize = ingredient;
                drink.size = ingredient.size;
                sfx.switchSound(0);
                break;
            case IngredientType.Tea:
                if (drink.cupSize == null)
                {
                    Debug.LogWarning("Must add a cup first!");
                    warningIcon.SetActive(true);
                    warnMsg.text = "Add a cup first!";
                    warningText.GetComponent<UIPop>().Show();
                    break;
                }
                drink.teaBase = ingredient;
                sfx.switchSound(1);
                break;
            case IngredientType.Topping:
                if (drink.cupSize == null)
                {
                    Debug.LogWarning("Must add a cup first!");
                    warningIcon.SetActive(true);
                    warnMsg.text = "Add a cup first!";
                    warningText.GetComponent<UIPop>().Show();
                    break;
                }
                sfx.switchSound(0);
                drink.topping = ingredient;
                break;
            case IngredientType.Decoration1:
                if (drink.cupSize == null)
                {
                    Debug.LogWarning("Must add a cup first!");
                    warningIcon.SetActive(true);
                    warnMsg.text = "Add a cup first!";
                    warningText.GetComponent<UIPop>().Show();
                    break;
                }
                sfx.switchSound(0);
                drink.decoration1 = ingredient;
                break;
            case IngredientType.Decoration2:
                if (drink.cupSize == null)
                {
                                Debug.LogWarning("Must add a cup first!");
            warningIcon.SetActive(true);
            warnMsg.text = "Add a cup first!";
            warningText.GetComponent<UIPop>().Show();
                    break;
                }
                sfx.switchSound(0);
                drink.decoration2 = ingredient;
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

        AttributeDisplay.GetComponent<UISlide>().Hide();

        drink.cutenessTotal += ingredient.cuteness;
        drink.sweetnessTotal += ingredient.sweetness;
        drink.costTotal += ingredient.cost;
        check.Refresh();
    }
}
