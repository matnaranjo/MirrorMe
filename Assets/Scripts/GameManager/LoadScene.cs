using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScene : MonoBehaviour
{
    public void LoadLevelByName(string SceneName)
    {
        // Time.timeScale = 1;
        SceneManager.LoadScene(SceneName);
    }
}
