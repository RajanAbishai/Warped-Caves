using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class touchControls : MonoBehaviour
{

    private playerWalk pw;

    void Start()
    {
        pw = GetComponent<playerWalk>();

    }

    
    void Update()
    {

        if (Input.touchCount > 0) // we can have upto 5 touches simultaneously on the screen and it will detect all of them
        {
            Touch t = Input.GetTouch(0); // Index is mentioned because this will be the first touch
            // t.position is in screen coordinates because we are touching the phone.. but our character is in world coordinates

            Vector3 t_Pos = Camera.main.ScreenToWorldPoint(t.position);


            if (t_Pos.x > 0 && t_Pos.y>0)
            {
                print("Right and up"); //YES
                pw.MoveRight();
                pw.MoveUp(); // move up added
            }


            else if (t_Pos.x < 0 && t_Pos.y<0)
            {
                print("Left and Down "); //YES
                pw.MoveLeft();
                pw.MoveDown(); // move down added
            }


            else if (t_Pos.x < 0 && t_Pos.y > 0)
            {
                print("Left and up"); //YES
                pw.MoveLeft();
                pw.MoveUp(); //move up added
            }

            else if (t_Pos.x > 0 && t_Pos.y < 0)
            {
                print("left and down"); //YES
                pw.MoveRight();
                pw.MoveDown();

            }




            else { pw.StopMoving(); }


        }
        
    }





}
