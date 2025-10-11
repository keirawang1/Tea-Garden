using UnityEngine;

public class ShowMenuOnClick : MonoBehaviour
{

    [SerializeField] private GameObject menuToShow;
    [SerializeField] private MenuManager manager;

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnMouseDown()
    {
        if (manager != null && menuToShow != null)
        {
            manager.ShowMenu(menuToShow);
        }
    }

}
