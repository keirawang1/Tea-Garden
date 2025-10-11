using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class IngredientDisplay : MonoBehaviour { 

    public Ingredient ingredient;

    public TMP_Text nameText;
    public Image icon;

    // display the ingredient on the ingredient menu (list)
    void Start()
    {
        nameText.text = ingredient.name;
        icon.sprite = ingredient.icon;

    }
}
