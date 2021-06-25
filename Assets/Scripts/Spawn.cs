using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawn : MonoBehaviour
{
    public GameObject[] Objects;
    public float waitTime_initial;
    private float waitTime;
    public float step;
    private int counter;
    private void Awake()
    {
        //Get the initial time
        waitTime = waitTime_initial;
        //Start to create objects
        StartCoroutine("Create");
    }
    IEnumerator Create()
    {
        while (true)
        {
            if(counter % 3 == 0)
            {
                //Increase the speed of the objects
                Object.add_speed += step;
                //Decrease the time betwen objects
                if(waitTime > 1.3f)
                    waitTime -= 0.1f;
            }
            //Spawn one random object from the list
            Instantiate(Objects[Random.Range(0,Objects.Length)], transform.position, Quaternion.identity);
            //Wait some time
            yield return new WaitForSeconds(waitTime);
            counter++;
        }
    }
}
