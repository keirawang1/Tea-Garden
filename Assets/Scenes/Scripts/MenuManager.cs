using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject[] menus;
    private GameObject currentMenu;

    public void ShowMenu(GameObject menuToShow)
    {
        foreach (GameObject menu in menus)
        {
            if (menu != null)
            {
                menu.SetActive(false);
            }

            if (menuToShow != null)
            {
                menuToShow.SetActive(true);
                currentMenu = menuToShow;

            }
        }
    }
}
