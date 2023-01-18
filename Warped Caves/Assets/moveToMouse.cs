using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveToMouse : MonoBehaviour
{
    public float speed = 5f;
    private Vector3 target;

    // Start is called before the first frame update
    void Start()
    {
        target = transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) // 0 for left mouse button
        {
            target = Camera.main.ScreenToWorldPoint(Input.mousePosition); //convert where you click on the screen to 
            target.z = transform.position.z; //since it's a 2D game.  

        }

        transform.position = Vector3.MoveTowards(transform.position, target, speed * Time.deltaTime);
    }
}
