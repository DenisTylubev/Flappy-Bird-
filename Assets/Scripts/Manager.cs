using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Manager : MonoBehaviour
{
    public GameObject gameOverCAnvas;
    private void Start()
    {
        Time.timeScale = 1;
    }

     public void GameOver()
    {

        gameOverCAnvas.SetActive(true);
        Time.timeScale = 0;
    }
    public void Restart()
    {
        SceneManager.LoadScene(0);

    }
}
