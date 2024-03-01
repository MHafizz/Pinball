using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AudioManager : MonoBehaviour
{
    // Start is called before the first frame update
    public AudioSource bgmAudioSource;
    public GameObject sfxAudioSourceBumper;
    public GameObject sfxAudioSourceSwitch;

    private AudioSource currentSFXBumper;
    private AudioSource currentSFXSwitch;
    private void Start()
    {
        PlayBGM();
    }
    private void PlayBGM()
    {
        bgmAudioSource.Play();
    }

    public void PlaySFXBumper(Vector3 spawnPosition)
    {
        // if (currentSFXBumper != null)
        //     Destroy(currentSFXBumper.gameObject);
        GameObject.Instantiate(sfxAudioSourceBumper, spawnPosition, Quaternion.identity);
    }

    public void PlaySFXSwitch(Vector3 spawnPosition)
    {
        // if (currentSFXSwitch != null)
        //     Destroy(currentSFXSwitch.gameObject);
        GameObject.Instantiate(sfxAudioSourceSwitch, spawnPosition, Quaternion.identity);
    }


}
