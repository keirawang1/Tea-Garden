using UnityEngine;

public class SFXUI : MonoBehaviour
{

    public AudioClip sound;
    public GameObject button;

    public AudioClip soundVer2;
    private AudioSource source;



    void Start()
    {
        source = button.GetComponent<AudioSource>();
    }

    public void OnClick()
    {
        source.PlayOneShot(sound);
    }

    public void switchSound(int audioVer)
    {
        if (audioVer == 1)
        {
            AudioSource.PlayClipAtPoint(soundVer2, Camera.main.transform.position);
        }
        else
        {
            AudioSource.PlayClipAtPoint(sound, Camera.main.transform.position);
        }

    }
}
