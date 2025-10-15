using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;



public enum IngredientType { Cup, Tea, Topping, Decoration }


[CreateAssetMenu(menuName = "Ingredient")]
public class Ingredient : ScriptableObject
{
    public string ingredientName;
    public Sprite icon;
    public GameObject prefabL;
    public GameObject prefabS;
    public int cuteness;
    public int sweetness;
    public int cost;
    public IngredientType type;
}
