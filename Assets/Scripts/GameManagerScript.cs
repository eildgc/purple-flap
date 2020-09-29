using System.Collections;
using System.Collections.Generic;
using System.Threading;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GameManagerScript : MonoBehaviour
{

    public GameObject gameOverCanvas;
    private string sceneName;
    private Scene pistScene;

    // Start is called before the first frame update
    void Start()
    {
        //Get Scene
        pistScene = SceneManager.GetActiveScene();
        sceneName = pistScene.name;

        //Taco & Ely <3 #taquelyiscanon
          if(gameOverCanvas != null)
          {
                gameOverCanvas.SetActive(false);
                Time.timeScale = 1;
          }
    }

    // Game Over Screen
    public void GameOver()
    {
        if(gameOverCanvas != null)
        {

        gameOverCanvas.SetActive(true);
        Time.timeScale = 0;
        }
    }

    public void GameStart() 
    {
        SceneManager.LoadScene("Prep-Scene");
    }
    public void Replay()
    {
        //gameOverCanvas.SetActive(false);
        SceneManager.LoadScene("Prep-Scene");

    }

    void OnInputPress()
    {
        if (Input.GetKey("space"))
        {
            SceneManager.LoadScene("Prep-Scene");
        }

    }

    void Update(){
        
        if (sceneName == "Game-Title")
        {
            if(Input.GetKeyDown("space"))
            {
                SceneManager.LoadScene("Prep-Scene");
            }

            if(Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);

                if(touch.phase == TouchPhase.Began)
                {
                    //Jump
                    SceneManager.LoadScene("Prep-Scene");
                }
            }

        }
        
        if(gameOverCanvas != null && gameOverCanvas.activeSelf)
         {
            if (Input.GetKeyDown("space"))
            {
                SceneManager.LoadScene("Prep-Scene");
            }

            if(Input.touchCount > 0)
            {
                Touch touch = Input.GetTouch(0);

                if(touch.phase == TouchPhase.Began)
                {
                    //Jump
                    SceneManager.LoadScene("Prep-Scene");
                }
            }

         }

        
    }
}
