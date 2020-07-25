using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManeger : MonoBehaviour
{
    public int level01Index;
    public int level02Index;
    public int level03Index;
    public int menuIndex;
    public bool showVersion;
    public GameObject versionInfo;

    public void QuitGame()
    {
        Debug.Log("QUIT!");
        Application.Quit();
    }

    public void LoadLevel01()
    {
        SceneManager.LoadScene(level01Index);
        Time.timeScale = 1;
    }
    public void LoadLevel02()
    {
        SceneManager.LoadScene(level02Index);
        Time.timeScale = 1;
    }
    public void LoadLevel03()
    {
        SceneManager.LoadScene(level03Index);
        Time.timeScale = 1;
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene(menuIndex);
        Time.timeScale = 1;
    }
public void ReloadLevel()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
        Time.timeScale = 1;
    }
    public void ResumeTime()
    {
        Time.timeScale = 1.0f;
        
    }
    public void FreezeTime()
    {
        Time.timeScale = 0f;
    }
    void LateUpdate() {
        versionInfo.GetComponent<UnityEngine.UI.Text>().text = Application.version.ToString();

    }
}
