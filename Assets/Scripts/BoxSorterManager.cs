using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BoxSorterManager : MonoBehaviour
{
    public Vector3 mausPos;
    public Vector3 mausPosWorld;
    public Vector2 worldPos2D;
    public Camera mainCam;

    public GameObject beltRotRed;
    public GameObject beltRotGre;
    public GameObject beltRotBlu;



    void Start()
    {
        beltRotRed = GameObject.FindGameObjectWithTag("BeltRRot");
        beltRotGre = GameObject.FindGameObjectWithTag("BeltGRot");
        beltRotBlu = GameObject.FindGameObjectWithTag("BeltBRot");
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            RaycastHit hit;
            Ray ray = mainCam.ScreenPointToRay(Input.mousePosition);

            if (Physics.Raycast(ray, out hit))
            {
                Debug.Log(hit.transform.name);
                if(hit.collider.gameObject.tag == "RedButton")
                {
                    beltRotRed.transform.Rotate(0.0f, 0.0f, -90.0f, Space.World);
                }
                if (hit.collider.gameObject.tag == "GreenButton")
                {
                    beltRotGre.transform.Rotate(0.0f, 0.0f, -90.0f, Space.World);
                }
                if (hit.collider.gameObject.tag == "BlueButton")
                {
                        beltRotBlu.transform.Rotate(0.0f, 0.0f, -90.0f); 
                    }
                }
            }
        }
    }


