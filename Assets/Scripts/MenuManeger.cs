using UnityEngine;
using UnityEngine.SceneManagement;
public class MenuManeger : MonoBehaviour
{
    public int menuIndex;
    public bool showVersion;
    public GameObject versionInfo;

    public void QuitGame()
    {
        //Log file and then stop the engine and quit the application
        Debug.Log("QUIT!");
        Application.Quit();
    }

    public void LoadNextLevel()
    {
        //Get currently active scene
        int ActiveScene = SceneManager.GetActiveScene().buildIndex;
        //Load the next scene by adding +1 to the current scene index
        SceneManager.LoadScene(ActiveScene + 1);
        FreezeTime(false);
    }

    public void LoadPrevLevel()
    {
        //Get currently active scene
        int ActiveScene = SceneManager.GetActiveScene().buildIndex;
        //Load the previous scene by adding -1 to the current scene index
        SceneManager.LoadScene(ActiveScene - 1);
        FreezeTime(false);
    }

    public void ReloadLevel()
    {
        //Get currently active scene
        int ActiveScene = SceneManager.GetActiveScene().buildIndex;
        //Reload the current scene
        SceneManager.LoadScene(ActiveScene);
        FreezeTime(false);
    }
    public void LoadMenu()
    {
        //Load the menu scene by menu index
        SceneManager.LoadScene(menuIndex);
        FreezeTime(false);
    }
    public void FreezeTime(bool FreezeTime)
    {
        //Freeze the time if the value is true otherwise dont
        if (FreezeTime)
        {
            Time.timeScale = 0f;
        } else
        {
            Time.timeScale = 1.0f;
        }
        
    }
    //Updates lately when the frame is just finished
    void LateUpdate() {
        //Get the current build version
        versionInfo.GetComponent<UnityEngine.UI.Text>().text = Application.version.ToString();
    }
}
