using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;


[CreateAssetMenu(menuName = "Scriptable Objects/Order")]
public class Order : ScriptableObject
{
    public int randCuteMin;
    public int randCuteMax;
    public int randSweetMin;
    public int randSweetMax;
    public int randCostMin;
    public int randCostMax;


    int cutenessMin;
    int cutenessMax;
    int sweetnessMin;
    int sweetnessMax; 
    int costMin;
    int costMax;


    public void OnEnable() {

        cutenessMin = Random.Range(randCuteMin, randCuteMax);
        cutenessMax = Random.Range(cutenessMin, cutenessMin + 5);

        sweetnessMin = Random.Range(randSweetMin, randSweetMax);
        sweetnessMax = Random.Range(sweetnessMin, sweetnessMin + 5);

        costMin = Random.Range(randCostMin, randCostMax);
        costMax = Random.Range(costMin, costMin + 5);
    }


    public (int, int) getCuteness() {
        return (cutenessMin, cutenessMax);
    }

    public (int, int) getSweetness() { 
        return (sweetnessMin, sweetnessMax);
    }

    public (int, int) getCost()
    {
        return (costMin, costMax);
    }



}
