using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public GameManagerScript gameManager;
    public float velocity = 1;
    private Rigidbody2D rb;
    public bool starterCommand = false;


    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody2D>();  
        starterCommand = false;

    }

    // Update is called once per frame
    void Update()
    {
        
        // Mouse Controller and keyboard
        if(Input.GetMouseButtonDown(0) || Input.GetKeyDown("space"))
        {
            //Jump
            rb.velocity = Vector2.up * velocity;
        }

        // Touch Controller
        if(Input.touchCount > 0)
        {
            Touch touch = Input.GetTouch(0);

            if(touch.phase == TouchPhase.Began)
            {
                //Jump
                rb.velocity = Vector2.up * velocity;
            }
        }
    }

    //Loosing!!!
    private void OnCollisionEnter2D(Collision2D collision)
    {
        gameManager.GameOver();
    }


}
