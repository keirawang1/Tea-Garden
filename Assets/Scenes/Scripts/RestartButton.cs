using UnityEngine;

public class RestartButton : MonoBehaviour
{
    public GameObject buttonToShow;


    // Update is called once per frame
    public void OnClickShowButton()
    {
        if (buttonToShow != null)
        {
            buttonToShow.SetActive(true);
        }
    }
}
