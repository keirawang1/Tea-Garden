using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class AttributeDisplay : MonoBehaviour
{
    public Ingredient ingredient;

    public TMP_Text nameText;
    public TMP_Text cutenessText;
    public TMP_Text sweetnessText;
    public TMP_Text costText;
    public Image icon;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        nameText.text = ingredient.name;
        cutenessText.text = ingredient.cuteness.ToString();
        sweetnessText.text = ingredient.sweetness.ToString();
        costText.text = ingredient.cost.ToString();
        icon.sprite = ingredient.icon;
        
    }
}
