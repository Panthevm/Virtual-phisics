using System;
using UnityEngine;
using UnityEngine.SceneManagement;

public class HomeStart : MonoBehaviour
{
    public void ChangeScene(String sceneName)
    {
        SceneManager.LoadScene(sceneName);
    }
}
