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
            source.PlayOneShot(soundVer2);
        }
        else
        {
            source.PlayOneShot(sound);
        }

    }
}
