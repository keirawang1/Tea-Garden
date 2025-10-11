using UnityEngine;

[CreateAssetMenu(menuName = "Scriptable Objects/Drink")]
public class Drink : ScriptableObject
{
    public Ingredient cupSize;
    public Ingredient teaBase;
    public Ingredient topping;
    public Ingredient decoration;
}
