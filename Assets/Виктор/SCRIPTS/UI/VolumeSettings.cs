using UnityEngine;
using UnityEngine.Audio;

public class VolumeSettings : MonoBehaviour
{
    [SerializeField] private AudioMixer _audioMixer;

    public void SetVolume(float value)
    {
        _audioMixer.SetFloat("Volume", Mathf.Log(value) * 20);
    }
}