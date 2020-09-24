using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneChanger : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
          if(Input.GetMouseButtonDown(0) || Input.GetKeyDown("space"))
        {
            //JGotoMainScene
            SceneManager.LoadScene("Main-Scene");
        }

        // Touch Controller
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Began)
            {
                //Jump
                SceneManager.LoadScene("Main-Scene");
            }
        }
    }
}
