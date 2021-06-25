using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player_Move : MonoBehaviour
{
    public float speed;
    Vector2 clickPos;
    bool moving;
    private void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            // Get the position of the mouse
           clickPos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
           moving = true;
        }
        if (moving && (Vector2)transform.position != clickPos)
        {
            //Move the player to the respective position
            transform.position = Vector2.MoveTowards(transform.position, clickPos, speed * Time.deltaTime);
        }
        else
            moving = false;
    }
    //Stop if you are touching the belt
    private void OnCollisionStay2D(Collision2D collision)
    {
        if(collision.gameObject.tag == "belt")
        {
            moving = false;
        }
    }
}
