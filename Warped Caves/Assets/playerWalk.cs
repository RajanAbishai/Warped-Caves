using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class playerWalk : MonoBehaviour
{

    //private playerAnimation playerAnim;
    private Rigidbody2D myBody;

    private float speed = 2f;

    void Start()
    {
        //playerAnim() = GetComponent<PlayerAnimation>();
        myBody = GetComponent<Rigidbody2D>();

        
    }

    
    void Update()
    {
        //DetectInput(); disabled to prevent the character from moving using keyboard controls

    }

    public void MoveUp()
    {
        //myBody.velocity = new Vector2(speed, myBody.velocity.x);
        myBody.velocity = new Vector2(myBody.velocity.x, speed); //modified

    }

    public void MoveDown()
    {
        myBody.velocity = new Vector2(myBody.velocity.x, -speed); //modified
    }


    public void MoveLeft()
    {
        myBody.velocity = new Vector2(-speed, myBody.velocity.y);

    }


    public void MoveRight()
    {
        myBody.velocity = new Vector2(speed, myBody.velocity.y);
    }

    public void StopMoving()
    {
        myBody.velocity = new Vector2(0f, myBody.velocity.y);
    }

    void DetectInput()
    {
        float x = Input.GetAxisRaw("Horizontal");

        if (x > 0)
        {
            MoveRight();
        }

        else if (x < 0)
        {
            MoveLeft();
        }

        else
        {
            StopMoving();
        }


    }




}
