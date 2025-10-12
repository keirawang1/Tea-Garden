using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


[CreateAssetMenu(menuName = "Scriptable Objects/Order")]
public class Order : ScriptableObject
{

    public int cutenessMin = 0;
    public int cutenessMax = 0;
    public int sweetnessMin = 0;
    public int sweetnessMax = 0; 
    public int costMin = 0;
    public int costMax = 0;

}
