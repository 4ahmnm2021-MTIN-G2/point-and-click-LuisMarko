using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checker : MonoBehaviour
{
    public int index;
    public Life_Manager manager;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.CompareTag("object"))
        {
            //Check if color is wrong
            if(collision.GetComponent<Object>().color_index != index)
            {
                manager.Damage();
            }
            Destroy(collision.gameObject);
        }
    }
}
