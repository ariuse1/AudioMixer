using UnityEngine;

public class AudioBotton : MonoBehaviour
{
    [SerializeField] AudioSource _sound;

    public void PlayClick()
    {
        _sound.Play();
    }
}
