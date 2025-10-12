using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class OrderDisplay : MonoBehaviour
{
    public Order order;
    public Drink drink;

    public TMP_Text cutenessText;
    public TMP_Text sweetnessText;
    public TMP_Text costText;

    public GameObject cuteCheck;
    public GameObject cuteX;
    public GameObject sweetCheck;
    public GameObject sweetX;
    public GameObject costCheck;
    public GameObject costX;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        cutenessText.text = order.cutenessMin.ToString() + " - " + order.cutenessMax.ToString();
        sweetnessText.text = order.sweetnessMin.ToString() + " - " + order.sweetnessMax.ToString();
        costText.text = order.costMin.ToString() + " - " + order.costMax.ToString();
        check();
    }

    public void Refresh()
    {
        check();
    }
    
    void check()
    {

        if (drink.cutenessTotal >= order.cutenessMin && drink.cutenessTotal <= order.cutenessMax)
        {
            cuteCheck.SetActive(true);
            cuteX.SetActive(false);
        } else
        {
            cuteCheck.SetActive(false);
            cuteX.SetActive(true);
        }

        if (drink.sweetnessTotal >= order.sweetnessMin && drink.sweetnessTotal <= order.sweetnessMax)
        {
            sweetCheck.SetActive(true);
            sweetX.SetActive(false);
        } else
        {
            sweetCheck.SetActive(false);
            sweetX.SetActive(true) ;
        }

        if (drink.costTotal >= order.costMin && drink.costTotal <= order.costMax)
        {
            costCheck.SetActive(true);
            costX.SetActive(false);
        } else { 
            costCheck.SetActive(false);
            costX.SetActive(true); 
        }
    }
}
