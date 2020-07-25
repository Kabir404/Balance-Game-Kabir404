using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;
using UnityEngine.UI;

public class OptionsManeger : MonoBehaviour
{
    public AudioMixer mainMixer;
    public Dropdown resolutionDropdown;
    public int screenWidth;
    public int screenHeight;
    public int quality;
    public bool isFullscreen;


    Resolution[] resolutions;

    public void SetVolume (float volume)
    {
        mainMixer.SetFloat("Volume", volume);
        PlayerPrefs.SetFloat("volume", volume);
        PlayerPrefs.Save();
    }

    public void SetQuality(int qualtyIndex)
    {
        QualitySettings.SetQualityLevel(qualtyIndex);
        quality = qualtyIndex;
        PlayerPrefs.SetInt("quality", quality);
        PlayerPrefs.Save();
    }

    public void SetFullscreen(bool isFullscreen)
    {
        Screen.fullScreen = isFullscreen;
        PlayerPrefs.SetInt("isfullscreen", (isFullscreen ? 1 : 0));
        PlayerPrefs.Save();
    }


    public void SetResolution(int ResolutionIndex)
    {
        Resolution resolution = resolutions[ResolutionIndex];
        Screen.SetResolution(resolution.width, resolution.height, Screen.fullScreen);
        screenWidth = resolution.width;
        screenHeight = resolution.height;
        PlayerPrefs.SetInt("screenWidth", screenWidth);
        PlayerPrefs.SetInt("screenHeight", screenHeight);
        PlayerPrefs.Save();
    }

    void Start()
    {
        int currentResolutionIndex = 0;


        resolutions = Screen.resolutions;
        resolutionDropdown.ClearOptions();
        List<string> options = new List<string>();

        for (int i = 0; i < resolutions.Length; i++)
        {
            string option = resolutions[i].width + "x" + resolutions[i].height;
            options.Add(option);

            if (resolutions[i].width == Screen.currentResolution.width && resolutions[i].height == Screen.currentResolution.height)
            {
                currentResolutionIndex = i;
            }
        }

        resolutionDropdown.AddOptions(options);
        resolutionDropdown.value = currentResolutionIndex;
        resolutionDropdown.RefreshShownValue();
        
    }
}
