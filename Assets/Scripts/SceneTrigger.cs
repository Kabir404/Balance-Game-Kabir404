using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneTrigger : MonoBehaviour
{
    public int sceneIndex;
    public bool hasEndscreen;
    public GameObject Endscreen;
    public bool disableObject;
    public GameObject objectToDisable;
    void OnTriggerEnter(Collider other)
    {
      if (hasEndscreen == true)
        {
            
            Time.timeScale = 0;
            Endscreen.SetActive(true);

        } else
        {
            SceneManager.LoadScene(sceneIndex);
        }

      if (disableObject == true)
        {
            objectToDisable.SetActive(false);
        }
        else
        {
            objectToDisable.SetActive(true);
        }
    }
}
