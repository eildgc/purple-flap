using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{

    public GameObject gameOverCanvas;

    // Start is called before the first frame update
    void Start()
    {
        //Taco & Ely <3 #taquelyiscanon
        gameOverCanvas.SetActive(false);
        Time.timeScale = 1;
    }

    // Game Over Screen
    public void GameOver()
    {
        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
    }

    public void Replay()
    {
        //gameOverCanvas.SetActive(false);
        SceneManager.LoadScene(0);
    }
}
