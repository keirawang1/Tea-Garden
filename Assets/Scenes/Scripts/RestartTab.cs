using UnityEngine;

public class RestartTab : MonoBehaviour
{
    public DrinkManager manager;
    public GameObject restartMenu;
    public bool restart;
    public GameObject attributeMenu;
    public OrderDisplay check;
    public GameObject orderScreen;

    public void onClick()
    {
        restartMenu.GetComponent<UIPop>().Hide();
        if (restart)
        {
            orderScreen.GetComponent<UIPop>().Show();
            manager.resetDrink();
            attributeMenu.SetActive(false);
            check.Refresh();
        }

    }
}
