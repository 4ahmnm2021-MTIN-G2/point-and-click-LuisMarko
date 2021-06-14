﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class DragObject : MonoBehaviour

{

    private Vector3 mOffset;



    private float mXCoord;



    void OnMouseDown()

    {

        mXCoord = Camera.main.WorldToScreenPoint(

            gameObject.transform.position).x;



        // Store offset = gameobject world pos - mouse world pos

        mOffset = gameObject.transform.position - GetMouseAsWorldPoint();

    }



    private Vector3 GetMouseAsWorldPoint()

    {

        // Pixel coordinates of mouse (x,y)

        Vector3 mousePoint = Input.mousePosition;



        // z coordinate of game object on screen

        mousePoint.z = mXCoord;



        // Convert it to world points

        return Camera.main.ScreenToWorldPoint(mousePoint);

    }



    void OnMouseDrag()

    {

        transform.position = GetMouseAsWorldPoint() + mOffset;

    }

}

