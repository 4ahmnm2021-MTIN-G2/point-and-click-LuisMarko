using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Object : MonoBehaviour
{
    public float speed_x = 1.3f;
    public float speed_y;
    public int color_index;
    public static float add_speed;
    public Rigidbody2D rb;
    void Awake()
    {
         speed_x += add_speed;
    }
    private void Update()
    {
      
        rb.velocity = new Vector3(speed_x,speed_y, 0);
    }
}
