using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Life_Manager : MonoBehaviour
{
    public GameObject[] Lifes;
    public GameObject Game_Over;
    private int current_life = 2;
    private void Awake()
    {
        
        Object.add_speed = 0;
        PickUp.hold = false;
        Time.timeScale = 1;
    }
    public void Damage()
    {
        
        if (current_life >= 0)
        {
            
            Destroy(Lifes[current_life].gameObject);
            current_life--;
        }
    }
    private void Update()
    {
        if (current_life < 0)
        {
            
            Time.timeScale = 0;
            Game_Over.SetActive(true);
        }
    }
}
