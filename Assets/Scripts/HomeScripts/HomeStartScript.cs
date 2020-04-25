using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeStartScript : MonoBehaviour
{
    public void ChangeScene(String sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
