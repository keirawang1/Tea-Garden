using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


[CreateAssetMenu(menuName = "Scriptable Objects/Order")]
public class Order : ScriptableObject
{

    public int cutenessMin;
    public int cutenessMax;
    public int sweetnessMin;
    public int sweetnessMax; 
    public int costMin;
    public int costMax;

}
