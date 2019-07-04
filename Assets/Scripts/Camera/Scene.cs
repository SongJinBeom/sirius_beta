using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Scene : MonoBehaviour
{
    public string sceneName;
  
    public void SceneChange(string sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }

    public void MoveToMain()
    {
        Destroy(GameObject.Find("Mary"));
      // Destroy(GameObject.Find("Main Camera"));
        SceneManager.LoadScene("MainMenu");
    }
}
