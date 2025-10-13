using UnityEngine;

public class MenuManager : MonoBehaviour
{
    public GameObject[] menus;
    private GameObject currentMenu;
    public GameObject bgMenu;

    public void ShowMenu(GameObject menuToShow)
    {
        bgMenu.GetComponent<UISlide>().Show();
        foreach (GameObject menu in menus)
        {
            if (menu != null)
            {
                menu.SetActive(false);
                            }
            if (menuToShow != null)
            {
                menuToShow.SetActive(true);
                //menuToShow.GetComponent<UISlide>().Show();
                currentMenu = menuToShow;

            }

        }
        
    }
}
