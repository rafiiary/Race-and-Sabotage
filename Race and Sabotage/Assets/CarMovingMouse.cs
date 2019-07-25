﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CarMovingMouse : MonoBehaviour
{
    public GameObject CenterOfScreen;
    private Vector3 center;
    public GameObject WaypointFollower;
    private float distanceBetweenMouseAndCenter, totalAngleFromTurn, CenterLength, CenterAngle, MouseAngle, mouseDistance;
    public GameObject isThisTheOrigin;
    private Vector3 currentMouseTransformVector;
    private bool movedMouse=false;
    public GameObject pivot;
    private float sss;
    public GameObject car;
    private bool positive = false;
    // Start is called before the first frame update
    void Start()
    {
        center = CenterOfScreen.transform.position;
        Debug.Log(center.ToString() + "this is the center");
        Debug.Log(isThisTheOrigin.transform.position.ToString() + "isthisorigin");
        currentMouseTransformVector = Input.mousePosition;
    }

    // Update is called once per frame
    void Update()
    {
        //pivot.transform.position = new Vector3(car.transform.position.x, car.transform.position.y, car.transform.position.z);
        Rect screenRect = new Rect(0, 0, Screen.width, Screen.height);
        //Debug.Log(Input.mousePosition);
        //Debug.Log(Mathf.Acos(0.25f).ToString() + "ACOS OF MATH");
        if (Input.mousePosition.x != currentMouseTransformVector.x & Input.mousePosition.y != currentMouseTransformVector.y)
        {
            Debug.Log(Input.mousePosition.x != currentMouseTransformVector.x);
            Debug.Log(Input.mousePosition.y != currentMouseTransformVector.y);
            movedMouse = true;
            currentMouseTransformVector = Input.mousePosition;
        }
        else
        {
            movedMouse = false;
        }
        if (screenRect.Contains(Input.mousePosition)){
            Debug.Log("In");
            movedMouse = false;
            //this.transform.position = new Vector3(this.transform.position.x + DifferenceInX(), this.transform.position.y + DifferenceInY(), this.transform.position.z);
            AngleBetweenCursorAndYCoordinateOfCenter();
            Debug.Log((AngleBetweenCursorAndYCoordinateOfCenter() * (180 / Mathf.PI)).ToString() + "angle!!!!!!!");
            if(AngleBetweenCursorAndYCoordinateOfCenter() * (180 / Mathf.PI) > 0)
            {
                if(!positive)
                {
                    pivot.transform.eulerAngles = new Vector3(0, 0, 0);
                }
                positive = true;
                if (pivot.transform.rotation.y + 2 > 0)
                {
                    pivot.transform.Rotate(0, 2, 0);
                }
            }
            else
            {
                if (positive)
                {
                    pivot.transform.eulerAngles = new Vector3(0, 0, 0);
                }
                positive = false;
                if (pivot.transform.rotation.y - 2 < 0)
                {
                    pivot.transform.Rotate(0, -2, 0);
                }
            }
            //pivot.transform.eulerAngles = new Vector3(0, AngleBetweenCursorAndYCoordinateOfCenter() * (180 / Mathf.PI) + car.transform.rotation.y, 0); 
        }
        else
        {
            Debug.Log("out");
        }
    }
    float DifferenceInX()
    {
        return Input.mousePosition.x - center.x;
    }
    float DifferenceInY()
    {
        return Input.mousePosition.y - center.y;
    }
    float lengthOfVector(float x, float y, float x1, float y1)
    {
        return Mathf.Sqrt(Mathf.Pow(x - x1, 2f) + Mathf.Pow(y - y1, 2f));
    }
    float AngleBetweenCursorAndYCoordinateOfCenter()
    {
        distanceBetweenMouseAndCenter = lengthOfVector(center.x, center.y, Input.mousePosition.x, Input.mousePosition.y);
        //Debug.Log(distanceBetweenMouseAndCenter.ToString() + "distance between mouse and center");
        CenterLength = lengthOfVector(center.x, center.y, 0f, 0f);
        //Debug.Log(CenterLength + "center length");
        CenterAngle = Mathf.Acos(center.x / CenterLength);
        mouseDistance = lengthOfVector(Input.mousePosition.x, Input.mousePosition.y, 0, 0);
        //Debug.Log(mouseDistance.ToString() + "mouse distance");
        //Debug.Log((Mathf.PI / 2 + CenterAngle) * 180/ Mathf.PI);
        MouseAngle = (Mathf.PI/2 + CenterAngle) - (Mathf.Acos((Mathf.Pow(CenterLength, 2f) + Mathf.Pow(distanceBetweenMouseAndCenter, 2f) - Mathf.Pow(mouseDistance, 2f)) / (2 * CenterLength * distanceBetweenMouseAndCenter)));
        sss = (Mathf.Acos((Mathf.Pow(CenterLength, 2f) + Mathf.Pow(distanceBetweenMouseAndCenter, 2f) - Mathf.Pow(mouseDistance, 2f)) / (2 * CenterLength * distanceBetweenMouseAndCenter)));
        //Debug.Log(MouseAngle.ToString() + "mouse angle in radians");
        //the mouse is either in the second or the first 45 degrees of the 3rd quadrant
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        Debug.DrawRay(Input.mousePosition, forward, Color.green, 3);
        if (MouseAngle * 180 / Mathf.PI > 0)
        {
            return -MouseAngle;
        }
        //the mouse is in the first 45 degrees of the first quadrant
        else if (sss > (CenterAngle + Mathf.PI / 2))
        {
            Debug.Log("FIRST QUADRANT");
            return (sss - CenterAngle - Mathf.PI / 2);
        }
        //mouse is in the rest of the 180 degrees
        else
        {
            return (float)0.0;
        }
    }
    void MoveMouse()
    {
        Debug.Log("update");
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.Log(Input.mousePosition);
        RaycastHit hit;
        //Debug.Log(Input.mousePosition);
        //Debug.Log(ray.origin);
        Debug.DrawRay(ray.origin, ray.direction * 100, Color.green, 3);
        if (Physics.Raycast(ray, out hit, 1000000, LayerMask.GetMask("UI")))
        {
            Debug.Log("DID IT ENTER???");
            Debug.DrawRay(ray.origin, ray.direction * 10, Color.green, 1);
            Vector3 paddlePos = new Vector3(hit.point.x, this.transform.position.y, this.transform.position.z);
            //paddlePos.x = Mathf.Clamp(hit.point.x, minX, maxX);
            this.transform.position = paddlePos;
        }
    }
    Vector3 getCursorWorldPosition()
    {
        //finding point in world in cursor position
        Debug.Log("1");
        Plane groundPlane = new Plane(Vector3.up, new Vector3(gameObject.transform.position.x, gameObject.transform.position.y, gameObject.transform.position.z));
        Debug.Log("2");
        Vector3 forward = transform.TransformDirection(Vector3.forward) * 10;
        Debug.DrawRay(Input.mousePosition, forward, Color.green, 3);
        Debug.Log(Input.mousePosition);
        Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
        Debug.Log("3");
        float distance;
        //simply initializing vector3 point, nothing else, this vector zero does nothing
        Vector3 point = Vector3.zero;
        Debug.Log("4");
        if (groundPlane.Raycast(ray, out distance))
        {
            Debug.Log("5");
            point = ray.GetPoint(distance);
        }

        return point;
    }
}
