using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class AttributeDisplay : MonoBehaviour
{
    public Ingredient ingredient;
    public Drink drink;
    public TMP_Text nameText;
    public TMP_Text cutenessValue;
    public TMP_Text sweetnessValue;
    public TMP_Text costValue;
    public TMP_Text cutenessTotal;
    public TMP_Text sweetnessTotal;
    public TMP_Text costTotal;

    // Display the values on the attribute menu once button is clicked
    void Start()
    {
        nameText.text = ingredient.name;
        cutenessValue.text = ingredient.cuteness.ToString();
        sweetnessValue.text = ingredient.sweetness.ToString();
        costValue.text = ingredient.cost.ToString();
        cutenessTotal.text = (drink.cutenessTotal + ingredient.cuteness).ToString();
        sweetnessTotal.text = (drink.sweetnessTotal + ingredient.sweetness).ToString();
        costTotal.text = (drink.costTotal + ingredient.cost).ToString();

    }
}
