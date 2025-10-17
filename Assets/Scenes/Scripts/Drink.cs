using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

[CreateAssetMenu(menuName = "Scriptable Objects/Drink")]
public class Drink : ScriptableObject
{
    public Ingredient cupSize;
    public Ingredient teaBase;
    public Ingredient topping;
    public Ingredient decoration1;
    public Ingredient decoration2;
    public SizeType size = SizeType.None;
    public int cutenessTotal = 0;
    public int sweetnessTotal = 0;
    public int costTotal = 0;
}
