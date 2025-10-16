using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;



public enum IngredientType { Cup, Tea, Topping, Decoration }
public enum SizeType {Large, Small, Both, None}


[CreateAssetMenu(menuName = "Ingredient")]
public class Ingredient : ScriptableObject
{
    public string ingredientName;
    public Sprite icon;
    public int cuteness;
    public int sweetness;
    public int cost;
    public IngredientType type;
    public SizeType size;
}
