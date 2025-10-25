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


    (int min, int max) cute;
    (int min, int max) sweet;
    (int min, int max) cost;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        updateVal(order.getCuteness(), order.getSweetness(), order.getCost());
        check();
    }

    public void Refresh()
    {
        check();
    }
    
    void check()
    {

        if (drink.cutenessTotal >= cute.min && drink.cutenessTotal <= cute.max)
        {
            cuteCheck.SetActive(true);
            cuteX.SetActive(false);
        } else
        {
            cuteCheck.SetActive(false);
            cuteX.SetActive(true);
        }

        if (drink.sweetnessTotal >= sweet.min && drink.sweetnessTotal <= sweet.max)
        {
            sweetCheck.SetActive(true);
            sweetX.SetActive(false);
        } else
        {
            sweetCheck.SetActive(false);
            sweetX.SetActive(true) ;
        }

        if (drink.costTotal >= cost.min && drink.costTotal <= cost.max)
        {
            costCheck.SetActive(true);
            costX.SetActive(false);
        } else { 
            costCheck.SetActive(false);
            costX.SetActive(true); 
        }
    }
    
    void updateVal((int min, int max) ct , (int min, int max) st, (int min, int max) cst)
    {
        cute = ct;
        sweet = st;
        cost = cst;
        cutenessText.text = cute.min.ToString() + " - " + cute.max.ToString();
        sweetnessText.text = sweet.min.ToString() + " - " + sweet.max.ToString();
        costText.text = cost.min.ToString() + " - " + cost.max.ToString();
    }

    public void setOrder(Order o)
    {
        order = o;
    }
}

    
