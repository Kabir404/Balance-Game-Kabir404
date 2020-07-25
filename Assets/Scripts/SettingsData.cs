using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class SettingsData : MonoBehaviour
{
    public AudioMixer mainMixer;

    public GameObject settingsPanel;
    public GameObject menuPanel;

    public Dropdown resolutionDropdown;
    public Dropdown graphicsDropdown;
    public Slider volumeSlider;
    public Toggle fullscreenToggle;


    private bool isfullscreen;

    void Start()


    {
        if (!PlayerPrefs.HasKey("screenHeight"))
        {
            PlayerPrefs.SetInt("screenHeight", Screen.height);
            PlayerPrefs.Save();
        }
        if(!PlayerPrefs.HasKey("screenWidth"))
        {
            PlayerPrefs.SetInt("screenWidth", Screen.width);
            PlayerPrefs.Save();
        }
        if (!PlayerPrefs.HasKey("volume"))
        {
            mainMixer.SetFloat("Volume", 0);
            PlayerPrefs.Save();
        }
        if (!PlayerPrefs.HasKey("quality"))
        {
            PlayerPrefs.SetInt("quality", 0);
            PlayerPrefs.Save();
        }
        settingsPanel.gameObject.SetActive(true);

        isfullscreen = ( PlayerPrefs.GetInt("isfullscreen") != 0 );
        fullscreenToggle.isOn = PlayerPrefs.GetInt("isfullscreen") != 0;

        graphicsDropdown.value = (PlayerPrefs.GetInt("quality"));
        QualitySettings.SetQualityLevel(PlayerPrefs.GetInt("quality"));

        Screen.SetResolution(PlayerPrefs.GetInt("screenWidth"), PlayerPrefs.GetInt("screenHeight"), isfullscreen);

        mainMixer.SetFloat("Volume", PlayerPrefs.GetFloat("volume"));
        volumeSlider.value = PlayerPrefs.GetFloat("volume");
        settingsPanel.gameObject.SetActive(false);
    }
}
