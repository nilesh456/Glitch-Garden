using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ObjectController : MonoBehaviour {

    public Slider volumeSlider, difficultySlider;
    public LevelManager levelManager;

    private MusicPlayer musicPlayer;

	// Use this for initialization
	void Start () {
        musicPlayer = GameObject.FindObjectOfType<MusicPlayer>();

        volumeSlider.value = PlayerPrefsManager.GetMasterVolume();
        difficultySlider.value = PlayerPrefsManager.GetDifficulty();
	}
	
	// Update is called once per frame
	void Update () {
        musicPlayer.SetVolume(volumeSlider.value);
		
	}

    public void SaveAndExit()
    {
        PlayerPrefsManager.SetMasterVolume(volumeSlider.value);
        PlayerPrefsManager.SetDifficulty(difficultySlider.value);
        levelManager.LoadLevel("Start Screen");
    }

    public void SetDefaults ()
    {
        volumeSlider.value = 0.08f;
        difficultySlider.value = 2f;
    }
}
