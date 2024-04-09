using UnityEngine;
using UnityEngine.Audio;

public class Menu : MonoBehaviour
{
    [SerializeField] private AudioMixerGroup _mixer;

    private const string MasterVolume = "MasterVolume";
    private const string MusicVolume = "MusicVolume";
    private const string ButtonVolume = "ButtonVolume";

    private bool _isVolumeOn = true;
    private float _volume;
    private float _minVolume = -45;

    public void ToggleMusic()
    {
        float volume;

        _isVolumeOn = !_isVolumeOn;

        if (!_isVolumeOn)
            volume = -80;
        else
            volume = _volume;

        _mixer.audioMixer.SetFloat(MasterVolume, volume);
    }

    public void ChangeMasterVolume(float volume)
    {
        _volume = Mathf.Lerp(_minVolume, 0, volume);

        if (_isVolumeOn)
            _mixer.audioMixer.SetFloat(MasterVolume, _volume);
    }

    public void ChangeMusicVolume(float volume)
    {
        _mixer.audioMixer.SetFloat(MusicVolume, Mathf.Lerp(_minVolume, 0, volume));
    }
    public void ChangeButtonVolume(float volume)
    {
        _mixer.audioMixer.SetFloat(ButtonVolume, Mathf.Lerp(_minVolume, 0, volume));
    }
}
