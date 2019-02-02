using UnityEngine;
using System.Collections;

public class MusicPlayer : MonoBehaviour {

    public AudioClip[] levelAudioManagerArray;

    private AudioSource audioSource;

    void Awake () {
        DontDestroyOnLoad(gameObject);
        Debug.Log("music loaded : " + name);

    }

     void Start()
    {
        audioSource = GetComponent<AudioSource>();
        audioSource.volume = PlayerPrefsManager.GetMasterVolume();
    }

    private void OnLevelWasLoaded(int level)
    {
        AudioClip thisLevelMusic = levelAudioManagerArray[level];
        Debug.Log("Playing Clip : " + thisLevelMusic);
        if (thisLevelMusic)                                         
        {
            audioSource.clip = thisLevelMusic;
            audioSource.loop = true;
            audioSource.Play();
        }
    }

    public void SetVolume (float volume)
    {
        audioSource.volume = volume;
    }

}
