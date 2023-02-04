using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManager : MonoBehaviour
{
    static public void ChangeScene(string _sceneName)
    {
        SceneManager.LoadScene(_sceneName, LoadSceneMode.Single);
    }

    private void Update()
    {
        if (Input.GetKey(KeyCode.Escape))
        {
            Application.Quit();
        }
        if (Input.GetKey(KeyCode.Delete))
        {
            SceneManager.LoadScene("MainScene");
        }
    }
}
