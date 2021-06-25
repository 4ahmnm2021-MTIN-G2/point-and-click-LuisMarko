using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PickUp : MonoBehaviour
{
    private Transform player_pos;
    public static GameObject obj;
    public static int index;
    public static bool hold;
    private void Awake()
    {
        // Get the player's position
        player_pos = GameObject.FindGameObjectWithTag("Player").GetComponent<Transform>();
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("object") && !hold)
        {
            //Get the object information
            obj = collision.gameObject;
            obj.transform.parent = player_pos;
            obj.transform.position = player_pos.position;
            index = obj.GetComponent<Object>().color_index;
            //Set the horizontal speed of the object to 0
            obj.GetComponent<Object>().speed_x = 0;
            hold = true;
        }
    }
}
