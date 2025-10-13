using UnityEngine;

public class TrashButton : MonoBehaviour
{
    public GameObject buttonToShow;


    // Update is called once per frame
    public void OnClickShowButton()
    {
        if (buttonToShow != null)
        {
            buttonToShow.GetComponent<UIPop>().PopIn();
        }
    }
}
