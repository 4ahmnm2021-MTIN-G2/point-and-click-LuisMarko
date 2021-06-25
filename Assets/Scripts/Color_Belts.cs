using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Color_Belts : MonoBehaviour
{
    public int color_id;
    public Transform point;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("putDown") && PickUp.hold)
        {
          
            PickUp.obj.transform.position = point.transform.position;
            PickUp.obj.transform.parent = gameObject.transform;
            PickUp.obj.GetComponent<Object>().speed_y = 2.5f;
            PickUp.hold = false;
        }
    }
}
