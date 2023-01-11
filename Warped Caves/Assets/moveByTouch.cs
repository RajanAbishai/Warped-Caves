using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveByTouch : MonoBehaviour
{
    
    void Update()
    {
        if (Input.touchCount > 0) // are there any touches at all
        {
            print("detected");

            Touch touch = Input.GetTouch(0); //0, 1, 2

            Vector3 touchPosition = Camera.main.ScreenToWorldPoint(touch.position);

            touchPosition.z = 0f;
            transform.position = touchPosition;

        }

       // else if (Input.touchCount == 0) { print("no touch"); }
    }



    public void touchinput()
    {
        print("touched");
    }

}
