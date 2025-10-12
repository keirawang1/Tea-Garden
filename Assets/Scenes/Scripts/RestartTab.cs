using UnityEngine;

public class RestartTab : MonoBehaviour
{
    public DrinkManager manager;
    public GameObject restartMenu;
    public bool restart;
    public GameObject attributeMenu;
    public OrderDisplay check;

    public void onClick()
    {
        restartMenu.SetActive(false);
        if (restart)
        {
            manager.resetDrink();
            attributeMenu.SetActive(false);
            check.Refresh();
        }

    }
}
